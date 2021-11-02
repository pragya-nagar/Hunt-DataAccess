using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddMailMergePermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 48, "Admin.CRMMailMerge.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Admin.CRMMailMerge.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Admin.CRMMailMerge.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, "Admin.UnderwritingMailMerge.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "Admin.UnderwritingMailMerge.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, "Admin.UnderwritingMailMerge.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, "Underwriting.MailMerge.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "CRM.MailMerge.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 170, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 186, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 185, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 176, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 184, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 175, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 183, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 177, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 174, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 173, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 180, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 172, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 179, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 171, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 178, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 182, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 181, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 55);
        }
    }
}
