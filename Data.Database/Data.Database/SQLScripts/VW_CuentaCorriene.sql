CREATE VIEW dbo.Cuenta_Corriente
AS
select C.apellido+', '+C.nombre as Cliente,
CAST (v.NumeroDocumentoCliente as varchar) as Documento,
V.numVenta as Venta, 
V.fechaHora as Fecha,
V.total as Total,
V.monto_pagado as Pagado,
CASE WHEN TicketFiscal IS NULL THEN 'NO' ELSE 'SI' END AS Facturado,
V.total -V.monto_pagado as Pendiente
from Ventas V
INNER JOIN Clientes C ON C.dni = V.NumeroDocumentoCliente

GO