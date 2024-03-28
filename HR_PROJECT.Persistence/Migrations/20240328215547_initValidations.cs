using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e50c294-ae31-4d7c-9607-22a05c3a8cac", "AQAAAAIAAYagAAAAEPUMRb7ANTBVpDoJ7vx7FsCSVd/swEl5VqJymkTJrjih6aOYhG97eopVBLlVnLuW/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2de6000b-7776-4844-815a-bf7020fc5dfa", "AQAAAAIAAYagAAAAENrLlbwTtSTWQU3WYh7SU1S+m/emYbUpgZIN1HgknjxgwWDkyy8XlWSVB+VtTzHmqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff05bc01-696c-4968-8e4f-cc707cceafad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0d75118-a7ce-4134-8ffd-e7fac9390ab6", "AQAAAAIAAYagAAAAEAK4f2cP+g5FvIdnaXHwhbMZ8FB8h1G0b6v+w6af0RdaxR6t/tADHKIzfwMfdmYRmQ==" });
        }
    }
}
