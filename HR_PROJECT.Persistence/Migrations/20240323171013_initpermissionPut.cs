using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initpermissionPut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "497ccaaa-149d-4965-8e85-d8334aeefb46", "AQAAAAIAAYagAAAAECc8fNuJyG7lQaUO3UDNBT7Fh3k0PN+yBSmPoeH8PhVc17y2jZPRJsd7wN+ffbEWLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d12340ae-4860-494b-a1ac-71f0bda73193", "AQAAAAIAAYagAAAAECrovKEJlAiLXU/0Yv+667yzjx2mGIYCmJegAYg/HBGRGQRG8NZVK/SCBp02Y2ifww==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Permissions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1662e167-2180-41ba-b477-3bedb66bceca", "AQAAAAIAAYagAAAAEB4wU68eOpEQYNCnEcxxGzKOajm/CVGxp8NNOFFBfi21/CqjURJ1G14qvV7NRGsTtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4ca2f84-06de-49e9-aebc-1dcfb1dd0295", "AQAAAAIAAYagAAAAEDdVTw6VI3UwPeGPkvkxes4nZDhI5W2pAmulDjCdu7xscmVqCjJ8aOCLxDpUhDg5KQ==" });
        }
    }
}
