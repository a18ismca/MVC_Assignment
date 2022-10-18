using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Assignment.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc6d6c97-ea52-4474-82b2-60b1ecb087c4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84d8c157-016e-4ce7-8b04-9fc9b5ee48e8", "32b85fd6-420c-4a5d-be08-fc8ba6c4bc6e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84d8c157-016e-4ce7-8b04-9fc9b5ee48e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32b85fd6-420c-4a5d-be08-fc8ba6c4bc6e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e82db15-1655-47ac-8b50-bf85071b7c9c", "8d4647a3-463a-401e-93df-92e136581385", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2975f9a-028e-4a91-b99c-80241c9bb89f", "eff15f90-01f2-47ed-be0a-8755a204e2eb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3479399-1d6d-46ad-84cd-e98d832acaf4", 0, "8a77ee17-6a11-46d0-99b0-95941d0c4cc7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEDBHG/0D7dJRKOg5ESddHOm/m0VqPVC3yIM7wh4vuYrHU3CZJhQ3Zk4KGs3HcmixHg==", null, false, "34d64481-d647-4768-98db-87c7bfd73889", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6e82db15-1655-47ac-8b50-bf85071b7c9c", "c3479399-1d6d-46ad-84cd-e98d832acaf4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2975f9a-028e-4a91-b99c-80241c9bb89f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e82db15-1655-47ac-8b50-bf85071b7c9c", "c3479399-1d6d-46ad-84cd-e98d832acaf4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e82db15-1655-47ac-8b50-bf85071b7c9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3479399-1d6d-46ad-84cd-e98d832acaf4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84d8c157-016e-4ce7-8b04-9fc9b5ee48e8", "8ea6bfbd-f0db-4618-bdb1-5ba6c1616756", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc6d6c97-ea52-4474-82b2-60b1ecb087c4", "cecf9b3b-e6ac-4cac-a312-c5203d23d1a1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32b85fd6-420c-4a5d-be08-fc8ba6c4bc6e", 0, "cfb7d0c2-54b5-4597-a0ae-a9db29398510", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEB9PA2TtAkOya4lGJ2US1Ue/K5mZgrbpoxgtuortEXHEBBsV8/7TncSCh4CnL59ZCQ==", null, false, "ee5c1700-3a05-4f91-ab00-cb2b23ccb34a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "84d8c157-016e-4ce7-8b04-9fc9b5ee48e8", "32b85fd6-420c-4a5d-be08-fc8ba6c4bc6e" });
        }
    }
}
