USE POSUTSimplex
--Agregar propiedades Fiscales a la venta
ALTER TABLE Ventas
ADD Neto decimal(18,2)
ALTER TABLE Ventas
ADD Iva decimal(18,2)
ALTER TABLE Ventas
ADD TipoComprobante int
ALTER TABLE Ventas
ADD PuntoDeVenta int
ALTER TABLE Ventas
ADD TicketFiscal varchar(15)
ALTER TABLE Ventas
ADD CAE varchar(25)
ALTER TABLE Ventas
ADD VencimientoCAE datetime
ALTER TABLE Ventas
ADD TipoDocumentoCliente int 
ALTER TABLE Ventas
ADD	NumeroDocumentoCliente bigint 
ALTER TABLE Ventas
ADD	NombreCliente varchar(100) 
ALTER TABLE Ventas
ADD	DireccionCliente varchar(100) 
ALTER TABLE Ventas
ADD	SituacionFiscalCliente int 
ALTER TABLE Ventas
ADD	CUITEMISOR bigint 