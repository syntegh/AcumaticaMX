If Exists (Select * From sys.objects Where object_id = OBJECT_ID(N'[MXAPAddressExtension]') And type in (N'U'))
	Drop Table [MXAPAddressExtension]
Go

/****** Object:  Table [dbo].[MXAPAddressExtension] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MXAPAddressExtension](
	-- multi-tenancy support
	[CompanyID]		[int] NOT NULL DEFAULT ((0)),

	-- surrogate/natural key
	[AddressID]		[int] NOT NULL,

	-- extension fields
	[Street]		[nvarchar](50) NULL,
	[ExtNumber]		[nvarchar](10) NULL,
	[IntNumber]		[nvarchar](10) NULL,
	[Neighborhood]	[nvarchar](50) NULL,
	[Municipality]	[nvarchar](50) NULL,
	[Reference]		[nvarchar](100) NULL,

	CONSTRAINT [MXAPAddressExtension_PK] PRIMARY KEY CLUSTERED 
	(
		[CompanyID] ASC,
		[AddressID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


