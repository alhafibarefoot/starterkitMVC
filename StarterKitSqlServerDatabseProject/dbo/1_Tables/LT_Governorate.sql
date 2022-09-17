CREATE TABLE [dbo].[LT_Governorate] (
    [Governorate_Code] NVARCHAR (12)  NOT NULL,
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [LF_Country_Code]  NVARCHAR (12)  NOT NULL,
    [GovernorateEN]    NVARCHAR (50)  NULL,
    [GovernorateAR]    NVARCHAR (50)  NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]        DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]       NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]       DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]        NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]         BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_LT_Governorate] PRIMARY KEY CLUSTERED ([Governorate_Code] ASC),
    CONSTRAINT [FK_LT_Governorate_LT_Country_LF_Country_Code] FOREIGN KEY ([LF_Country_Code]) REFERENCES [dbo].[LT_Country] ([Country_Code]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_LT_Governorate_LF_Country_Code]
    ON [dbo].[LT_Governorate]([LF_Country_Code] ASC);

