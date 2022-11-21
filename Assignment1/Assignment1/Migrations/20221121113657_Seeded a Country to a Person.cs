using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class SeededaCountrytoaPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "3118b8c8-324c-4ac1-94cb-9f751ffda349");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "388c7db7-7337-44ad-bcbc-1480893d679b");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d2502772-6e13-4562-82a6-a7b18078f9ac");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "72e372ce-2dc9-47cd-984a-c3ade927f550", "Mölndal", "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "8eaba12c-753b-494d-91b4-0bcc8b9add15", "Falsterbo", "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "e80868c0-82d7-4781-9924-07583898220d", "Göteborg", "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "CountryPerson",
                columns: new[] { "CountrysId", "PeopleId" },
                values: new object[] { 1, "e80868c0-82d7-4781-9924-07583898220d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CountryPerson",
                keyColumns: new[] { "CountrysId", "PeopleId" },
                keyValues: new object[] { 1, "e80868c0-82d7-4781-9924-07583898220d" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "72e372ce-2dc9-47cd-984a-c3ade927f550");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8eaba12c-753b-494d-91b4-0bcc8b9add15");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "e80868c0-82d7-4781-9924-07583898220d");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "3118b8c8-324c-4ac1-94cb-9f751ffda349", "Mölndal", "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "388c7db7-7337-44ad-bcbc-1480893d679b", "Göteborg", "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "d2502772-6e13-4562-82a6-a7b18078f9ac", "Falsterbo", "The Dude", "0707985544" });
        }
    }
}
