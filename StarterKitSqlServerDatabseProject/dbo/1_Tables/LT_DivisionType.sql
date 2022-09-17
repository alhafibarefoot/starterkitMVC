CREATE TABLE [dbo].[LT_DivisionType] (
    [DivisionType_Code] NVARCHAR (12)  NOT NULL,
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [DivisionNameEn]    NVARCHAR (50)  NOT NULL,
    [DivisionNameAr]    NVARCHAR (50)  NULL,
    [CreatedBy]         NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]         DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]        NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]        DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]         NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]          BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_LT_DivisionType] PRIMARY KEY CLUSTERED ([DivisionType_Code] ASC)
);

