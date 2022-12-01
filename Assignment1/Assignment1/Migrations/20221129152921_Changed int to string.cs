using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Changedinttostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, "2e158278-5022-45ef-bd09-9016e8c59b43" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "2ea1426f-37f5-4861-874b-b2830d22445c");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "86ba76f7-c866-4798-afea-3e049ecccbfa");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "2e158278-5022-45ef-bd09-9016e8c59b43");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "1c134310-8861-4307-a87f-3d50b14c80dd", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "373fe8d4-aa71-422f-9a0c-3b4d5d1a0e90", 2, "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "9f83b966-5532-4afd-b9a8-2071860513d6", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { 1, "9f83b966-5532-4afd-b9a8-2071860513d6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, "9f83b966-5532-4afd-b9a8-2071860513d6" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "1c134310-8861-4307-a87f-3d50b14c80dd");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "373fe8d4-aa71-422f-9a0c-3b4d5d1a0e90");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "9f83b966-5532-4afd-b9a8-2071860513d6");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "2e158278-5022-45ef-bd09-9016e8c59b43", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "2ea1426f-37f5-4861-874b-b2830d22445c", 2, "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "86ba76f7-c866-4798-afea-3e049ecccbfa", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { 1, "2e158278-5022-45ef-bd09-9016e8c59b43" });
        }
    }
}
