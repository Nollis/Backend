using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class Addedsomerolesandadefaultadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e0072cf9-d846-47cb-9e6b-52c3f79af289", "289904c6-e832-4351-96eb-886770146cac", "Admin", "ADMIN" },
                    { "fa8ceb04-26b4-4602-b33a-eff1b7371247", "df84533c-c21a-47bb-b85d-8d91f50a1e22", "Citizen", "CITIZEN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "birthDate" },
                values: new object[] { "b8e386d7-0a63-4748-82d7-e232a602af7e", 0, "03f1e41c-e60b-4c26-bfba-ae65ec4cacb0", "boss@boss.com", false, "I_control", "Everything", false, null, "BOSS@BOSS.COM", "BOSS@BOSS.COM", "AQAAAAEAACcQAAAAEP/Aro2hDPbRFEItplGdNICur8TuBCnomufY1nhj+vvd664CdWR32dj++JSgOopqyA==", null, false, "91d0f4d8-c59a-451b-8ce9-cc8d4d0dd101", false, "boss@boss.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[,]
                {
                    { "02d1d1d8-c98e-4e32-88be-b21a3a57bdcd", 2, "The Dude", "0707985544" },
                    { "629e0409-110d-4388-80f1-12070b009cb7", 1, "Niklas Bergh", "031-123456" },
                    { "8de9485b-e05d-405e-9f7d-21cc933a50f9", 2, "Greger Puff", "031-666666" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e0072cf9-d846-47cb-9e6b-52c3f79af289", "b8e386d7-0a63-4748-82d7-e232a602af7e" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { 1, "629e0409-110d-4388-80f1-12070b009cb7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa8ceb04-26b4-4602-b33a-eff1b7371247");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0072cf9-d846-47cb-9e6b-52c3f79af289", "b8e386d7-0a63-4748-82d7-e232a602af7e" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, "629e0409-110d-4388-80f1-12070b009cb7" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "02d1d1d8-c98e-4e32-88be-b21a3a57bdcd");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8de9485b-e05d-405e-9f7d-21cc933a50f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0072cf9-d846-47cb-9e6b-52c3f79af289");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8e386d7-0a63-4748-82d7-e232a602af7e");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "629e0409-110d-4388-80f1-12070b009cb7");

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
    }
}
