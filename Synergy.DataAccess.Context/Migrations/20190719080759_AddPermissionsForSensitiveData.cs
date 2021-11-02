using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddPermissionsForSensitiveData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 56, "CRM.OpportunitySensitiveData.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, "CRM.OpportunitySensitiveData.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 188, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 190, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 189, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 191, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 57);
        }
    }
}
