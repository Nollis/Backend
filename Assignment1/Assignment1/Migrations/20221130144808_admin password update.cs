using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class adminpasswordupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "562bace6-e04f-4d59-b04f-1c847c5078ba", "cffe2e6a-e818-4a27-89a3-e9f09f5e8b36", "Citizen", "CITIZEN" },
                    { "60100464-898d-491b-b35d-04bdc0b3acac", "f7914d7b-70da-4233-b820-194d2bb86387", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "birthDate" },
                values: new object[] { "933188e6-67e6-483b-b4a5-e2eeb06461e1", 0, "99d7247d-ee5e-47c7-85bf-fb302b35f829", "boss@boss.com", false, "I_control", "Everything", false, null, "BOSS@BOSS.COM", "BOSS@BOSS.COM", "AQAAAAEAACcQAAAAENBJw7cpf1xkyZsduDJCxnPF1pnDmHskeztH36+ZrexFXSFdh4xQCm3loz7zJy4Jvw==", null, false, "c6c62a57-09b7-46d5-9354-815739f5f27d", false, "boss@boss.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[,]
                {
                    { "50ee6755-d55d-4376-8bf1-a67f3330e583", 2, "The Dude", "0707985544" },
                    { "68740cee-fe08-42d2-8e81-2ce8054ab2b1", 1, "Niklas Bergh", "031-123456" },
                    { "eff48d71-9378-4692-a8ae-edd168f2eeb8", 2, "Greger Puff", "031-666666" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "60100464-898d-491b-b35d-04bdc0b3acac", "933188e6-67e6-483b-b4a5-e2eeb06461e1" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { 1, "68740cee-fe08-42d2-8e81-2ce8054ab2b1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "562bace6-e04f-4d59-b04f-1c847c5078ba");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60100464-898d-491b-b35d-04bdc0b3acac", "933188e6-67e6-483b-b4a5-e2eeb06461e1" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, "68740cee-fe08-42d2-8e81-2ce8054ab2b1" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "50ee6755-d55d-4376-8bf1-a67f3330e583");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "eff48d71-9378-4692-a8ae-edd168f2eeb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60100464-898d-491b-b35d-04bdc0b3acac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "933188e6-67e6-483b-b4a5-e2eeb06461e1");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "68740cee-fe08-42d2-8e81-2ce8054ab2b1");

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
    }
}
