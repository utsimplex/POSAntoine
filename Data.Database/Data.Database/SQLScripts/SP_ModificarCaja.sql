USE [POSUTSimplex]
GO
/****** Object:  StoredProcedure [dbo].[CrearAbrirCaja]    Script Date: 25/06/2023 02:48:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarCaja]
(
    @id_caja int,
    @fecha_caja DATETIME,
    @saldo_inicial MONEY,
    @descripcion NVARCHAR(1000)
)
AS
BEGIN
    DECLARE @fecha_modificacion DATETIME = GETDATE()
    DECLARE @nuevoId INT

    UPDATE CAJAS SET descripcion=@descripcion,fecha_caja=@fecha_caja,saldo_inicial=@saldo_inicial where id=@id_caja

    SELECT * FROM Cajas WHERE id = @id_caja
END
