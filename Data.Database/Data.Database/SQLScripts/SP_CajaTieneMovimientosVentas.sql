USE [POSUTSimplex]
GO
/****** Object:  StoredProcedure [dbo].[GetCajaAbierta]    Script Date: 25/06/2023 02:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCajaTieneMovimientosVentas]
    @pCaja_id INT,
    @cajaConMovimientos bit OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
	DECLARE @Movimientos INT =0;
	DECLARE @Ventas INT =0;

    SELECT @Ventas = count(numVenta)
    FROM Ventas
    WHERE caja_id = @pCaja_id;
	SELECT @Movimientos = count(id)
    FROM Movimientos_Caja
    WHERE caja_id = @pCaja_id;

	SET @cajaConMovimientos = CASE WHEN @Movimientos=0 and @Ventas=0 then 0 else 1 end
END
