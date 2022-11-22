using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Seeifitupdates3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1a4e3409-f9d6-4792-a9c0-e077a54ce886", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "39638a1e-8942-46cf-8458-35d4e3191ba6", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "Phone" },
                values: new object[] { "7ebbfe68-5b28-4c98-8295-93f5dc898963", 2, "Greger Puff", "031-666666" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "1a4e3409-f9d6-4792-a9c0-e077a54ce886");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "39638a1e-8942-46cf-8458-35d4e3191ba6");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "7ebbfe68-5b28-4c98-8295-93f5dc898963");

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
    }
}
