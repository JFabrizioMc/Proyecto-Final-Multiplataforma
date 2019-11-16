using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Final_Multiplataforma.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ROLE_ID", "ae31aeec-8bef-463b-8a8a-c2730ad9a587", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ADMIN_ID", 0, "75a847f3-23a7-4102-86e2-2fd5006a2acf", "admin@admin.com", true, false, null, "admin@admin.com", "admin", "AQAAAAEAACcQAAAAEB+vSDlz8WiHvlwNRMPnFZm8xdNrePFE3NnhoIriJYb1Ufk9/X6m8YHu+GGejCb6Pg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ADMIN_ID", "ROLE_ID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ADMIN_ID", "ROLE_ID" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE_ID");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMIN_ID");
        }
    }
}
