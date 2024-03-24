using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "275056ac-714b-4597-83bf-aecfd7044a70", "AQAAAAIAAYagAAAAEGzi2/9XB++4GvmslYJ/56q35CMdzaYq0lEzKpbw+eBvnw4plpyVA1XCLIDJerBSFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c93afad-3c13-45aa-b3e8-d0d93007e834", "AQAAAAIAAYagAAAAEJWIk5FNu/3e9fPRPPSDYe3bN8pYQR9cKGEFJ70a1PVGxYhOXRHOcZkDFksmxVINbg==" });
        }
    }
}
