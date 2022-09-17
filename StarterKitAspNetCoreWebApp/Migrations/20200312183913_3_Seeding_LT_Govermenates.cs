using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class _3_Seeding_LT_Govermenates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

Delete from [dbo].[LT_Governorate]
GO

SET IDENTITY_INSERT dbo.LT_Governorate ON
GO
INSERT dbo.LT_Governorate(Governorate_Code, Id, GovernorateEN, GovernorateAR, LF_Country_Code) VALUES (N'GOV-0001', 1, N'MUHARRAQ', N'المحرق', N'CTR-0001')
INSERT dbo.LT_Governorate(Governorate_Code, Id, GovernorateEN, GovernorateAR, LF_Country_Code) VALUES (N'GOV-0002', 2, N'CAPITAL', N'العاصمة', N'CTR-0001')
INSERT dbo.LT_Governorate(Governorate_Code, Id, GovernorateEN, GovernorateAR, LF_Country_Code) VALUES (N'GOV-0003', 3, N'NORTHERN', N'الشمالية', N'CTR-0001')
INSERT dbo.LT_Governorate(Governorate_Code, Id, GovernorateEN, GovernorateAR, LF_Country_Code) VALUES (N'GOV-0004', 4, N'SOUTHERN', N'الجنوبية', N'CTR-0001')
GO
SET IDENTITY_INSERT dbo.LT_Governorate OFF
GO


             ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
