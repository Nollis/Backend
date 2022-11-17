using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class AddedCountryandseededacountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Sweden" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[,]
                {
                    { "9ffe1dda-8b59-451e-a90f-d8a294a5eb95", "Mölndal", "Greger Puff", "031-666666" },
                    { "a20027c1-32b7-4d7b-9a5f-5ebbf1f58780", "Falsterbo", "The Dude", "0707985544" },
                    { "df43e1ff-4cf3-4e35-a53f-5ab1ff517ee1", "Göteborg", "Niklas Bergh", "031-123456" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "9ffe1dda-8b59-451e-a90f-d8a294a5eb95");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "a20027c1-32b7-4d7b-9a5f-5ebbf1f58780");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "df43e1ff-4cf3-4e35-a53f-5ab1ff517ee1");

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
    }
}
