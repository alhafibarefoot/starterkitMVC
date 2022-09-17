CREATE TABLE [dbo].[SEC_RolePermission] (
    [RolePermission_Code] NVARCHAR (450) NOT NULL,
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [RoleId]              NVARCHAR (128) NOT NULL,
    [Action_Code]         NVARCHAR (12)  NOT NULL,
    [Module_Code]         NVARCHAR (12)  NOT NULL,
    [CreatedBy]           NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]           DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]          NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]          DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]           NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]            BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_SEC_RolePermission] PRIMARY KEY CLUSTERED ([RolePermission_Code] ASC),
    CONSTRAINT [FK_SEC_RolePermission_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([RoleId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_SEC_RolePermission_RoleId]
    ON [dbo].[SEC_RolePermission]([RoleId] ASC);

