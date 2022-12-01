using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class addedbirthdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "birthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "34d2487f-9a7c-46e4-bcfe-68d04d51b831", 2, "Greger Puff", "031-666666" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "8f7adc82-66af-480e-b2c0-0ce1d955df81", 1, "Niklas Bergh", "031-123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[] { "d2b6d764-9892-4ae2-a98a-54e8fc119c79", 2, "The Dude", "0707985544" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { 1, "8f7adc82-66af-480e-b2c0-0ce1d955df81" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, "8f7adc82-66af-480e-b2c0-0ce1d955df81" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "34d2487f-9a7c-46e4-bcfe-68d04d51b831");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d2b6d764-9892-4ae2-a98a-54e8fc119c79");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8f7adc82-66af-480e-b2c0-0ce1d955df81");

            migrationBuilder.DropColumn(
                name: "birthDate",
                table: "AspNetUsers");

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
    }
}
