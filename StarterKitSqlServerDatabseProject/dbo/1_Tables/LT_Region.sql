CREATE TABLE [dbo].[LT_Region] (
    [Region_Code]         NVARCHAR (12)  NOT NULL,
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [LF_Governorate_Code] NVARCHAR (12)  NOT NULL,
    [RegionEN]            NVARCHAR (50)  NULL,
    [RegionAR]            NVARCHAR (50)  NOT NULL,
    [CreatedBy]           NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]           DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]          NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]          DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]           NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]            BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_LT_Region] PRIMARY KEY CLUSTERED ([Region_Code] ASC),
    CONSTRAINT [FK_LT_Region_LT_Governorate_LF_Governorate_Code] FOREIGN KEY ([LF_Governorate_Code]) REFERENCES [dbo].[LT_Governorate] ([Governorate_Code]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_LT_Region_LF_Governorate_Code]
    ON [dbo].[LT_Region]([LF_Governorate_Code] ASC);

