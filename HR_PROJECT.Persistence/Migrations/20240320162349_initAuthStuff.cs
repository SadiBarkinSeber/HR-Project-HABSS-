using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initAuthStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bddc2d1-e6db-4083-9e1f-11f4c15fea82", "AQAAAAIAAYagAAAAEAkNGx7BQ45vFaO/ewqCvVsxbemSvhhnn5sYGU8V4qK6WyKgrL1w1JU6SS5asXIy2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cbd3132-fe7c-46ec-87e9-9d645e174ff8", "AQAAAAIAAYagAAAAEDeix3A6tu50JL2DwmI0nT8HV6kHfmTSLkn1yU8W/odA9WLSv0Tu9dbbN/HZlkRzOg==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 20, 19, 23, 49, 15, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 20, 19, 23, 49, 15, DateTimeKind.Local).AddTicks(3388));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74ce04e7-684c-4d0f-84c9-7161b8ae5933", "AQAAAAIAAYagAAAAEBRiX3jdQskehDysKZd0V3OUeMSjmJGU5otLQqq1VR9QyIw3N7Emqlk7gw5AupXsxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fad0de63-5b32-46e1-a81b-5db4d905a161", "AQAAAAIAAYagAAAAEEtFkZZUY6iSf8zdgKugioZaHzWUWe2aTXvYzyKXJQSomyTJpvg1eYhZt6DITwFBbQ==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 23, 42, 13, 914, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 3, 19, 23, 42, 13, 914, DateTimeKind.Local).AddTicks(2870));
        }
    }
}
