CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId]     NVARCHAR (128) NOT NULL,
    [RoleId]     NVARCHAR (128) NOT NULL,
    [CreatedBy]  NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]  DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy] NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn] DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]  NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]   BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([RoleId]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([UserId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId]
    ON [dbo].[AspNetUserRoles]([RoleId] ASC);

