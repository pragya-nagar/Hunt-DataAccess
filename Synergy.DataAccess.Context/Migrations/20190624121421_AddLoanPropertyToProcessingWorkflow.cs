using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddLoanPropertyToProcessingWorkflow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LoanId",
                schema: "main",
                table: "Workflow",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_LoanId",
                schema: "main",
                table: "Workflow",
                column: "LoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workflow_Loan_LoanId",
                schema: "main",
                table: "Workflow",
                column: "LoanId",
                principalSchema: "main",
                principalTable: "Loan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workflow_Loan_LoanId",
                schema: "main",
                table: "Workflow");

            migrationBuilder.DropIndex(
                name: "IX_Workflow_LoanId",
                schema: "main",
                table: "Workflow");

            migrationBuilder.DropColumn(
                name: "LoanId",
                schema: "main",
                table: "Workflow");
        }
    }
}
