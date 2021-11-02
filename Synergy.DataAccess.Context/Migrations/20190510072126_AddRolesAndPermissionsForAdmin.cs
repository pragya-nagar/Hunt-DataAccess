using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddRolesAndPermissionsForAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 44, "Admin.User.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Admin.User.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Admin.Role.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Admin.Role.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Role",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name", "PermissionId" },
                values: new object[] { new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator", null });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 164, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 165, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 166, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b") },
                    { 167, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b") },
                    { 168, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b") },
                    { 169, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b") },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b"));
        }
    }
}
