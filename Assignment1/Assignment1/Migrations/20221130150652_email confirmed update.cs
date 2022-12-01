using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1.Migrations
{
    public partial class emailconfirmedupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "f2d9fc1e-384e-440a-bb15-6612f7a13cca", "7742c8ba-cc9d-465c-94b3-0ad5e1b33f29", "Citizen", "CITIZEN" },
                    { "f3413fbb-546d-40dc-a7f5-df6660c57dca", "9828b2f7-9ea7-49dc-8ded-6b58e664d094", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "birthDate" },
                values: new object[] { "e2a6a065-85d6-4770-bf8a-75bc9ba44398", 0, "5081e73d-9452-4959-a672-05316205a6f3", "boss@boss.com", true, "I_control", "Everything", false, null, "BOSS@BOSS.COM", "BOSS@BOSS.COM", "AQAAAAEAACcQAAAAEC6YSsixg06IhLJy+V3B95iedDc1jmvLTAUVby6TVwnh/HvyaEnhpx5rg/rcZJNP3A==", null, false, "df97faa2-6efa-4320-9d34-af1e26822c4f", false, "boss@boss.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[,]
                {
                    { "47d286a4-ff32-4704-bbbc-faaacc9b99c3", 2, "The Dude", "0707985544" },
                    { "e3d0f996-ab23-47aa-8058-24f202383ac8", 1, "Niklas Bergh", "031-123456" },
                    { "f5b102f5-1614-4b9a-a9aa-76f18aa84092", 2, "Greger Puff", "031-666666" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f3413fbb-546d-40dc-a7f5-df6660c57dca", "e2a6a065-85d6-4770-bf8a-75bc9ba44398" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[] { 1, "e3d0f996-ab23-47aa-8058-24f202383ac8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2d9fc1e-384e-440a-bb15-6612f7a13cca");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3413fbb-546d-40dc-a7f5-df6660c57dca", "e2a6a065-85d6-4770-bf8a-75bc9ba44398" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, "e3d0f996-ab23-47aa-8058-24f202383ac8" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "47d286a4-ff32-4704-bbbc-faaacc9b99c3");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "f5b102f5-1614-4b9a-a9aa-76f18aa84092");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3413fbb-546d-40dc-a7f5-df6660c57dca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a6a065-85d6-4770-bf8a-75bc9ba44398");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "e3d0f996-ab23-47aa-8058-24f202383ac8");

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
    }
}
