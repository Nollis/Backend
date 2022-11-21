using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class AddedmanytomanybetweenPersonandCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "37ecb845-312e-4c2a-bd07-0e86de444125");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "38618de8-7060-4e4f-8f62-c0b3ca7ee304");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "5cefa1a2-df78-4c17-8d20-41cff0d60e33");

            migrationBuilder.CreateTable(
                name: "CountryPerson",
                columns: table => new
                {
                    CountrysId = table.Column<int>(type: "int", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPerson", x => new { x.CountrysId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_CountryPerson_Countries_CountrysId",
                        column: x => x.CountrysId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryPerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CountryPerson_PeopleId",
                table: "CountryPerson",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryPerson");

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
                values: new object[] { "37ecb845-312e-4c2a-bd07-0e86de444125", "Mölndal", "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "38618de8-7060-4e4f-8f62-c0b3ca7ee304", "Falsterbo", "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "5cefa1a2-df78-4c17-8d20-41cff0d60e33", "Göteborg", "Niklas Bergh", "031-123456" });
        }
    }
}
