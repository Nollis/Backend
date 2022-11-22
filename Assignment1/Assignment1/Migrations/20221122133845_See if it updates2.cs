using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Seeifitupdates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5cc3278b-265a-4dd7-ac3b-38f0861e69fc", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "c1234332-2a31-4f39-b9fe-96b9af827420", 2, "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "f1b5f938-a425-49be-8e3c-154ccc673328", 1, "Niklas Bergh", "031-123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "5cc3278b-265a-4dd7-ac3b-38f0861e69fc");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "c1234332-2a31-4f39-b9fe-96b9af827420");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "f1b5f938-a425-49be-8e3c-154ccc673328");

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
    }
}
