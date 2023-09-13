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
    InicioDeActividades DATE  NULL,
    IngresosBrutos NVARCHAR(20)  NULL,
    EsProduccion BIT  NULL,
    UrlQrAfip NVARCHAR(255)  NULL
);