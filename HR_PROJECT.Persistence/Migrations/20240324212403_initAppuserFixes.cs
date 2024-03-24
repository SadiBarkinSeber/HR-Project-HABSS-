using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initAppuserFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+905417896325");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "+905085234563");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "PhoneNumber",
                value: "+905075217896");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0db39160-8d70-4296-a7c8-26cc7ff5291e", "AQAAAAIAAYagAAAAEMj4ZEyX8K3lLmgkWIVhh7a00bCW+DzOped9Fb+ZzA7Mq1fC9rQkE6BhfHGlGBuHOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4abe79d-b4f3-404b-ae29-59c78398ea2b", "AQAAAAIAAYagAAAAELwKJA34Kj3gdcZaiO7enMACXanUOb+xtp96wBOdze802JGKir0VuJPdCTALdLTrHg==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "5417896325");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "5085234563");

            migrationBuilder.UpdateData(
                table: "Managers",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "PhoneNumber",
                value: "5075217896");
        }
    }
}
