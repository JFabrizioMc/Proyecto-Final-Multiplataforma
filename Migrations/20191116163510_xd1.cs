using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Multiplataforma.Migrations
{
    public partial class xd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ID",
                column: "ConcurrencyStamp",
                value: "d3a63c61-8a64-48d1-8a4c-5b1fbdb9536f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN_ID",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "77487bbc-50bb-4f28-8004-ed469509743d", "admin@admin.com", "AQAAAAEAACcQAAAAEC8V5ym1UBYRdwpKS0id8fpwDImI2FeSk81hn6JC5Z1MVrvqSkELcK+hGaehD2dfOg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ID",
                column: "ConcurrencyStamp",
                value: "1a9ba75e-d177-4ae6-ad90-05d38ba891b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN_ID",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "b6270a29-cb37-4d95-a20f-32c83e7107fa", "aadmin@admin.com", "AQAAAAEAACcQAAAAEETz5ViTx2/Q7f0rt6JYU2xEAvYeo8rl7GTC2q26g1FlP2ac6nwKfRxUc2Ox5tz84w==" });
        }
    }
}
