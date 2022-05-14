using Microsoft.EntityFrameworkCore.Migrations;

namespace Miau.Migrations
{
    public partial class updatePetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Pets",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "AnimalBreed",
                table: "Pets",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Pets",
                newName: "CustomerName");

            migrationBuilder.AddColumn<string>(
                name: "AnimalName",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimalName",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Pets",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Pets",
                newName: "AnimalBreed");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Pets",
                newName: "Age");
        }
    }
}
