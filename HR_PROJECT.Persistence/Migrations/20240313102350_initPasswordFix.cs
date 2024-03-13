using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initPasswordFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afe71676-be16-47cb-8f3f-68a71c3257ff", "AQAAAAIAAYagAAAAEAxahd9QX+Rpxt1e/sA4SHfkGzo6bh5NawcHM0H352p/aMnoI73KDQi5/fMhxwcK7A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16e14fd4-98e3-401e-9b27-88c1da78aa20", "AQAAAAIAAYagAAAAEBMcdC07ex33ERtxzzlSo+IpE+QZGTEJD5BTqTh1NyKUJBIUZvcJpuM3hMxCXWiypA==" });
        }
    }
}
