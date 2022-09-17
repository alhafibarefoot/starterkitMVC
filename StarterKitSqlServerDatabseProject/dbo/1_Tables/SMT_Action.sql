CREATE TABLE [dbo].[SMT_Action] (
    [Action_Code]  NVARCHAR (12)  NOT NULL,
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [ActionNameAr] NVARCHAR (100) NOT NULL,
    [ActionNameEn] NVARCHAR (100) NULL,
    [CreatedBy]    NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]    DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]   NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]   DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]    NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]     BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_SMT_Action] PRIMARY KEY CLUSTERED ([Action_Code] ASC)
);

