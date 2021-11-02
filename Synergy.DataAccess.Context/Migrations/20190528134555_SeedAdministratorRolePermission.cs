using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class SeedAdministratorRolePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit', 'InsertedOn');", true);

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[] { 187, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 187);
        }
    }
}
