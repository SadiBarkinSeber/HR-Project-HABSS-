using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initFixes1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Permission",
                table: "Expenses",
                newName: "IsApproved");

            migrationBuilder.RenameColumn(
                name: "Permission",
                table: "Advances",
                newName: "IsApproved");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Expenses",
                newName: "Permission");

            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Advances",
                newName: "Permission");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de320541-8baf-4208-b2cc-610a8b509c19", "AQAAAAIAAYagAAAAEDTbDL+oTF0IXoGyH9ME4GIfsRJjrffaD5SMliIipy2mqwcwDeivlT8gAKHWe1JcMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25589b4c-8631-435f-8a7a-1eebff31ee50", "AQAAAAIAAYagAAAAEDK0wfgKRjNU47s7OisNcnlvgh1B3MHoZv+q16Q2acVtmJ7QO5c2Spd2NZrjkxJcMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff05bc01-696c-4968-8e4f-cc707cceafad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72e0ff99-e186-42df-a767-f55240191bc6", "AQAAAAIAAYagAAAAENaUhp78zy+VemBHAciGC52XO43zlrqydbSrWtg6XXPmWzJfoVRNym7Q5GCUrRGQew==" });
        }
    }
}
