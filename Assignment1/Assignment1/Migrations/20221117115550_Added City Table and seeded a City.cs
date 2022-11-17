using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class AddedCityTableandseededaCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Göteborg" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[,]
                {
                    { "37ecb845-312e-4c2a-bd07-0e86de444125", "Mölndal", "Greger Puff", "031-666666" },
                    { "38618de8-7060-4e4f-8f62-c0b3ca7ee304", "Falsterbo", "The Dude", "0707985544" },
                    { "5cefa1a2-df78-4c17-8d20-41cff0d60e33", "Göteborg", "Niklas Bergh", "031-123456" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

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

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "9ffe1dda-8b59-451e-a90f-d8a294a5eb95", "Mölndal", "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "a20027c1-32b7-4d7b-9a5f-5ebbf1f58780", "Falsterbo", "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "df43e1ff-4cf3-4e35-a53f-5ab1ff517ee1", "Göteborg", "Niklas Bergh", "031-123456" });
        }
    }
}
