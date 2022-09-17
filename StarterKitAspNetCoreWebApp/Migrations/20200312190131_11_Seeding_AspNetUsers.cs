using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class _11_Seeding_AspNetUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                Delete from [dbo].[AspNetUsers]
                GO
                SET IDENTITY_INSERT dbo.AspNetUsers ON
                GO

                INSERT dbo.AspNetUsers(UserId,Id, FirstName, LastName, UserPhoto, IsEmployee, OrganizationEmail, EmployeeCode, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName,isActive) VALUES (N'ad28d899-73af-4685-a47d-3c2b0a8c367f',1, N'Guest', N'Guest', NULL, CONVERT(bit, 'False'), NULL, NULL, N'guest@rco.gov.bh', CONVERT(bit, 'True'), N'AOGv3iA3Z7sjBvr3zjcm8FMA/6z6Thy1ccsFgnauI2tY72Oeq3AUlssETyjJSheyRg==', N'466fcfa5-c420-47ed-8ff4-ea43b8ffb956', NULL, CONVERT(bit, 'False'), CONVERT(bit, 'False'), NULL, CONVERT(bit, 'False'), 0, N'guest',CONVERT(bit, 'true'))
                INSERT dbo.AspNetUsers(UserId,Id,FirstName, LastName, UserPhoto, IsEmployee, OrganizationEmail, EmployeeCode, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName,isActive) VALUES (N'dc18d0e5-3cf3-46f9-9258-68aa41c7afa7',2, N'Administrator', N'Administrator', NULL, CONVERT(bit, 'False'), NULL, NULL, N'alhafi@hotmail.com', CONVERT(bit, 'True'), N'AIZtH55p0vogES4U2tprqO+vGOvKKML6p7etPwTOytjSe/lb/s8b1J6GeNEhGAO3WQ==', N'3bdd6c93-4597-4b42-b224-5bff00ac1667', NULL, CONVERT(bit, 'False'), CONVERT(bit, 'False'), NULL, CONVERT(bit, 'False'), 0, N'admin',CONVERT(bit, 'true'))
                GO
                SET IDENTITY_INSERT dbo.AspNetUsers OFF
                GO
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
