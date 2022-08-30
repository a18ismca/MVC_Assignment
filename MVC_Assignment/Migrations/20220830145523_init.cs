using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Assignment.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Stockholm", "Alisa", 28356 },
                    { 2, "Göteborg", "Erik", 67890 },
                    { 3, "Malmö", "Ismet", 12345 },
                    { 4, "Malmö", "Åsa", 54545 },
                    { 5, "Göteborg", "Jagvetinte", 54343 },
                    { 6, "Stockholm", "Hejpådig", 54242 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
