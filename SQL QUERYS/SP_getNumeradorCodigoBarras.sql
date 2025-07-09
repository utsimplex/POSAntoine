USE [POSUTSimplex]
GO

/****** Object:  StoredProcedure [dbo].[getNumeradorCodigoProveedor]    Script Date: 09/07/2025 18:16:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[getNumeradorCodigoBarras]
    @pCodigoBarras NVARCHAR(100)

AS
BEGIN
declare @numero int;
declare @prefix varchar(2);
   
  set @numero= (SELECT TOP 1 cast(SUBSTRING(codigo,3,5) as integer) codigo
  from articulos where codigo_barras = @pCodigoBarras
  order by 1 desc)
  set @prefix= (SELECT TOP 1 SUBSTRING(codigo,1,2) codigo
  from articulos where codigo_barras = @pCodigoBarras)
  SELECT @prefix +''+ RIGHT(REPLICATE('0', 5) + CAST(@numero AS VARCHAR), 5) as codigo
END
GO


