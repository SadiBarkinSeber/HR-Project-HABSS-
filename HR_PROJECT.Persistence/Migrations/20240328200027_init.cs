using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    SiteManagerId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneTimePassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SiteManagers",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteManagers", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_SiteManagers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Advances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<bool>(type: "bit", nullable: false),
                    AdvanceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false),
                    ManagerEmployeeId = table.Column<int>(type: "int", nullable: true),
                    SiteManagerEmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advances_Managers_ManagerEmployeeId",
                        column: x => x.ManagerEmployeeId,
                        principalTable: "Managers",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Advances_SiteManagers_SiteManagerEmployeeId",
                        column: x => x.SiteManagerEmployeeId,
                        principalTable: "SiteManagers",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    ManagerEmployeeId = table.Column<int>(type: "int", nullable: true),
                    SiteManagerEmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_Managers_ManagerEmployeeId",
                        column: x => x.ManagerEmployeeId,
                        principalTable: "Managers",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Expenses_SiteManagers_SiteManagerEmployeeId",
                        column: x => x.SiteManagerEmployeeId,
                        principalTable: "SiteManagers",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsCancelled = table.Column<bool>(type: "bit", nullable: false),
                    ManagerEmployeeId = table.Column<int>(type: "int", nullable: true),
                    SiteManagerEmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_Managers_ManagerEmployeeId",
                        column: x => x.ManagerEmployeeId,
                        principalTable: "Managers",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Permissions_SiteManagers_SiteManagerEmployeeId",
                        column: x => x.SiteManagerEmployeeId,
                        principalTable: "SiteManagers",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "376a70f6-531c-40c5-ace7-ecf8964de6a4", null, "siteManager", "SITEMANAGER" },
                    { "f6040633-db1b-4a48-be54-9f214e77ac9d", null, "employee", "EMPLOYEE" },
                    { "f7deff55-ad53-4946-bce3-1208ff6c52e7", null, "manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EmployeeId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ManagerId", "NormalizedEmail", "NormalizedUserName", "OneTimePassword", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SiteManagerId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29eee336-e6a2-40f2-9305-159eed59ed75", 0, "47d2f674-2206-41ee-b146-7d07fad3a408", "admin@bilgeadamboost.com", false, null, null, null, false, null, 3, "ADMIN@BILGEADAM.COM", "ADMIN", null, "AQAAAAIAAYagAAAAECX/wtJxbjzqECd3DYI8JCWN3d1qtjJmeaahpBEbN56iz9Kz+k9/+qstlMfcBR27Jw==", null, false, "", null, false, "admin" },
                    { "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e", 0, "11d51019-b97e-472b-a32f-2de72fd72da4", "sahzod.irgas@bilgeadamboost.com", false, 1, null, null, false, null, null, "SAHZOD.IRGAS@BILGEADAM.COM", "SAHZOD", "123456", "AQAAAAIAAYagAAAAEGYxVkypHpHVe/a8yhSJYG9pkhUBtMk7CL/DPfRAWiNdBmScvAhidmQ68gBPN4q26Q==", null, false, "", null, false, "sahzod" },
                    { "ff05bc01-696c-4968-8e4f-cc707cceafad", 0, "b0f3eb0d-774c-4bbf-992b-3308756d43c1", "moderator@bilgeadamboost.com", false, null, null, null, false, null, null, "MODERATOR@BİLGEADAMBOOST.COM", "MODERATOR", null, "AQAAAAIAAYagAAAAENSnOdPOmnaTTz3xzX3PVEZADmWk3dclLtsDk7vQNL5rTf1r5JRoy7ZicdI1llZR4g==", null, false, "", 15, false, "moderator" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "BirthPlace", "Company", "DateOfBirth", "Department", "Email", "EndDate", "FirstName", "FirstSurname", "Gender", "ImagePath", "IsActive", "PhoneNumber", "Position", "SecondName", "SecondSurname", "StartDate", "Tc", "UserId", "Wage" },
                values: new object[] { 2, "Ayvansaray Mah. Şemsi Paşa Sokak Fatih/İstanbul", "London/Great Britain", "Koç Group", new DateTime(1996, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "jane.doe@bilgeadamboost.com", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Doe", "Female", "/Images/jane_doe.jpg", false, "+905085234563", "Lead Architect", "Margaret", "Thatcher", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "78952612374", null, 63951m });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f6040633-db1b-4a48-be54-9f214e77ac9d", "29eee336-e6a2-40f2-9305-159eed59ed75" },
                    { "f7deff55-ad53-4946-bce3-1208ff6c52e7", "29eee336-e6a2-40f2-9305-159eed59ed75" },
                    { "f6040633-db1b-4a48-be54-9f214e77ac9d", "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e" },
                    { "376a70f6-531c-40c5-ace7-ecf8964de6a4", "ff05bc01-696c-4968-8e4f-cc707cceafad" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "BirthPlace", "Company", "DateOfBirth", "Department", "Email", "EndDate", "FirstName", "FirstSurname", "Gender", "ImagePath", "IsActive", "PhoneNumber", "Position", "SecondName", "SecondSurname", "StartDate", "Tc", "UserId", "Wage" },
                values: new object[] { 1, "19 Mayıs Mah. Halit Paşa Cad. Şişli/İstanbul", "Antalya/Türkiye", "Amazon Inc.", new DateTime(1995, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technology and Strategy", "john.doe@bilgeadamboost.com", null, "John", "Doe", "Male", "/Images/john_doe.jpg", true, "+905417896325", "Director", null, null, new DateTime(2017, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "19586478952", "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e", 95489m });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "EmployeeId", "Address", "BirthPlace", "Company", "DateOfBirth", "Department", "Email", "EndDate", "FirstName", "FirstSurname", "Gender", "ImagePath", "IsActive", "PhoneNumber", "Position", "SecondName", "SecondSurname", "StartDate", "Tc", "UserId", "Wage" },
                values: new object[] { 3, "Yıldız Mah. Barbaros Bulvarı Beşiktaş/İstanbul", "Florence/Italy", "Amazon Inc.", new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technology and Strategy", "leonardo.davinci@bilgeadamboost.com", null, "Leonardo", "Da Vinci", "Male", "file.jpg", true, "+905075217896", "IT Manager", null, null, new DateTime(2015, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "54696378921", "29eee336-e6a2-40f2-9305-159eed59ed75", 156245m });

            migrationBuilder.InsertData(
                table: "SiteManagers",
                columns: new[] { "EmployeeId", "Address", "BirthPlace", "Company", "DateOfBirth", "Department", "Email", "EndDate", "FirstName", "FirstSurname", "Gender", "ImagePath", "IsActive", "PhoneNumber", "Position", "SecondName", "SecondSurname", "StartDate", "Tc", "UserId", "Wage" },
                values: new object[] { 15, "Atalar Mah. Minibüs Cad. 25/6 Kartal/İstanbul", "Pretoria/South Africa", "Amazon Inc.", new DateTime(1973, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Board of Directors", "elon.musk@bilgeadamboost.com", null, "Elon", "Musk", "Male", "file.jpg", true, "+905423215678", "CEO", null, null, new DateTime(2012, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "75489612354", "ff05bc01-696c-4968-8e4f-cc707cceafad", 256423m });

            migrationBuilder.InsertData(
                table: "Advances",
                columns: new[] { "Id", "AdvanceType", "Amount", "AmountValue", "ApprovalStatus", "Currency", "Description", "EmployeeId", "IsCanceled", "ManagerEmployeeId", "Permission", "RequestDate", "Response", "SiteManagerEmployeeId" },
                values: new object[,]
                {
                    { 1, "Bireysel", 5631.45m, null, "Pending", "TL", "Araba alıcam", 1, false, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Please provide necessary documents.", null },
                    { 2, "Kurumsal", 6592.45m, null, "Approved", "TL", "Motor alıcam", 1, false, null, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Request have been approved.", null }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "AmountValue", "ApprovalStatus", "Currency", "EmployeeId", "ExpenseType", "FileName", "IsCancelled", "ManagerEmployeeId", "Permission", "RequestDate", "Response", "SiteManagerEmployeeId" },
                values: new object[,]
                {
                    { 1, 5631.45m, null, "Pending", "TL", 1, "İş Seyahatleri", null, false, null, false, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Please provide necessary documents.", null },
                    { 2, 6592.45m, null, "Approved", "TL", 1, "Personel Harcamaları", null, false, null, true, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Request have been approved.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advances_EmployeeId",
                table: "Advances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Advances_ManagerEmployeeId",
                table: "Advances",
                column: "ManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Advances_SiteManagerEmployeeId",
                table: "Advances",
                column: "SiteManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ManagerEmployeeId",
                table: "Expenses",
                column: "ManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_SiteManagerEmployeeId",
                table: "Expenses",
                column: "SiteManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeId",
                table: "Permissions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ManagerEmployeeId",
                table: "Permissions",
                column: "ManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_SiteManagerEmployeeId",
                table: "Permissions",
                column: "SiteManagerEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteManagers_UserId",
                table: "SiteManagers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advances");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "SiteManagers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
