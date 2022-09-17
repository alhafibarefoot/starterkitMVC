CREATE TABLE [dbo].[LT_LookupTableReferance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LookupCode] [nvarchar](3) NOT NULL,
	[LookupNameEn] [nvarchar](50) NOT NULL,
	[LookupNameAr] [nvarchar](50) NULL,
	[LastSerialNo] [int] NULL,
	[TemporarySerialNo] [int] NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime2](7) NULL,
	[IPAddress] [nvarchar](15) NULL,
	[ModifiedBy] [nvarchar](100) NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[isActive] [bit] NULL,
	[PadLeftNo] [int] NOT NULL,
 CONSTRAINT [PK_LT_LookupTableReferance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT ('EF Migration') FOR [CreatedBy]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT (getutcdate()) FOR [CreatedOn]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT ('::1') FOR [IPAddress]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT ('EF Migration') FOR [ModifiedBy]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT (getutcdate()) FOR [ModifiedOn]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT ((1)) FOR [isActive]
GO

ALTER TABLE [dbo].[LT_LookupTableReferance] ADD  DEFAULT ((4)) FOR [PadLeftNo]
GO
