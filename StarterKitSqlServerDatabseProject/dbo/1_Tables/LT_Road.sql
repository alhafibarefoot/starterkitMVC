CREATE TABLE [dbo].[LT_Road] (
    [Road_Code]    NVARCHAR (12)  NOT NULL,
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [LF_Area_Code] NVARCHAR (12)  NOT NULL,
    [RoadNO]       INT            NOT NULL,
    [RoadNameEN]   NVARCHAR (80)  NOT NULL,
    [RoadNameAR]   NVARCHAR (80)  NULL,
    [CreatedBy]    NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]    DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]   NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]   DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]    NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]     BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_LT_Road] PRIMARY KEY CLUSTERED ([Road_Code] ASC),
    CONSTRAINT [FK_LT_Road_LT_Area_LF_Area_Code] FOREIGN KEY ([LF_Area_Code]) REFERENCES [dbo].[LT_Area] ([Area_Code]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_LT_Road_LF_Area_Code]
    ON [dbo].[LT_Road]([LF_Area_Code] ASC);

