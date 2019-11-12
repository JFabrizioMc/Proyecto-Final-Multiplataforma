using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Multiplataforma.Migrations
{
    public partial class precioUnit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnit",
                table: "Productos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioUnit",
                table: "Productos");
        }
    }
}
