using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initpASSWORDcHANGElOGİC2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c05084f4-d5d5-4e10-afd1-043b045d570e", "AQAAAAIAAYagAAAAEBzkiF9diq6OI7uxUBlzIILG3tCrS4h+eh1nGgw9Z+hWYQ56LW+nNjGGWUVANkEggQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "OneTimePassword", "PasswordHash" },
                values: new object[] { "03862bc2-43e9-459a-a681-225bfc48e581", "123456", "AQAAAAIAAYagAAAAEA+tCP8h3wKZdezIHglXMiJsBnjKlDL2Nwre5oBPOBwm602Rt5ysUXo7vFcyzeyjHg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73800ef0-033f-4ce1-8c72-9e376666d12b", "AQAAAAIAAYagAAAAEPp9TYRvwkMjRnssAOLmU9v9J7NLEMQWkFPDKMBx70nV7E6skNmbUukQpQQ5p1yRdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "OneTimePassword", "PasswordHash" },
                values: new object[] { "cc3e3541-ab74-4a61-9ff5-8bffb76a69c7", null, "AQAAAAIAAYagAAAAEPszAzrY84b79r5X+X9fAM51XhrLiSqSB1kw71bLr34HzkIB8WlebrH5EYLBcRamHQ==" });
        }
    }
}
