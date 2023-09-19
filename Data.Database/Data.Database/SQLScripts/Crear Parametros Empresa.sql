DROP TABLE PARAMETROS_EMPRESA
CREATE TABLE PARAMETROS_EMPRESA (
    Nombre NVARCHAR(255)  NULL,
    Direccion NVARCHAR(255)  NULL,
    Telefono NVARCHAR(20)  NULL,
    ImagenPath NVARCHAR(255)  NULL,
    Impresora1 NVARCHAR(255)  NULL,
    CUIT NVARCHAR(20)  NULL,
    NombreFiscal NVARCHAR(255)  NULL,
    DireccionFiscal NVARCHAR(255)  NULL,
    SituacionFiscal NVARCHAR(255)  NULL,
    CertificadoDigital NVARCHAR(255)  NULL,
    ClaveCertificado NVARCHAR(255)  NULL,
    PuntoDeVenta NVARCHAR(10)  NULL,
    InicioDeActividades NVARCHAR(10)  NULL,
    IngresosBrutos NVARCHAR(20)  NULL,
    EsProduccion BIT  NULL,
    UrlQrAfip NVARCHAR(255)  NULL
);

INSERT INTO PARAMETROS_EMPRESA (Nombre, Direccion, Telefono, ImagenPath, Impresora1, CUIT, NombreFiscal, DireccionFiscal, SituacionFiscal, CertificadoDigital, ClaveCertificado, PuntoDeVenta, InicioDeActividades, IngresosBrutos, EsProduccion, UrlQrAfip)
VALUES ('El Arbolito de Antoine', --Nombre
'Chacabuco 842',--@Direccion, 
'123456789',--@Telefono, 
'c:/imagen.png',--@ImagenPath, 
'',--@Impresora1, 
'27350319250',--@CUIT, 
'Florencia Anahi Polvaran',--@NombreFiscal, 
'Chacabuco 842, Venado Tuerto, Santa Fe',--@DireccionFiscal, 
'Monotributista',--@SituacionFiscal, 
'c:/Certificado.pdx',--@CertificadoDigital, 
'tony21',--@ClaveCertificado, 
'4',--@PuntoDeVenta, 
'23/06/2021',--@InicioDeActividades, 
'045/030303',--@IngresosBrutos, 
0,--@EsProduccion, 
'www.afip.com'--@UrlQrAfip
);

