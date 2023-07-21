using AfipWsfeClient;
using Entidades;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace UI.Desktop.Ventas
{
    public static class Facturador
    {
        private static int PuntoDeVenta = 4;
        private static long CUIT = 27350319250;
        private static string RutaCertificado= @"C:\certificados\ElArbolito.p12";
        private static string ClaveCertificado= "AntonioRicardo21";
        private static bool FEProduccion=true;
        static FacturaElectronicaAdapter FacturaElectronicaAdapter = new FacturaElectronicaAdapter();
        static VentasAdapter VentasAdapter = new VentasAdapter();

        //public Facturador()
        //{
        //TO-DO: Parameters
        //CatalogoParametros parametros = new CatalogoParametros();
        //CUIT = (long)Convert.ToDouble(parametros.getOne("CUIT").Valor);
        //ClaveCertificado = parametros.getOne("Clave_Certificado").Valor;
        //FE_produccion = Convert.ToBoolean(parametros.getOne("FE_Produccion").Valor);
        //ptoVta = Convert.ToInt32(parametros.getOne("PtoVta").Valor);
        //}
        public async static Task facturarAsync(Venta Pedido, bool Monotributista)
        {
            //set ptoVta
            Pedido.PuntoDeVenta = PuntoDeVenta;

            //Get Login Ticket
            var loginClient = new LoginCmsClient { IsProdEnvironment = FEProduccion };
            var ticket = await loginClient.LoginCmsAsync("wsfe",
                                                         RutaCertificado,//ruta exacta certificado
                                                                         //"C:\\certificados\\certificado.p12",//ruta exacta certificado
                                                         ClaveCertificado,
                                                         true);

            var wsfeClient = new WsfeClient
            {
                IsProdEnvironment = FEProduccion,
                Cuit = CUIT,//cuit DROPS
                Sign = ticket.Sign,
                Token = ticket.Token
            };

            //Get next WSFE Comp. Number
            var comprobante = await wsfeClient.FECompUltimoAutorizadoAsync((int)Pedido.PuntoDeVenta, (int)Pedido.TipoComprobante);
            //await Task.WhenAll(comprobante);
            var compNumber = comprobante.Body.FECompUltimoAutorizadoResult.CbteNro + 1;
            var feCaeReq = new AfipServiceReference.FECAERequest();
            if (Monotributista)
            {
                feCaeReq = new AfipServiceReference.FECAERequest
                {
                    FeCabReq = new AfipServiceReference.FECAECabRequest
                    {
                        CantReg = 1,
                        CbteTipo = (int)Pedido.TipoComprobante,
                        PtoVta = (int)Pedido.PuntoDeVenta
                    },
                    FeDetReq = new List<AfipServiceReference.FECAEDetRequest>
    {
        new AfipServiceReference.FECAEDetRequest
        {
            CbteDesde = compNumber,
            CbteHasta = compNumber,
            CbteFch = Pedido.FechaHora.ToString("yyyyMMdd"),
            //CbteFch = "20221013",
            Concepto = 1,//1 productos  2 servicios  3 pds y ss
            DocNro = (int)Pedido.TipoDocumentoCliente == (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR?0:(long)Pedido.NumeroDocumentoCliente,
            DocTipo = (int)Pedido.TipoDocumentoCliente,
            ImpNeto = (double)Pedido.Neto+(double)Pedido.Iva,
            ImpTotal = (double)Pedido.Neto+(double)Pedido.Iva,
            ImpIVA = 0,
            //FchServDesde = "20221013",
            //FchServHasta = "20221013",
            MonCotiz = 1,
            MonId = "PES",
            //Iva = new List<AfipServiceReference.AlicIva>
            //{
            //    new AfipServiceReference.AlicIva
            //    {
            //        BaseImp = (double)Pedido.Neto,
            //        Id = 5,//IVA 21%
            //        Importe = (double)Pedido.Iva
            //    }
            //}
        }
    }
                };
            }
            else
            {

                //Build WSFE FECAERequest            
                feCaeReq = new AfipServiceReference.FECAERequest
                {
                    FeCabReq = new AfipServiceReference.FECAECabRequest
                    {
                        CantReg = 1,
                        CbteTipo = (int)Pedido.TipoComprobante,
                        PtoVta = (int)Pedido.PuntoDeVenta
                    },
                    FeDetReq = new List<AfipServiceReference.FECAEDetRequest>
    {
        new AfipServiceReference.FECAEDetRequest
        {
            CbteDesde = compNumber,
            CbteHasta = compNumber,
            CbteFch = Pedido.FechaHora.ToString("yyyyMMdd"),
            //CbteFch = "20221013",
            Concepto = 1,//1 productos  2 servicios  3 pds y ss
            DocNro = (int)Pedido.TipoDocumentoCliente == (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR?0:(long)Pedido.NumeroDocumentoCliente,
            DocTipo = (int)Pedido.TipoDocumentoCliente,
            ImpNeto = (double)Pedido.Neto,
            ImpTotal = (double)Pedido.Neto+(double)Pedido.Iva,
            ImpIVA = (double)Pedido.Iva,
            //FchServDesde = "20221013",
            //FchServHasta = "20221013",
            MonCotiz = 1,
            MonId = "PES",
            Iva = new List<AfipServiceReference.AlicIva>
            {
                new AfipServiceReference.AlicIva
                {
                    BaseImp = (double)Pedido.Neto,
                    Id = 5,//IVA 21%
                    Importe = (double)Pedido.Iva
                }
            }
        }
    }
                };
            }
            //Call WSFE FECAESolicitar
            var compResult = await wsfeClient.FECAESolicitarAsync(feCaeReq);
            //registrar request
            var request_json = new JavaScriptSerializer().Serialize(feCaeReq.FeCabReq);
            var request_det_json = new JavaScriptSerializer().Serialize(feCaeReq.FeDetReq[0]);
            //registrar response
            var response_json = new JavaScriptSerializer().Serialize(compResult.Body.FECAESolicitarResult.FeDetResp[0]);


            var observaciones = compResult.Body.FECAESolicitarResult.FeDetResp[0].Observaciones != null ? new JavaScriptSerializer().Serialize(compResult.Body.FECAESolicitarResult.FeDetResp[0].Observaciones.ToList()) : "";
            FacturaElectronica FE_Actual = new FacturaElectronica()
            {
                IdVenta = Pedido.NumeroVenta,
                Request = request_json,
                RequestDetalle = request_det_json,
                Response = response_json,
                Resultado = compResult.Body.FECAESolicitarResult.FeDetResp[0].Resultado,
                Observaciones = observaciones
            };

            FacturaElectronicaAdapter.RegistroFacturaElectronica(FE_Actual);

            if (compResult.Body.FECAESolicitarResult.FeDetResp[0].Resultado == "A")
            {
                Pedido.CAE = compResult.Body.FECAESolicitarResult.FeDetResp[0].CAE;
                DateTime dateCAE;
                DateTime.TryParseExact(compResult.Body.FECAESolicitarResult.FeDetResp[0].CAEFchVto, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateCAE);
                Pedido.VencimientoCAE = dateCAE;
                Pedido.NumeroTicketFiscal = compResult.Body.FECAESolicitarResult.FeDetResp[0].CbteDesde.ToString();
                Pedido.CuitEmisor = CUIT;
                VentasAdapter.ActualizarDatosFiscales(Pedido);
                //Pedido.Ticket_fiscal compResult.Body.FECAESolicitarResult.FeDetResp[0].
            }


        }
    }
}
