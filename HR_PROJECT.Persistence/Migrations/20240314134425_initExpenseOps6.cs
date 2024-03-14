using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initExpenseOps6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cade5859-f426-4870-875c-73667d0cabae", "AQAAAAIAAYagAAAAENrddw2yBVZ/Rjiw88SdQba+6dyAJeZMA8bQpU/rYAEpKQrgTmGXwZJsEYZOIqq5Kg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1556439-d85a-4db6-be81-b10727151887", "AQAAAAIAAYagAAAAEEovDJk3nUs37owT5rKiwGIRf6Dje7B5q1mY3tVBhFZ74GJOLrkSrkpxfhyaxys90A==" });
        }
    }
}
