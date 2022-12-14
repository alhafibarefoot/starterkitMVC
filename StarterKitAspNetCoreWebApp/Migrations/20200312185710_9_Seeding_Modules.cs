using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class _9_Seeding_Modules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

Delete from [dbo].[SMT_Module]
GO

SET IDENTITY_INSERT dbo.SMT_Module ON
GO
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0001', 1, N'الادارة', N'Administration', N'build', N'#ffffff', N'#000000', N'Administration', N'Index', N'Administration', N'ACT-0001', 1000, NULL, CONVERT(bit, 'True'), NULL)
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0002', 2, N'صيانة النظام', N'System Maintenance', N'settings', N'#ffffff', N'#000000', N'SystemMaintenance', N'Index', N'Administration', N'ACT-0001', 2100, N'MOD-0001', CONVERT(bit, 'True'), NULL)
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0003', 3, N'السرية والأمان', N'Security', N'security', N'#ffffff', N'#000000', N'Security', N'Index', N'Administration', N'ACT-0001', 2200, N'MOD-0001', CONVERT(bit, 'True'), NULL)
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0004', 4, N'مكونات النظام', N'Structure', N'people', N'#ffffff', N'#000000', N'Structure', N'Index', N'Administration', N'ACT-0001', 2300, NULL, CONVERT(bit, 'True'), NULL)
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0005', 5, N'الجداول المساعدة', N'Lookup Tables', N'list', N'#ffffff', N'#000000', N'LookupTable', N'Index', N'Lookup', N'ACT-0001', 2400, NULL, CONVERT(bit, 'True'), NULL)
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0006', 6, N'النظام', N'System', N'wb_cloudy', N'#ffffff', N'#000000', N'System', N'Index', N'Administration', N'ACT-0001,ACT-0003', 2101, N'MOD-0002', CONVERT(bit, 'True'), N'SMT_System')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0007', 7, N'وظيفة النظام', N'Action', N'touch_app', N'#ffffff', N'#000000', N'Action', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004', 2102, N'MOD-0002', CONVERT(bit, 'True'), N'SMT_Action')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0008', 8, N'مكونات النظام', N'Module', N'widgets', N'#ffffff', N'#000000', N'Module', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004', 2103, N'MOD-0002', CONVERT(bit, 'True'), N'SMT_Module')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0009', 9, N'المستخدمين', N'Users', N'person_outline', N'#ffffff', N'#000000', N'Users', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004,ACT-0017,ACT-0018,ACT-0019', 2201, N'MOD-0003', CONVERT(bit, 'True'), N'AspNetUsers')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0010', 10, N'أدوار المستخدمين', N'Roles', N'person_outline', N'#ffffff', N'#000000', N'Roles', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004', 2204, N'MOD-0003', CONVERT(bit, 'True'), N'AspNetRoles')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0011', 11, N'أذونات دور المستخدم', N'Role Permissions', N'people_outline', N'#ffffff', N'#000000', N'RolePermissions', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004', 2202, N'MOD-0003', CONVERT(bit, 'True'), N'SEC_RolePermission')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0012', 12, N'تفويض بأدوار النظام', N'Role Delegation', N'group_add', N'#ffffff', N'#000000', N'RoleDelegation', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004', 2203, N'MOD-0003', CONVERT(bit, 'True'), N'SEC_RoleDelegation')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0013', 13, N'شركة', N'Company', N'domain', N'#ffffff', N'#000000', N'Company', N'Index', N'Administration', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004', 2301, N'MOD-0004', CONVERT(bit, 'True'), N'STR_Company')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0014', 14, N'البلدان', N'Country', N'my_location', N'#000000', N'#000000', N'Country', N'Index', N'Lookup', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004,ACT-0010,ACT-0011,ACT-0012', 2401, N'MOD-0005', CONVERT(bit, 'True'), N'LT_Country')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0015', 15, N'المحافظات', N'Governorate', N'my_location', N'#000000', N'#000000', N'Governorate', N'Index', N'Lookup', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004,ACT-0010,ACT-0011,ACT-0012', 2402, N'MOD-0005', CONVERT(bit, 'True'), N'LT_Governorate')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0016', 16, N'شاشة العرض', N'Dashboard', N'dashboard', N'#ffffff', N'#000000', N'Home', N'Index', N'', N'ACT-0001', 1, NULL, CONVERT(bit, 'True'), NULL)
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0017', 17, N'الأقليم', N'Region', N'my_location', N'#000000', N'#000000', N'Region', N'Index', N'Lookup', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004,ACT-0010,ACT-0011,ACT-0012', 2403, N'MOD-0005', CONVERT(bit, 'True'), N'LT_Region')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0018', 18, N'المنطقة', N'Area', N'my_location', N'#000000', N'#000000', N'Area', N'Index', N'Lookup', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004,ACT-0010,ACT-0011,ACT-0012', 2404, N'MOD-0005', CONVERT(bit, 'True'), N'LT_Area')
INSERT dbo.SMT_Module(Module_Code, Id, ModuleNameAr, ModuleNameEn, Icon, TextColor, BackgroundColor, RouteController, RouteAction, RouteArea, ModuleActions, OrderSequence, ParentModuleCode, IsMenu, SystemTableName) VALUES (N'MOD-0019', 19, N'الشارع', N'Road', N'my_location', N'#000000', N'#000000', N'Road', N'Index', N'Lookup', N'ACT-0001,ACT-0002,ACT-0003,ACT-0004,ACT-0010,ACT-0011,ACT-0012', 2405, N'MOD-0005', CONVERT(bit, 'True'), N'LT_Road')
GO
SET IDENTITY_INSERT dbo.SMT_Module OFF
GO


             ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
