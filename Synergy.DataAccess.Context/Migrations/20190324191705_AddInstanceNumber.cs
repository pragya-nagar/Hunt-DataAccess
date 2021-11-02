using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddInstanceNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId1",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId2",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "DueDate",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "Order",
                schema: "main",
                table: "Task");

            migrationBuilder.AddColumn<int>(
                name: "InstanceNumber",
                schema: "main",
                table: "Task",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000015"),
                column: "TriggerDayOffset",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000016"),
                column: "TriggerDayOffset",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId_WorkflowId_InstanceNumber",
                schema: "main",
                table: "Task",
                columns: new[] { "TaskDefinitionId", "WorkflowId", "InstanceNumber" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId_WorkflowId_InstanceNumber",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "InstanceNumber",
                schema: "main",
                table: "Task");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                schema: "main",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                schema: "main",
                table: "Task",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "main",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000015"),
                column: "TriggerDayOffset",
                value: -45);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TaskDefinition",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000016"),
                column: "TriggerDayOffset",
                value: -45);

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId1",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId2",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId");
        }
    }
}
