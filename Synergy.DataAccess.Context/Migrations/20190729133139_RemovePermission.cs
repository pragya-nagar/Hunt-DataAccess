using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class RemovePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[] { 2, "CRM.Dashboard.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                });
        }
    }
}
