using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class _7_Seeding_Division : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"


Delete from [dbo].[LT_DivisionType]
GO



SET IDENTITY_INSERT dbo.LT_DivisionType ON
GO
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0001', 1, N'Orginizationn', N'مؤسسة')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-00010', 10, N'Show Room', N'صالة عرض')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-00011', 11, N'Dressing Room', N'غرفة قياس')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-00012', 12, N'Car Parking', N'موقف سيارات')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-00013', 13, N'Archiving', N'الأرشيف')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-00014', 14, N'Mosquee', N'المسجد')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-00015', 15, N'Server Room', N'غرفة الخوادم')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0002', 2, N'Company', N'شركة')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0003', 3, N'Branch', N'فرع')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0004', 4, N'WareHouse', N'مستودع')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0005', 5, N'Store', N'مخزن')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0006', 6, N'Directorate', N'إدارة')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0007', 7, N'Section', N'قسم')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0008', 8, N'Officee', N'مكتب')
INSERT dbo.LT_DivisionType(DivisionType_Code, Id, DivisionNameEn, DivisionNameAr) VALUES (N'DIV-0009', 9, N'UNIT-Group', N'وحدة-مجموعة')
GO
SET IDENTITY_INSERT dbo.LT_DivisionType OFF
GO


             ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
