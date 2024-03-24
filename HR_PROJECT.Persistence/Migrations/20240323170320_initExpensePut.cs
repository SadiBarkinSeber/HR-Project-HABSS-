using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initExpensePut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsCancelled",
                value: false);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsCancelled",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8090ffdb-c32d-45d8-b581-d5ae8105fa9a", "AQAAAAIAAYagAAAAENpVcisZX/nYrmI7Cf0i7yZtzcYuxf6PcppBYZsdiKfKJ0e2AgdO+d5qHEMZJY92Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9cdeda70-ded2-4ed8-b47b-01bab3e57b37", "AQAAAAIAAYagAAAAEMQwLDNxmKbq9wLS5ACzVWJ+9EUKUCO3kRd6OTNlounq2ZwuqFd4hG6ZusseGrli+A==" });
        }
    }
}
