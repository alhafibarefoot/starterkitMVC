CREATE TABLE [dbo].[STR_Company] (
    [Company_Code]           NVARCHAR (12)   NOT NULL,
    [Id]                     INT             IDENTITY (1, 1) NOT NULL,
    [CompanyNameEn]          NVARCHAR (100)  NOT NULL,
    [CompanyNameAr]          NVARCHAR (100)  NOT NULL,
    [LF_DivisionType_Code]   NVARCHAR (12)   NOT NULL,
    [CompanyLogo]            VARBINARY (MAX) NULL,
    [WebSite]                NVARCHAR (75)   NULL,
    [Address]                NVARCHAR (200)  NULL,
    [Building]               NVARCHAR (50)   NULL,
    [Country_Code]           NVARCHAR (MAX)  NULL,
    [Governorate_Code]       NVARCHAR (MAX)  NULL,
    [Region_Code]            NVARCHAR (MAX)  NULL,
    [Area_Code]              NVARCHAR (MAX)  NULL,
    [Road_Code]              NVARCHAR (MAX)  NULL,
    [FullAddress]            NVARCHAR (200)  NULL,
    [POBox]                  NVARCHAR (75)   NULL,
    [ContactPerson]          NVARCHAR (100)  NULL,
    [ContactTelNo]           NVARCHAR (15)   NULL,
    [ContactMobileNo]        NVARCHAR (15)   NULL,
    [ContactFaxNo]           NVARCHAR (15)   NULL,
    [ContactEmail]           NVARCHAR (75)   NULL,
    [ReportHeader]           NVARCHAR (MAX)  NULL,
    [ReportFooter]           NVARCHAR (MAX)  NULL,
    [Vat_RegistrationNumber] NVARCHAR (50)   NULL,
    [IsCostCentre]           BIT             NULL,
    [IsWareHouse]            BIT             NULL,
    [IsOutLet]               BIT             NULL,
    [CreatedBy]              NVARCHAR (100)  DEFAULT ('EF Migration') NULL,
    [CreatedOn]              DATETIME2 (7)   DEFAULT (getutcdate()) NULL,
    [ModifiedBy]             NVARCHAR (100)  DEFAULT ('EF Migration') NULL,
    [ModifiedOn]             DATETIME2 (7)   DEFAULT (getutcdate()) NULL,
    [IPAddress]              NVARCHAR (15)   DEFAULT ('::1') NULL,
    [isActive]               BIT             DEFAULT ((1)) NULL,
    CONSTRAINT [PK_STR_Company] PRIMARY KEY CLUSTERED ([Company_Code] ASC),
    CONSTRAINT [FK_STR_Company_LT_DivisionType_LF_DivisionType_Code] FOREIGN KEY ([LF_DivisionType_Code]) REFERENCES [dbo].[LT_DivisionType] ([DivisionType_Code]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_STR_Company_LF_DivisionType_Code]
    ON [dbo].[STR_Company]([LF_DivisionType_Code] ASC);

