using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Multiplataforma.Migrations
{
    public partial class cucu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Teclados" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
