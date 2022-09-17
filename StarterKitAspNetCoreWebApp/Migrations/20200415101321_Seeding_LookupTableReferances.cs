using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class Seeding_LookupTableReferances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

DELETE FROM [dbo].[LT_LookupTableReferance]
GO
SET IDENTITY_INSERT dbo.LT_LookupTableReferance ON
GO
INSERT dbo.LT_LookupTableReferance(Id, LookupCode, LookupNameEn, LookupNameAr, LastSerialNo, TemporarySerialNo, CreatedBy, CreatedOn, IPAddress, ModifiedBy, ModifiedOn, isActive, PadLeftNo) VALUES (1, N'CTR', N'Country', 'البلدان', 249, 0, N'EF Migration', '2020-04-04 17:07:31.8866667', N'::1', N'EF Migration', '2020-04-04 17:07:31.8866667', CONVERT(bit, 'True'), 4)
INSERT dbo.LT_LookupTableReferance(Id, LookupCode, LookupNameEn, LookupNameAr, LastSerialNo, TemporarySerialNo, CreatedBy, CreatedOn, IPAddress, ModifiedBy, ModifiedOn, isActive, PadLeftNo) VALUES (2, N'GOV', N'Governorate', 'المحافظات', 4, 0, N'EF Migration', '2020-04-04 17:08:22.1133333', N'::1', N'EF Migration', '2020-04-04 17:08:22.1133333', CONVERT(bit, 'True'), 4)
INSERT dbo.LT_LookupTableReferance(Id, LookupCode, LookupNameEn, LookupNameAr, LastSerialNo, TemporarySerialNo, CreatedBy, CreatedOn, IPAddress, ModifiedBy, ModifiedOn, isActive, PadLeftNo) VALUES (3, N'REG', N'Region', 'المدن', 175, 0, N'EF Migration', '2020-04-04 17:10:09.8766667', N'::1', N'EF Migration', '2020-04-04 17:10:09.8766667', CONVERT(bit, 'True'), 4)
INSERT dbo.LT_LookupTableReferance(Id, LookupCode, LookupNameEn, LookupNameAr, LastSerialNo, TemporarySerialNo, CreatedBy, CreatedOn, IPAddress, ModifiedBy, ModifiedOn, isActive, PadLeftNo) VALUES (4, N'ARE', N'Area', 'المناطق', 460, 0, N'EF Migration', '2020-04-04 17:11:14.9166667', N'::1', N'EF Migration', '2020-04-04 17:11:14.9166667', CONVERT(bit, 'True'), 4)
INSERT dbo.LT_LookupTableReferance(Id, LookupCode, LookupNameEn, LookupNameAr, LastSerialNo, TemporarySerialNo, CreatedBy, CreatedOn, IPAddress, ModifiedBy, ModifiedOn, isActive, PadLeftNo) VALUES (5, N'ROD', N'Road', 'الشوارع', 9714, 0, N'EF Migration', '2020-04-04 17:12:27.8400000', N'::1', N'EF Migration', '2020-04-04 17:12:27.8400000', CONVERT(bit, 'True'), 4)
INSERT dbo.LT_LookupTableReferance(Id, LookupCode, LookupNameEn, LookupNameAr, LastSerialNo, TemporarySerialNo, CreatedBy, CreatedOn, IPAddress, ModifiedBy, ModifiedOn, isActive, PadLeftNo) VALUES (6, N'DIV', N'DivisionType', 'أنواع المؤسسات', 15, 0, N'EF Migration', '2020-04-04 17:13:02.3900000', N'::1', N'EF Migration', '2020-04-04 17:13:02.3900000', CONVERT(bit, 'True'), 4)
GO
SET IDENTITY_INSERT dbo.LT_LookupTableReferance OFF
GO

             ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
