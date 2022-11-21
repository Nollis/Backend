using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Testingnewconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryPerson");

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

            migrationBuilder.DropColumn(
                name: "City",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CityPerson",
                columns: table => new
                {
                    CitiesId = table.Column<int>(type: "int", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityPerson", x => new { x.CitiesId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_CityPerson_Cities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityPerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { "078a0c8c-109e-40c5-aee9-1e145bd02e9a", "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { "19714931-c947-4d37-a434-d9e796b8b898", "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { "c8a6b631-dbca-4f21-adfd-f15ee95c26e5", "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "CityPerson",
                columns: new[] { "CitiesId", "PeopleId" },
                values: new object[] { 1, "c8a6b631-dbca-4f21-adfd-f15ee95c26e5" });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CityPerson_PeopleId",
                table: "CityPerson",
                column: "PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "CityPerson");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "078a0c8c-109e-40c5-aee9-1e145bd02e9a");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "19714931-c947-4d37-a434-d9e796b8b898");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "c8a6b631-dbca-4f21-adfd-f15ee95c26e5");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cities");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_CountryPerson_PeopleId",
                table: "CountryPerson",
                column: "PeopleId");
        }
    }
}
