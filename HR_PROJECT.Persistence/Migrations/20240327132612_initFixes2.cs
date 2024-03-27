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
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e309f3c9-4ac9-463d-b3db-e0d861042b74", "AQAAAAIAAYagAAAAEExuSbCOasp1ldbvXaBkUzlndNin9BJWv01MWPO60vpa8wkkZUjAc1y1DKKBdGdRtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cc28758-8ebd-4010-9cd3-c623f385b7e6", "AQAAAAIAAYagAAAAEADot/v46PgtBtLml4Rdg4PavYhrvJYvfdR7xnEQTkS86ccbK4YwI2JqBhQ3HiYSsQ==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Gender",
                value: "Male");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "39bb74b8-5c62-48d6-b58a-442f7d9df6ea", "AQAAAAIAAYagAAAAEFWzp8fKTgvCz0az3BplyZFHWPsATPoboZWntEQJG71TME7lvQDuGam2eH66HrhtwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8274e02-7009-467f-990d-ae25d3ba4d7f", "AQAAAAIAAYagAAAAEEcZdAWeY+WfLe+8abWT0idpjK2h1nttEKh3O7qEF2t4pzkhCDaMBHsSxNCL70pJmQ==" });
        }
    }
}
