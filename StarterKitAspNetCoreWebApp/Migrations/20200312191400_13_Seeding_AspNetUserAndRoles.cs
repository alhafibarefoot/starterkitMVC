using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class _13_Seeding_AspNetUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

DELETE FROM [dbo].[AspNetUserRoles]
GO

INSERT dbo.AspNetUserRoles(UserId, RoleId,isActive) VALUES (N'dc18d0e5-3cf3-46f9-9258-68aa41c7afa7', N'399e85d1-0fc5-45d3-8259-9145b0f77f29',CONVERT(bit, 'true'))
INSERT dbo.AspNetUserRoles(UserId, RoleId,isActive) VALUES (N'ad28d899-73af-4685-a47d-3c2b0a8c367f', N'ff1ec1e0-d552-4bee-bc5c-6c0bf307bca6',CONVERT(bit, 'true'))
GO


             ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
