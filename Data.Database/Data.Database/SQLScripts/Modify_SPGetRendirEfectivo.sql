USE [POSUTSimplex]
GO
/****** Object:  StoredProcedure [dbo].[GetRendirEfectivo]    Script Date: 22/07/2023 20:26:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREAR SP GetEfectivo A Rendir por caja
--ALTER PROCEDURE [dbo].[GetRendirEfectivo]
--   @pCaja_id INT,
--   @efectivo_a_rendir MONEY OUTPUT
--AS
--BEGIN
--   SET NOCOUNT ON;

--   DECLARE @ventas_efectivo MONEY;
--   DECLARE @neto_movimientos MONEY;
--   DECLARE @saldoInicial MONEY; 

--   -- Definir el parámetro de salida para la función dbo.GetNetoMovimientosCaja
--   DECLARE @pNetoMovimientos MONEY;

--   -- Llamar a la función dbo.GetNetoMovimientosCaja y asignar el resultado al parámetro de salida
--   EXEC dbo.GetNetoMovimientosCaja @pCaja_id, @pNetoMovimientos OUTPUT;

--   SELECT @ventas_efectivo = COALESCE(SUM(total), 0)
--   FROM Ventas
--   WHERE tipoPago = 'Efectivo' AND caja_id = @pCaja_id;

--   SELECT @ventas_efectivo = COALESCE(SUM(total), 0)
--   FROM Ventas
--   WHERE tipoPago = 'Efectivo' AND caja_id = @pCaja_id;

--   SET @efectivo_a_rendir = @ventas_efectivo + @pNetoMovimientos;
--END
ALTER PROCEDURE [dbo].[GetRendirEfectivo]
    @pCaja_id INT,
    @efectivo_a_rendir MONEY OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ventas_efectivo MONEY;
    DECLARE @neto_movimientos MONEY;
    DECLARE @saldoInicial MONEY; 

    -- Obtener el saldo inicial de la caja
    SELECT @saldoInicial = saldo_inicial FROM Cajas WHERE id = @pCaja_id;

    -- Definir el parámetro de salida para la función dbo.GetNetoMovimientosCaja
    DECLARE @pNetoMovimientos MONEY;

    -- Llamar a la función dbo.GetNetoMovimientosCaja y asignar el resultado al parámetro de salida
    EXEC dbo.GetNetoMovimientosCaja @pCaja_id, @pNetoMovimientos OUTPUT;

    -- Obtener el neto de las ventas en efectivo
    SELECT @ventas_efectivo = COALESCE(SUM(monto_pagado), 0)
    FROM Ventas
    WHERE tipoPago = 'Efectivo' AND caja_id = @pCaja_id;

    -- Calcular el efectivo a rendir
    SET @efectivo_a_rendir = @saldoInicial + @ventas_efectivo + @pNetoMovimientos;
END
