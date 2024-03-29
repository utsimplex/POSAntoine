USE [POSUTSimplex]
GO
/****** Object:  StoredProcedure [dbo].[AddMovimientoCaja]    Script Date: 04/07/2023 18:34:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AddMovimientoCaja]
    @pCaja_id INT,
    @pMotivo NVARCHAR(1000),
    @pTipo NVARCHAR(200),
    @pMonto MONEY,
    @pUsuario NVARCHAR(100),
	@pNumVenta VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF @pTipo = 'Retiro' 
    BEGIN
        SET @pMonto = - ABS(@pMonto)
    END
    ELSE IF @pTipo = 'Ingreso'
    BEGIN
        SET @pMonto = ABS(@pMonto)
    END

    INSERT INTO Movimientos_Caja (caja_id, motivo, tipo, monto, usuario,numVenta)
    VALUES (@pCaja_id, @pMotivo, @pTipo, @pMonto, @pUsuario, @pNumVenta);
END
