using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_PROJECT.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class passwordResetLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OneTimePassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "OneTimePassword", "PasswordHash" },
                values: new object[] { "73800ef0-033f-4ce1-8c72-9e376666d12b", null, "AQAAAAIAAYagAAAAEPp9TYRvwkMjRnssAOLmU9v9J7NLEMQWkFPDKMBx70nV7E6skNmbUukQpQQ5p1yRdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "OneTimePassword", "PasswordHash" },
                values: new object[] { "cc3e3541-ab74-4a61-9ff5-8bffb76a69c7", null, "AQAAAAIAAYagAAAAEPszAzrY84b79r5X+X9fAM51XhrLiSqSB1kw71bLr34HzkIB8WlebrH5EYLBcRamHQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OneTimePassword",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29eee336-e6a2-40f2-9305-159eed59ed75",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e309f3c9-4ac9-463d-b3db-e0d861042b74", "AQAAAAIAAYagAAAAEExuSbCOasp1ldbvXaBkUzlndNin9BJWv01MWPO60vpa8wkkZUjAc1y1DKKBdGdRtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cc28758-8ebd-4010-9cd3-c623f385b7e6", "AQAAAAIAAYagAAAAEADot/v46PgtBtLml4Rdg4PavYhrvJYvfdR7xnEQTkS86ccbK4YwI2JqBhQ3HiYSsQ==" });
        }
    }
}
