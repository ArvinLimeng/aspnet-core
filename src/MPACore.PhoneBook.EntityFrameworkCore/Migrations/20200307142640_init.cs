using Microsoft.EntityFrameworkCore.Migrations;

namespace MPACore.PhoneBook.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmaillAddress",
                schema: "PB",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                schema: "PB",
                table: "Person",
                maxLength: 80,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                schema: "PB",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "EmaillAddress",
                schema: "PB",
                table: "Person",
                maxLength: 50,
                nullable: true);
        }
    }
}
