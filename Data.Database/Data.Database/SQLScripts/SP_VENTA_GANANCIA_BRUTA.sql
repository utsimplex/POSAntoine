USE [POSUTSimplex]
GO

/****** Object:  StoredProcedure [dbo].[VENTAS_GANANCIA_BRUTA]    Script Date: 12/11/2024 09:38:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[VENTAS_GANANCIA_BRUTA]  @pFechaDesde NVARCHAR(8),
    @pFechaHasta NVARCHAR(8)
AS
BEGIN

SELECT SUM(MONTO_BRUTO)-SUM(seña) AS MONTO_FINAL FROM (
select SUM(PRECIO_LINEA_FINAL)-SUM(COSTO) AS MONTO_BRUTO , 0 as seña
from costo_ventas where 
fecha Between @pFechaDesde and @pFechaHasta
UNION ALL 
SELECT 0 as MONTO_BRUTO,SUM(V.total) as SEÑA 
FROM VENTAS V INNER JOIN VENTAS_ARTICULOS VA ON VA.CFVenNumVenta=V.numVenta WHERE VA.CFArtCodigo='SEÑA' AND CAST(V.fechaHora AS DATE) Between @pFechaDesde and @pFechaHasta
) X
--WHERE 1=1
END

GO

