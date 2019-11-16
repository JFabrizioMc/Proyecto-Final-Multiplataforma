using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Multiplataforma.Migrations
{
    public partial class xxccd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "b6270a29-cb37-4d95-a20f-32c83e7107fa", "aadmin@admin.com", "AQAAAAEAACcQAAAAEETz5ViTx2/Q7f0rt6JYU2xEAvYeo8rl7GTC2q26g1FlP2ac6nwKfRxUc2Ox5tz84w==", "admin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ID",
                column: "ConcurrencyStamp",
                value: "ae31aeec-8bef-463b-8a8a-c2730ad9a587");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN_ID",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "75a847f3-23a7-4102-86e2-2fd5006a2acf", "admin", "AQAAAAEAACcQAAAAEB+vSDlz8WiHvlwNRMPnFZm8xdNrePFE3NnhoIriJYb1Ufk9/X6m8YHu+GGejCb6Pg==", "admin" });
        }
    }
}
