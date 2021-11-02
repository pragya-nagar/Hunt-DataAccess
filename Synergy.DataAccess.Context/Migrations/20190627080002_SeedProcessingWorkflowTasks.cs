using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class SeedProcessingWorkflowTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "File Started", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disclosure", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assignment", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000005"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loan Approved", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000006"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000007"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doc Sent", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000008"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Funding", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-000000000009"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved With Condition", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-00000000000a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denied", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-00000000000b"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closing Condition", 3, null, 1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-00000000000c"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "N Round Review", 3, null, -1, 2 });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "WorkflowType" },
                values: new object[] { new Guid("00000000-0000-0000-0002-00000000000d"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Round Review", 3, null, 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000001"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000002"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000003"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000004"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000005"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000006"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000007"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000008"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000009"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-00000000000a"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-00000000000b"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-00000000000c"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-00000000000d"));
        }
    }
}
