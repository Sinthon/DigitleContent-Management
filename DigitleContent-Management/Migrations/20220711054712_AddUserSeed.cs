using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitleContent_Management.Migrations
{
    public partial class AddUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d4b4e7dc-be22-47c2-b1df-1296b3ae899a", 0, "ab080d28-735a-460c-be4e-3d5a12f117f2", "admin@example.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPZbSi7Gx1GdjxZ67FF9apt6oJ086CNnjR8Urudl7bnEs1sy1cwWA0WmtrEKFly/Ag==", null, false, "192e459f-5c67-4744-9978-15e84048a623", false, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4b4e7dc-be22-47c2-b1df-1296b3ae899a");
        }
    }
}
