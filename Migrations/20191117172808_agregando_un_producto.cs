using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Multiplataforma.Migrations
{
    public partial class agregando_un_producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ID",
                column: "ConcurrencyStamp",
                value: "2dfe6c8b-69ca-4120-af4e-80602a835916");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN_ID",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64ff611f-201d-4cd7-bfec-e5eb65f82e4d", "AQAAAAEAACcQAAAAEC1xUWst0ardvIQ3zCyCG7tv3Bc+br0NWxn/N39s5EIsLZ3WlAS/tXOmRzFazrLOIQ==" });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CategoriaId", "Descripcion", "Foto", "Nombre", "PrecioUnit" },
                values: new object[] { 1, 1, "Es una buena pc para los juegos de ultima generacion", "https://http2.mlstatic.com/pc-gamer-core-i7-4ghz-16g-ram-gtx-1070-700w-ssd-1tera-D_NQ_NP_983679-MPE31254597571_062019-Q.jpg", "PC GAMER INTEL CORE I7-9700 RAM 16GB 2TB + SSD 120GB VIDEO 4GB", 3935.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ID",
                column: "ConcurrencyStamp",
                value: "7fa837ea-f20d-4378-aada-af814cba898a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN_ID",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "639981b2-d738-42e2-ba23-2e9138ec3a24", "AQAAAAEAACcQAAAAEE+XUEh46xCNPWYtAOItyG2XgFLQFRDGHXU+/HVZ0KVaZ7n1r0V5WTQ6Bu/E3wO2CA==" });
        }
    }
}
