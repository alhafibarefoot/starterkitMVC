﻿CREATE TABLE [dbo].[SMT_Module] (
    [Module_Code]      NVARCHAR (12)  NOT NULL,
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [ModuleNameAr]     NVARCHAR (100) NOT NULL,
    [ModuleNameEn]     NVARCHAR (100) NULL,
    [Icon]             NVARCHAR (100) NULL,
    [TextColor]        NVARCHAR (7)   NULL,
    [BackgroundColor]  NVARCHAR (7)   NULL,
    [RouteController]  NVARCHAR (100) NULL,
    [RouteAction]      NVARCHAR (100) NULL,
    [RouteArea]        NVARCHAR (100) NULL,
    [ModuleActions]    NVARCHAR (MAX) NULL,
    [OrderSequence]    INT            NOT NULL,
    [ParentModuleCode] NVARCHAR (8)   NULL,
    [IsMenu]           BIT            NOT NULL,
    [SystemTableName]  NVARCHAR (150) NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [CreatedOn]        DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [ModifiedBy]       NVARCHAR (100) DEFAULT ('EF Migration') NULL,
    [ModifiedOn]       DATETIME2 (7)  DEFAULT (getutcdate()) NULL,
    [IPAddress]        NVARCHAR (15)  DEFAULT ('::1') NULL,
    [isActive]         BIT            DEFAULT ((1)) NULL,
    CONSTRAINT [PK_SMT_Module] PRIMARY KEY CLUSTERED ([Module_Code] ASC)
);

