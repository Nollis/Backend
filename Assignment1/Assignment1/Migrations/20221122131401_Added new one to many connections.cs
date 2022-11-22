using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Addednewonetomanyconnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "CityPerson");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countries",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cities",
                newName: "CityName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "CityId");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CountryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "CountryId" },
                values: new object[] { 2, "Stockholm", 1 });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "8df43ec8-f2da-4667-b58d-a9220e194278", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "8bf29d56-8281-4c51-bc17-e45496169f13", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "ba2ee2c3-b418-46a0-8f15-cf1bbdece9d1", 2, "Greger Puff", "031-666666" });

            migrationBuilder.CreateIndex(
                name: "IX_People_CityId",
                table: "People",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_CityId",
                table: "People");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "8bf29d56-8281-4c51-bc17-e45496169f13");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "8df43ec8-f2da-4667-b58d-a9220e194278");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "ba2ee2c3-b418-46a0-8f15-cf1bbdece9d1");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "People",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Countries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryId",
                value: null);

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[,]
                {
                    { "078a0c8c-109e-40c5-aee9-1e145bd02e9a", "Greger Puff", "031-666666" },
                    { "19714931-c947-4d37-a434-d9e796b8b898", "The Dude", "0707985544" },
                    { "c8a6b631-dbca-4f21-adfd-f15ee95c26e5", "Niklas Bergh", "031-123456" }
                });

            migrationBuilder.InsertData(
                table: "CityPerson",
                columns: new[] { "CitiesId", "PeopleId" },
                values: new object[] { 1, "c8a6b631-dbca-4f21-adfd-f15ee95c26e5" });

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
    }
}
