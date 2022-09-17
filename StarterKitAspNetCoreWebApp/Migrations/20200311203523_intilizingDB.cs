using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterKitAspNetCoreWebApp.Migrations
{
    public partial class intilizingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    RoleId = table.Column<string>(maxLength: 128, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Discriminator = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    UserPhoto = table.Column<byte[]>(nullable: true),
                    IsEmployee = table.Column<bool>(nullable: false),
                    OrganizationEmail = table.Column<string>(maxLength: 128, nullable: true),
                    EmployeeCode = table.Column<string>(maxLength: 5, nullable: true),
                    Email = table.Column<string>(maxLength: 128, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 128, nullable: true),
                    SecurityStamp = table.Column<string>(maxLength: 128, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "LT_Country",
                columns: table => new
                {
                    Country_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryNameEn = table.Column<string>(maxLength: 50, nullable: false),
                    CountryNameAr = table.Column<string>(maxLength: 50, nullable: true),
                    Capital = table.Column<string>(maxLength: 50, nullable: true),
                    NationalityDescAr = table.Column<string>(maxLength: 50, nullable: true),
                    NationalityDescEn = table.Column<string>(maxLength: 50, nullable: true),
                    IsGCC = table.Column<bool>(nullable: false),
                    IACOCode = table.Column<int>(nullable: false),
                    Alpha2Code = table.Column<string>(maxLength: 5, nullable: true),
                    Alpha3Code = table.Column<string>(maxLength: 5, nullable: true),
                    Region = table.Column<string>(maxLength: 50, nullable: true),
                    SubRegion = table.Column<string>(maxLength: 50, nullable: true),
                    Region_Code = table.Column<string>(maxLength: 8, nullable: true),
                    SubRegion_Code = table.Column<string>(maxLength: 8, nullable: true),
                    DialCode = table.Column<string>(maxLength: 8, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_Country", x => x.Country_Code);
                });

            migrationBuilder.CreateTable(
                name: "LT_DivisionType",
                columns: table => new
                {
                    DivisionType_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionNameEn = table.Column<string>(maxLength: 50, nullable: false),
                    DivisionNameAr = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_DivisionType", x => x.DivisionType_Code);
                });

            migrationBuilder.CreateTable(
                name: "SMT_Action",
                columns: table => new
                {
                    Action_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionNameAr = table.Column<string>(maxLength: 100, nullable: false),
                    ActionNameEn = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMT_Action", x => x.Action_Code);
                });

            migrationBuilder.CreateTable(
                name: "SMT_Module",
                columns: table => new
                {
                    Module_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleNameAr = table.Column<string>(maxLength: 100, nullable: false),
                    ModuleNameEn = table.Column<string>(maxLength: 100, nullable: true),
                    Icon = table.Column<string>(maxLength: 100, nullable: true),
                    TextColor = table.Column<string>(maxLength: 7, nullable: true),
                    BackgroundColor = table.Column<string>(maxLength: 7, nullable: true),
                    RouteController = table.Column<string>(maxLength: 100, nullable: true),
                    RouteAction = table.Column<string>(maxLength: 100, nullable: true),
                    RouteArea = table.Column<string>(maxLength: 100, nullable: true),
                    ModuleActions = table.Column<string>(nullable: true),
                    OrderSequence = table.Column<int>(nullable: false),
                    ParentModuleCode = table.Column<string>(maxLength: 8, nullable: true),
                    IsMenu = table.Column<bool>(nullable: false),
                    SystemTableName = table.Column<string>(maxLength: 150, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMT_Module", x => x.Module_Code);
                });

            migrationBuilder.CreateTable(
                name: "SMT_System",
                columns: table => new
                {
                    System_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemNameAr = table.Column<string>(maxLength: 100, nullable: false),
                    SystemNameEn = table.Column<string>(maxLength: 100, nullable: true),
                    SystemAbbreviationAr = table.Column<string>(maxLength: 10, nullable: true),
                    SystemAbbreviationEn = table.Column<string>(maxLength: 10, nullable: true),
                    BackgroundImageUrl = table.Column<byte[]>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    BackgroundColor = table.Column<string>(maxLength: 7, nullable: true),
                    FontColor = table.Column<string>(maxLength: 7, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMT_System", x => x.System_Code);
                });

            migrationBuilder.CreateTable(
                name: "SEC_RolePermission",
                columns: table => new
                {
                    RolePermission_Code = table.Column<string>(nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false),
                    Action_Code = table.Column<string>(maxLength: 12, nullable: false),
                    Module_Code = table.Column<string>(maxLength: 12, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEC_RolePermission", x => x.RolePermission_Code);
                    table.ForeignKey(
                        name: "FK_SEC_RolePermission_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SEC_RoleDelegation",
                columns: table => new
                {
                    RoleDelegation_Code = table.Column<string>(nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LF_Source_UserId = table.Column<string>(maxLength: 128, nullable: false),
                    LF_Destenation_UserId = table.Column<string>(maxLength: 128, nullable: true),
                    RoleId = table.Column<string>(maxLength: 128, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEC_RoleDelegation", x => x.RoleDelegation_Code);
                    table.ForeignKey(
                        name: "FK_SEC_RoleDelegation_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SEC_RoleDelegation_AspNetUsers_LF_Destenation_UserId",
                        column: x => x.LF_Destenation_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SEC_RoleDelegation_AspNetUsers_LF_Source_UserId",
                        column: x => x.LF_Source_UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LT_Governorate",
                columns: table => new
                {
                    Governorate_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LF_Country_Code = table.Column<string>(maxLength: 12, nullable: false),
                    GovernorateEN = table.Column<string>(maxLength: 50, nullable: true),
                    GovernorateAR = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_Governorate", x => x.Governorate_Code);
                    table.ForeignKey(
                        name: "FK_LT_Governorate_LT_Country_LF_Country_Code",
                        column: x => x.LF_Country_Code,
                        principalTable: "LT_Country",
                        principalColumn: "Country_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "STR_Company",
                columns: table => new
                {
                    Company_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyNameEn = table.Column<string>(maxLength: 100, nullable: false),
                    CompanyNameAr = table.Column<string>(maxLength: 100, nullable: false),
                    LF_DivisionType_Code = table.Column<string>(maxLength: 12, nullable: false),
                    CompanyLogo = table.Column<byte[]>(nullable: true),
                    WebSite = table.Column<string>(maxLength: 75, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Building = table.Column<string>(maxLength: 50, nullable: true),
                    Country_Code = table.Column<string>(nullable: true),
                    Governorate_Code = table.Column<string>(nullable: true),
                    Region_Code = table.Column<string>(nullable: true),
                    Area_Code = table.Column<string>(nullable: true),
                    Road_Code = table.Column<string>(nullable: true),
                    FullAddress = table.Column<string>(maxLength: 200, nullable: true),
                    POBox = table.Column<string>(maxLength: 75, nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 100, nullable: true),
                    ContactTelNo = table.Column<string>(maxLength: 15, nullable: true),
                    ContactMobileNo = table.Column<string>(maxLength: 15, nullable: true),
                    ContactFaxNo = table.Column<string>(maxLength: 15, nullable: true),
                    ContactEmail = table.Column<string>(maxLength: 75, nullable: true),
                    ReportHeader = table.Column<string>(nullable: true),
                    ReportFooter = table.Column<string>(nullable: true),
                    Vat_RegistrationNumber = table.Column<string>(maxLength: 50, nullable: true),
                    IsCostCentre = table.Column<bool>(nullable: true),
                    IsWareHouse = table.Column<bool>(nullable: true),
                    IsOutLet = table.Column<bool>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STR_Company", x => x.Company_Code);
                    table.ForeignKey(
                        name: "FK_STR_Company_LT_DivisionType_LF_DivisionType_Code",
                        column: x => x.LF_DivisionType_Code,
                        principalTable: "LT_DivisionType",
                        principalColumn: "DivisionType_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LT_Region",
                columns: table => new
                {
                    Region_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LF_Governorate_Code = table.Column<string>(maxLength: 12, nullable: false),
                    RegionEN = table.Column<string>(maxLength: 50, nullable: true),
                    RegionAR = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_Region", x => x.Region_Code);
                    table.ForeignKey(
                        name: "FK_LT_Region_LT_Governorate_LF_Governorate_Code",
                        column: x => x.LF_Governorate_Code,
                        principalTable: "LT_Governorate",
                        principalColumn: "Governorate_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LT_Area",
                columns: table => new
                {
                    Area_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LF_Region_Code = table.Column<string>(maxLength: 12, nullable: false),
                    AreaNO = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_Area", x => x.Area_Code);
                    table.ForeignKey(
                        name: "FK_LT_Area_LT_Region_LF_Region_Code",
                        column: x => x.LF_Region_Code,
                        principalTable: "LT_Region",
                        principalColumn: "Region_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LT_Road",
                columns: table => new
                {
                    Road_Code = table.Column<string>(maxLength: 12, nullable: false),
                    
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LF_Area_Code = table.Column<string>(maxLength: 12, nullable: false),
                    RoadNO = table.Column<int>(nullable: false),
                    RoadNameEN = table.Column<string>(maxLength: 80, nullable: false),
                    RoadNameAR = table.Column<string>(maxLength: 80, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "'EF Migration'"),
                    ModifiedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getutcdate()"),
                    IPAddress = table.Column<string>(maxLength: 15, nullable: true, defaultValueSql: "'::1'"),
                    isActive = table.Column<bool>(nullable: true, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LT_Road", x => x.Road_Code);
                    table.ForeignKey(
                        name: "FK_LT_Road_LT_Area_LF_Area_Code",
                        column: x => x.LF_Area_Code,
                        principalTable: "LT_Area",
                        principalColumn: "Area_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_LT_Area_LF_Region_Code",
                table: "LT_Area",
                column: "LF_Region_Code");

            migrationBuilder.CreateIndex(
                name: "IX_LT_Governorate_LF_Country_Code",
                table: "LT_Governorate",
                column: "LF_Country_Code");

            migrationBuilder.CreateIndex(
                name: "IX_LT_Region_LF_Governorate_Code",
                table: "LT_Region",
                column: "LF_Governorate_Code");

            migrationBuilder.CreateIndex(
                name: "IX_LT_Road_LF_Area_Code",
                table: "LT_Road",
                column: "LF_Area_Code");

            migrationBuilder.CreateIndex(
                name: "IX_SEC_RoleDelegation_RoleId",
                table: "SEC_RoleDelegation",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SEC_RoleDelegation_LF_Destenation_UserId",
                table: "SEC_RoleDelegation",
                column: "LF_Destenation_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SEC_RoleDelegation_LF_Source_UserId",
                table: "SEC_RoleDelegation",
                column: "LF_Source_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SEC_RolePermission_RoleId",
                table: "SEC_RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_STR_Company_LF_DivisionType_Code",
                table: "STR_Company",
                column: "LF_DivisionType_Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "LT_Road");

            migrationBuilder.DropTable(
                name: "SEC_RoleDelegation");

            migrationBuilder.DropTable(
                name: "SEC_RolePermission");

            migrationBuilder.DropTable(
                name: "SMT_Action");

            migrationBuilder.DropTable(
                name: "SMT_Module");

            migrationBuilder.DropTable(
                name: "SMT_System");

            migrationBuilder.DropTable(
                name: "STR_Company");

            migrationBuilder.DropTable(
                name: "LT_Area");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "LT_DivisionType");

            migrationBuilder.DropTable(
                name: "LT_Region");

            migrationBuilder.DropTable(
                name: "LT_Governorate");

            migrationBuilder.DropTable(
                name: "LT_Country");
        }
    }
}
