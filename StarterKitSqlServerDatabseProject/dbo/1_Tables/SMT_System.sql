CREATE TABLE [dbo].[SMT_System] (
    [System_Code]          NVARCHAR (12)   NOT NULL,
    [Id]                   INT             IDENTITY (1, 1) NOT NULL,
    [SystemNameAr]         NVARCHAR (100)  NOT NULL,
    [SystemNameEn]         NVARCHAR (100)  NULL,
    [SystemAbbreviationAr] NVARCHAR (10)   NULL,
    [SystemAbbreviationEn] NVARCHAR (10)   NULL,
    [BackgroundImageUrl]   VARBINARY (MAX) NULL,
    [Logo]                 VARBINARY (MAX) NULL,
    [BackgroundColor]      NVARCHAR (7)    NULL,
    [FontColor]            NVARCHAR (7)    NULL,
    [CreatedBy]            NVARCHAR (100)  DEFAULT ('EF Migration') NULL,
    [CreatedOn]            DATETIME2 (7)   DEFAULT (getutcdate()) NULL,
    [ModifiedBy]           NVARCHAR (100)  DEFAULT ('EF Migration') NULL,
    [ModifiedOn]           DATETIME2 (7)   DEFAULT (getutcdate()) NULL,
    [IPAddress]            NVARCHAR (15)   DEFAULT ('::1') NULL,
    [isActive]             BIT             DEFAULT ((1)) NULL,
    CONSTRAINT [PK_SMT_System] PRIMARY KEY CLUSTERED ([System_Code] ASC)
);

