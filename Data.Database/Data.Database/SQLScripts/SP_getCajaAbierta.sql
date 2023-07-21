USE [POSUTSimplex]
GO

/****** Object:  StoredProcedure [dbo].[GetRendirEfectivo]    Script Date: 24/06/2023 17:33:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCajaAbierta]
    @pCaja_id INT,
    @cajaAbierta bit OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @cajaAbierta = CASE WHEN fecha_cierre IS NULL then 1 else 0 end
    FROM Cajas
    WHERE id = @pCaja_id;

END
GO


