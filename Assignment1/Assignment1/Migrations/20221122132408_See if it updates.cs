using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Seeifitupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "4f4ef7ef-649b-4a03-8b23-1d4ccaebb488", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "7eb42585-98da-46f3-b498-2e8a53c5fed3", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "b3585a61-e856-4be5-adb6-0488b71b4962", 2, "Greger Puff", "031-666666" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "4f4ef7ef-649b-4a03-8b23-1d4ccaebb488");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "7eb42585-98da-46f3-b498-2e8a53c5fed3");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "b3585a61-e856-4be5-adb6-0488b71b4962");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "8bf29d56-8281-4c51-bc17-e45496169f13", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "8df43ec8-f2da-4667-b58d-a9220e194278", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "ba2ee2c3-b418-46a0-8f15-cf1bbdece9d1", 2, "Greger Puff", "031-666666" });
        }
    }
}
