using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initExpenseOps4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca3d56eb-56e3-4d26-b011-18b75ce88bfc", "AQAAAAIAAYagAAAAEGmMMQrCrd3fgxVxs+L/mZMvh3wsIBBjsMzuxgLgYet4wSDOxN1HRroF39Ilk9YMbg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5a4e14f-5e24-4e1e-9c37-e0d0cbceead8", "AQAAAAIAAYagAAAAEGVLeYj4B+yjJKlaTU7Bgt6rM6aGPquMi9RcLL49e3BsM7Vme/mU3i/auIPqSRav2Q==" });
        }
    }
}
