using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddWorkflowDefinitionState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_User_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_User_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_State_StateId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState");

            migrationBuilder.DropForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_WorkflowDefinition_Work~",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnderwritingWorkflowDefinitionState",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState");

            migrationBuilder.RenameTable(
                name: "UnderwritingWorkflowDefinitionState",
                schema: "main",
                newName: "WorkflowDefinitionState",
                newSchema: "main");

            migrationBuilder.RenameIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_WorkflowDefinitionId",
                schema: "main",
                table: "WorkflowDefinitionState",
                newName: "IX_WorkflowDefinitionState_WorkflowDefinitionId1");

            migrationBuilder.RenameIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_StateId",
                schema: "main",
                table: "WorkflowDefinitionState",
                newName: "IX_WorkflowDefinitionState_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_ModifiedById",
                schema: "main",
                table: "WorkflowDefinitionState",
                newName: "IX_WorkflowDefinitionState_ModifiedById");

            migrationBuilder.RenameIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_CreatedById",
                schema: "main",
                table: "WorkflowDefinitionState",
                newName: "IX_WorkflowDefinitionState_CreatedById");

            migrationBuilder.AddColumn<int>(
                name: "WorkflowType",
                schema: "main",
                table: "WorkflowDefinitionState",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkflowDefinitionState",
                schema: "main",
                table: "WorkflowDefinitionState",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinitionState_WorkflowDefinitionId",
                schema: "main",
                table: "WorkflowDefinitionState",
                column: "WorkflowDefinitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowDefinitionState_WorkflowDefinition_WorkflowDefiniti~",
                schema: "main",
                table: "WorkflowDefinitionState",
                column: "WorkflowDefinitionId",
                principalSchema: "main",
                principalTable: "WorkflowDefinition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowDefinitionState_User_CreatedById",
                schema: "main",
                table: "WorkflowDefinitionState",
                column: "CreatedById",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowDefinitionState_User_ModifiedById",
                schema: "main",
                table: "WorkflowDefinitionState",
                column: "ModifiedById",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowDefinitionState_State_StateId",
                schema: "main",
                table: "WorkflowDefinitionState",
                column: "StateId",
                principalSchema: "main",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowDefinitionState_WorkflowDefinition_WorkflowDefiniti~",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowDefinitionState_User_CreatedById",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowDefinitionState_User_ModifiedById",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowDefinitionState_State_StateId",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkflowDefinitionState",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.DropIndex(
                name: "IX_WorkflowDefinitionState_WorkflowDefinitionId",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.DropColumn(
                name: "WorkflowType",
                schema: "main",
                table: "WorkflowDefinitionState");

            migrationBuilder.RenameTable(
                name: "WorkflowDefinitionState",
                schema: "main",
                newName: "UnderwritingWorkflowDefinitionState",
                newSchema: "main");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowDefinitionState_StateId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                newName: "IX_UnderwritingWorkflowDefinitionState_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowDefinitionState_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                newName: "IX_UnderwritingWorkflowDefinitionState_ModifiedById");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowDefinitionState_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                newName: "IX_UnderwritingWorkflowDefinitionState_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowDefinitionState_WorkflowDefinitionId1",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                newName: "IX_UnderwritingWorkflowDefinitionState_WorkflowDefinitionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnderwritingWorkflowDefinitionState",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_User_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "CreatedById",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_User_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "ModifiedById",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_State_StateId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "StateId",
                principalSchema: "main",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnderwritingWorkflowDefinitionState_WorkflowDefinition_Work~",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "WorkflowDefinitionId",
                principalSchema: "main",
                principalTable: "WorkflowDefinition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
