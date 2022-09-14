using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Assignment.Migrations
{
    public partial class seedRoles0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b24dd6f-7ad5-4f6b-8e96-69c072d30059", "997ea83e-7abc-4142-9ebc-39d8aaca4591", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1dbb13b-e82a-41b7-9b55-109835f8e646", "1ff7d0fc-b18d-4650-914c-3c146b81efc3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Date", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7f65953-bac8-4386-80b5-4885161feff5", 0, "ed4c7482-3589-43df-9488-a18a04251adb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEPKEJRVTqjxBai9jZNBaugKa/y9WT4+SxXCo37jpWZj3xeERmLvv9AZJ7KELTC/2AA==", null, false, "c266653f-2829-46cb-aec3-38c4e831c15b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e1dbb13b-e82a-41b7-9b55-109835f8e646", "f7f65953-bac8-4386-80b5-4885161feff5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b24dd6f-7ad5-4f6b-8e96-69c072d30059");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1dbb13b-e82a-41b7-9b55-109835f8e646", "f7f65953-bac8-4386-80b5-4885161feff5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1dbb13b-e82a-41b7-9b55-109835f8e646");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7f65953-bac8-4386-80b5-4885161feff5");
        }
    }
}
