USE [POSUTSimplex]
GO

/****** Object:  StoredProcedure [dbo].[getProximoNumeradorProveedor]    Script Date: 22/02/2024 17:09:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[getProximoNumeradorProveedor]
    @pProveedor NVARCHAR(100)
AS
BEGIN
declare @numero int;
declare @prefix varchar(2);
   
  set @numero= (SELECT TOP 1 cast(SUBSTRING(codigo,3,5) as integer)+1 codigo
  from articulos where marca=@pProveedor
  order by 1 desc)
  set @prefix= (SELECT TOP 1 SUBSTRING(codigo,1,2) codigo
  from articulos where marca=@pProveedor)
  SELECT @prefix +''+ RIGHT(REPLICATE('0', 5) + CAST(@numero AS VARCHAR), 5) as codigo
END
GO


