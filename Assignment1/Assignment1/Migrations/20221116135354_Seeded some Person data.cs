using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class SeededsomePersondata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "3db47d52-6c64-4860-9cc9-73da71065c65", "Falsterbo", "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "63e15721-f100-42b8-bc54-ecc9024227ff", "Mölndal", "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "dc5d7afc-f725-43e3-8263-0ae58fe05f3a", "Göteborg", "Niklas Bergh", "031-123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "3db47d52-6c64-4860-9cc9-73da71065c65");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "63e15721-f100-42b8-bc54-ecc9024227ff");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "dc5d7afc-f725-43e3-8263-0ae58fe05f3a");
        }
    }
}
