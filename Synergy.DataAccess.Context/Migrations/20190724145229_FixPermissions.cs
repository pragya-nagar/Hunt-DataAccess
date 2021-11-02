using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class FixPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 40,
                column: "Action",
                value: "Workflow.UnderwritingTaskType.Read");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 41,
                column: "Action",
                value: "Workflow.UnderwritingTaskType.Write");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 42,
                column: "Action",
                value: "Workflow.UnderwritingWorkflowType.Read");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 43,
                column: "Action",
                value: "Workflow.UnderwritingWorkflowType.Write");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Action", "CreatedOn", "ModifiedOn" },
                values: new object[] { "Workflow.ProcessingTaskType.Read", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Action", "CreatedOn", "ModifiedOn" },
                values: new object[] { "Workflow.ProcessingTaskType.Write", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Action", "CreatedOn", "ModifiedOn" },
                values: new object[] { "Workflow.ProcessingWorkflowType.Read", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[] { 63, "Workflow.ProcessingWorkflowType.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 228,
                column: "PermissionId",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 229,
                column: "PermissionId",
                value: 61);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 230,
                column: "PermissionId",
                value: 62);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 231,
                column: "PermissionId",
                value: 63);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 40,
                column: "Action",
                value: "Workflow.TaskType.Read");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 41,
                column: "Action",
                value: "Workflow.TaskType.Write");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 42,
                column: "Action",
                value: "Workflow.WorkflowType.Read");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 43,
                column: "Action",
                value: "Workflow.WorkflowType.Write");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Action", "CreatedOn", "ModifiedOn" },
                values: new object[] { "Admin.ProcessingMailMerge.Read", new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Action", "CreatedOn", "ModifiedOn" },
                values: new object[] { "Admin.ProcessingMailMerge.Write", new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Permission",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Action", "CreatedOn", "ModifiedOn" },
                values: new object[] { "Admin.ProcessingMailMerge.Delete", new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 7, "CRM.SensitiveData.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "CRM.SensitiveData.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "CRM.Contacts.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 228,
                column: "PermissionId",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 229,
                column: "PermissionId",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 230,
                column: "PermissionId",
                value: 42);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: 231,
                column: "PermissionId",
                value: 43);

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 233, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 232, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 234, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 32, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 33, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 34, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 35, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 197, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 215, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                    { 36, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 37, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 45, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 46, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 200, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d") },
                    { 218, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3") },
                });
        }
    }
}
