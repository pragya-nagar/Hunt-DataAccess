using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class FixProcessingPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 202,
                column: "PermissionId",
                value: 56);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 220,
                column: "PermissionId",
                value: 56);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 202,
                column: "PermissionId",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 220,
                column: "PermissionId",
                value: 13);
        }
    }
}
