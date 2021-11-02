using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddWorkflowContextTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompletionType",
                schema: "main",
                table: "Task",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                schema: "main",
                table: "Task",
                nullable: true,
                defaultValue: DateTime.UtcNow);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                schema: "main",
                table: "Task",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkflowContext",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    WorkflowId = table.Column<Guid>(nullable: false),
                    Context = table.Column<string>(type: "json", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowContext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowContext_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkflowContext_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkflowContext_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "main",
                        principalTable: "Workflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowContext_CreatedById",
                schema: "main",
                table: "WorkflowContext",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowContext_ModifiedById",
                schema: "main",
                table: "WorkflowContext",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowContext_WorkflowId",
                schema: "main",
                table: "WorkflowContext",
                column: "WorkflowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkflowContext",
                schema: "main");

            migrationBuilder.DropColumn(
                name: "CompletionType",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "DueDate",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "main",
                table: "Task");
        }
    }
}
