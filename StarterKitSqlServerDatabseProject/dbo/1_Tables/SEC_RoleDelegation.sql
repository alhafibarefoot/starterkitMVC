CREATE TABLE [dbo].[SEC_RoleDelegation] (
    [RoleDelegation_Code]   NVARCHAR (450) NOT NULL,
    [Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [LF_Source_UserId]      NVARCHAR (128) NOT NULL,
    [LF_Destenation_UserId] NVARCHAR (128) NULL,
    [RoleId]                NVARCHAR (128) NULL,
    [StartDate]             DATETIME2 (7)  NOT NULL,
    [EndDate]               DATETIME2 (7)  NOT NULL,
    [CreatedBy]             NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]             DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]            NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]            DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]             NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]              BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_SEC_RoleDelegation] PRIMARY KEY CLUSTERED ([RoleDelegation_Code] ASC),
    CONSTRAINT [FK_SEC_RoleDelegation_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([RoleId]),
    CONSTRAINT [FK_SEC_RoleDelegation_AspNetUsers_LF_Destenation_UserId] FOREIGN KEY ([LF_Destenation_UserId]) REFERENCES [dbo].[AspNetUsers] ([UserId]),
    CONSTRAINT [FK_SEC_RoleDelegation_AspNetUsers_LF_Source_UserId] FOREIGN KEY ([LF_Source_UserId]) REFERENCES [dbo].[AspNetUsers] ([UserId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_SEC_RoleDelegation_RoleId]
    ON [dbo].[SEC_RoleDelegation]([RoleId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SEC_RoleDelegation_LF_Destenation_UserId]
    ON [dbo].[SEC_RoleDelegation]([LF_Destenation_UserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SEC_RoleDelegation_LF_Source_UserId]
    ON [dbo].[SEC_RoleDelegation]([LF_Source_UserId] ASC);

