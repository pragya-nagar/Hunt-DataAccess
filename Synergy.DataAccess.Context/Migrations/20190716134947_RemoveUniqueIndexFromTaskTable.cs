using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class RemoveUniqueIndexFromTaskTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId_WorkflowId_InstanceNumber",
                schema: "main",
                table: "Task");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId_WorkflowId_InstanceNumber",
                schema: "main",
                table: "Task",
                columns: new[] { "TaskDefinitionId", "WorkflowId", "InstanceNumber" },
                unique: true);
        }
    }
}
