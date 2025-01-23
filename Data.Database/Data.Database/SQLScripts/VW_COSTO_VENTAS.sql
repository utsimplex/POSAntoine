USE [POSUTSimplex]
GO

/****** Object:  View [dbo].[COSTO_VENTAS]    Script Date: 12/11/2024 09:37:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[COSTO_VENTAS]
AS
select 
V.numVenta,
CAST(V.fechaHora as date) AS FECHA, 
CASE SUBSTRING(CFArtCodigo,1,2) 
WHEN 'OC' THEN CAST(cantidad * precio/2 AS DECIMAL (10,2))
WHEN 'TU' THEN CAST(cantidad * precio/1.7 AS DECIMAL (10,2))
WHEN 'UD' THEN CAST(cantidad * precio/2.1 AS DECIMAL (10,2))
WHEN 'CA' THEN CAST(cantidad * precio/1.4 AS DECIMAL (10,2))
WHEN 'AA' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'PP' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'LV' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'CC' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'HL' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'MB' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'JO' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'AV' THEN CAST(cantidad * precio/1.5 	 AS DECIMAL (10,2))
WHEN 'CH' THEN CAST(cantidad * precio/1.5 	 AS DECIMAL (10,2))
WHEN 'JG' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'BL' THEN CAST(cantidad * precio/2 	 AS DECIMAL (10,2))
WHEN 'GO' THEN CAST(cantidad * precio/1.5 	 AS DECIMAL (10,2))
WHEN 'NU' THEN CAST(cantidad * precio/1.5 	 AS DECIMAL (10,2))
WHEN 'VD' THEN CAST(cantidad * precio/1.7 AS DECIMAL (10,2))
ELSE 0
END AS COSTO,
CASE V.DESCUENTO WHEN 0 THEN
	CASE VA.descuento WHEN 0 THEN CAST(Cantidad * precio *(1-ISNULL(descuento_porcentaje,0)/100)AS DECIMAL (10,2))
	ELSE CAST(Cantidad * precio - ISNULL(VA.descuento,0)AS DECIMAL (10,2)) END 
		ELSE CAST((Cantidad * precio) - ISNULL(DESCUENTOPORLINEA.descuento_linea,0)AS DECIMAL (10,2))
 END as PRECIO_LINEA_FINAL
 from 
Ventas_Articulos VA
INNER JOIN Ventas V ON VA.CFVenNumVenta=V.numVenta
LEFT JOIN (SELECT V1.descuento/COUNT(*) as descuento_linea,V1.numVenta as VENTA 
			FROM Ventas V1 INNER JOIN VENTAS_ARTICULOS VA1 ON V1.numVenta=VA1.CFVenNumVenta WHERE V1.descuento<>0 GROUP BY V1.numVenta,V1.descuento) DESCUENTOPORLINEA ON DESCUENTOPORLINEA.VENTA=V.numVenta

WHERE SUBSTRING(CFArtCodigo,1,2)<>'SE'
AND SUBSTRING(CFArtCodigo,1,2)<>'AR'
AND SUBSTRING(CFArtCodigo,1,2)<>'DI'
AND SUBSTRING(CFArtCodigo,1,2)<>'NC'
AND SUBSTRING(CFArtCodigo,1,2)<>'01'
AND SUBSTRING(CFArtCodigo,1,2)<>'02'
AND SUBSTRING(CFArtCodigo,1,2)<>'03'

GO

