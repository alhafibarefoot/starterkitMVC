CREATE TABLE [dbo].[LT_Area] (
    [Area_Code]      NVARCHAR (12)  NOT NULL,
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [LF_Region_Code] NVARCHAR (12)  NOT NULL,
    [AreaNO]         INT            NOT NULL,
    [CreatedBy]      NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]      DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]     NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]     DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]      NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]       BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_LT_Area] PRIMARY KEY CLUSTERED ([Area_Code] ASC),
    CONSTRAINT [FK_LT_Area_LT_Region_LF_Region_Code] FOREIGN KEY ([LF_Region_Code]) REFERENCES [dbo].[LT_Region] ([Region_Code]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_LT_Area_LF_Region_Code]
    ON [dbo].[LT_Area]([LF_Region_Code] ASC);

