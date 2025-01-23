USE [POSUTSimplex]
GO

/****** Object:  Table [dbo].[Gastos]    Script Date: 05/03/2024 07:57:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Gastos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[tipoGasto] [nvarchar](100) NOT NULL,
	[descripcion] [nvarchar](200) NOT NULL,
	[monto] decimal(18,2) NOT NULL,
	[cajaId] bigint NULL,
) ON [PRIMARY]
GO
