using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class tbl_LT_LookupTableReferance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LT_LookupTableReferance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                   
                    LookupCode = table.Column<string>(maxLength: 3, nullable: false),
                    LookupNameEn = table.Column<string>(maxLength: 50, nullable: false),
                    LookupNameAr = table.Column<string>(maxLength: 50, nullable: true),
                    LastSerialNo = table.Column<int>(nullable: true),
                    TemporarySerialNo = table.Column<int>(nullable: true),
                    PadLeftNo = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_LookupTableReferance", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LT_LookupTableReferance");
        }
    }
}
