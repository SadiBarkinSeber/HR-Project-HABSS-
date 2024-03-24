using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initAppuserFixes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f6040633-db1b-4a48-be54-9f214e77ac9d", null, "employee", "EMPLOYEE" },
                    { "f7deff55-ad53-4946-bce3-1208ff6c52e7", null, "manager", "MANAGER" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f6040633-db1b-4a48-be54-9f214e77ac9d", "29eee336-e6a2-40f2-9305-159eed59ed75" },
                    { "f7deff55-ad53-4946-bce3-1208ff6c52e7", "29eee336-e6a2-40f2-9305-159eed59ed75" },
                    { "f6040633-db1b-4a48-be54-9f214e77ac9d", "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6040633-db1b-4a48-be54-9f214e77ac9d", "29eee336-e6a2-40f2-9305-159eed59ed75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7deff55-ad53-4946-bce3-1208ff6c52e7", "29eee336-e6a2-40f2-9305-159eed59ed75" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6040633-db1b-4a48-be54-9f214e77ac9d", "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6040633-db1b-4a48-be54-9f214e77ac9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7deff55-ad53-4946-bce3-1208ff6c52e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d2cd2e1-116d-4c29-abd7-8d0a25a2c9c5", "AQAAAAIAAYagAAAAEOtAVzY2DX0LONp2v6GpLtMg1RkEhGquwjArSrLuFDc0IPJNXXCtDS8kHW5U6VarTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89a82d47-4cfa-47d8-be64-7c36dd585b3b", "AQAAAAIAAYagAAAAECT01OqsHm/uA+DsgS5cEN7r9ToV3wU8xMYJ1OgNDy/tfamtf20RTdiukytGaJfifg==" });
        }
    }
}
