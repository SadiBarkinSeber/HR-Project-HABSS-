using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initFixes4353465 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsCancelled",
                table: "Permissions",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Permissions",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCancelled",
                table: "Expenses",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Expenses",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCanceled",
                table: "Advances",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Advances",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea93c777-d026-45db-b744-1c411603cd1f", "AQAAAAIAAYagAAAAEBf96xmRhgnEQtEM5hr/KeaFVc2ZyoZB/lGPD+Wf0yxfCWgMLpC/o49DKQjCA8Wzeg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11cd8101-194e-4a46-adef-a29cd4b0dd3e", "AQAAAAIAAYagAAAAEIhCGQKpBErwUweGSKnn5sFVVNQ0y3iZ5fDceji2rYtwgTT+DRF3ram7S5efa88kHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff05bc01-696c-4968-8e4f-cc707cceafad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5bbe97a-3370-4a0e-975e-c1dfb4ab7d6f", "AQAAAAIAAYagAAAAECinb83URAJmeJ6ETrCMIvWvuGCDWkWGlyk3yLRcH15Ue06kVMIjbKo14VV/InO38w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsCancelled",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsCancelled",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsCanceled",
                table: "Advances",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "Advances",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af892d93-ac08-4c50-aa50-0e8ca7e39db0", "AQAAAAIAAYagAAAAEI8kvMg6pzfFLnW1rIGqOs1H5U4ZJP44YHYRdFxDbjXt4gbXg1i3Y57e3Xo00j95iw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1e7d4d2-c110-4a1d-9c0f-51a2e0e8603b", "AQAAAAIAAYagAAAAEAuyYEhnFGbvXtK0oHpJfdaC5XZEJxDO9XMoC5/KlORm/q1aAyh4Sr6zI+dz/Z5v1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff05bc01-696c-4968-8e4f-cc707cceafad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "460ee125-aee9-4717-80b6-d0a2d188d72b", "AQAAAAIAAYagAAAAEMpjtDhr7KxOgjCIqEfC0tG4OlpvWBhutZ63A731zpDqPWhOvIk1NYnhY/LFyeTkzg==" });
        }
    }
}
