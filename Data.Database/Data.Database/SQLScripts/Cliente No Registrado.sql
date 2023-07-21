USE [POSUTSimplex]
GO

INSERT INTO [dbo].[Clientes]
           ([dni]
           ,[nombre]
           ,[apellido]
           ,[direccion]
           ,[telefono]
           ,[email]
           ,[tipo]
           ,[TipoDocumento]
           ,[SituacionFiscal]
           ,[TipoComprobante])
     VALUES
           ('0',
           'Cliente No Registrado',
           '',
           '',
           '',
           '',
           '',
           99,
           5,
           11)
GO


