using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country" },
                values: new object[] { 1, "London", "England" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country" },
                values: new object[] { 2, "Amsterdam", "Netherlands" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country" },
                values: new object[] { 3, "Berlin", "Germany" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);
        }
    }
}
