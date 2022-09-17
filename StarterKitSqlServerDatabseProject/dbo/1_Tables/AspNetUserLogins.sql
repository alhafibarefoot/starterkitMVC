CREATE TABLE [dbo].[AspNetUserLogins] (
    [UserId]        NVARCHAR (128) NOT NULL,
    [LoginProvider] NVARCHAR (450) NOT NULL,
    [ProviderKey]   NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED ([LoginProvider] ASC, [ProviderKey] ASC, [UserId] ASC),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([UserId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId]
    ON [dbo].[AspNetUserLogins]([UserId] ASC);

