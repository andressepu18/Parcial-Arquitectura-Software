USE [Parqueadero]
GO

/****** Object:  Table [dbo].[ingresos]    Script Date: 18/02/2026 10:41:18 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ingresos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [char](6) NOT NULL,
	[tipoVehiculo] [char](1) NOT NULL,
	[momentoIngreso] [datetime] NOT NULL,
 CONSTRAINT [PK_ingresos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


