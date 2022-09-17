CREATE TABLE [dbo].[AspNetRoles] (
    [RoleId]        NVARCHAR (128) NOT NULL,
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [NameAr]        NVARCHAR (50)  NULL,
    [Description]   NVARCHAR (256) NULL,
    [Discriminator] NVARCHAR (128) NOT NULL,
    [CreatedBy]     NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]     DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]    NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]    DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]     NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]      BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

