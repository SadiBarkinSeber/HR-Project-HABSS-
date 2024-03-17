using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initFixes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff75d0b1-1a47-40ed-b71e-0011c7dfde88", "AQAAAAIAAYagAAAAEMxBm/n5Iddf7j/PM7CZPiXRdNaO4Ybf1bbQv8/wOnQVtKwnBrX7eVw62mghyDQvHQ==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsApproved", "RequestDate" },
                values: new object[] { false, new DateTime(2024, 3, 17, 21, 18, 23, 198, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsApproved", "RequestDate" },
                values: new object[] { false, new DateTime(2024, 3, 17, 21, 18, 23, 198, DateTimeKind.Local).AddTicks(8958) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Permissions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54267b75-707a-4772-b5fd-b34db7911955", "AQAAAAIAAYagAAAAEDho+x/8Nt+7pJ2Fy2zWIADGwvOn8loBE31ZdkjQVxhjKQxRlTH3dccxt9WphBNhHw==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 17, 0, 26, 31, 512, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 17, 0, 26, 31, 512, DateTimeKind.Local).AddTicks(75));
        }
    }
}
