Merhaba projenin sorunsuz çalışması için öncelikle Mssql de ProductDb adında bir database oluşturmalı ve aşağıdaki kodu Sorgu ekranında çalıştırmalısınız 


USE [ProductDb]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 24.04.2025 15:32:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductStatusId] [bigint] NOT NULL,
	[ProductStatusName] [nvarchar](255) NOT NULL,
	[ProductUrl] [nvarchar](500) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[TitleDomestic] [nvarchar](255) NOT NULL,
	[DescriptionDomestic] [nvarchar](max) NOT NULL,
	[Sku] [nvarchar](100) NOT NULL,
	[Barcode] [nvarchar](100) NOT NULL,
	[OtherCode] [nvarchar](100) NOT NULL,
	[Stock] [int] NOT NULL,
	[CurrencyName] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[PriceDiscountedDomestic] [decimal](18, 2) NOT NULL,
	[PriceDiscounted] [decimal](18, 2) NOT NULL,
	[IsFeatured] [bit] NOT NULL,
	[IsElonkyFeatured] [bit] NOT NULL,
	[HasVideo] [bit] NOT NULL,
	[HasPersonalization] [bit] NOT NULL,
	[IsTaxable] [bit] NOT NULL,
	[WhenMade] [nvarchar](100) NOT NULL,
	[WhoMade] [nvarchar](100) NOT NULL,
	[PersonalizationDescription] [nvarchar](max) NOT NULL,
	[IsDigital] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


