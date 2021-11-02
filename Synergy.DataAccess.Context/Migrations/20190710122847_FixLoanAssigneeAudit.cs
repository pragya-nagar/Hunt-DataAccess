using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class FixLoanAssigneeAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountDue",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "CloseProbability",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "ClosingCost",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "CurrentLoanBalance",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "InterestRate",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "LTV",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "LenderCredit",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "LoanNumber",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "LoanPropertyTypeId",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "LoanTypeId",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "MonthlyPayment",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "OriginationPercent",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "StageId",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "Term",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "ThirdPartyLoanBalance",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.DropColumn(
                name: "TotalLoanAmount",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.RenameColumn(
                name: "OfficerId",
                schema: "main",
                table: "LoanAssigneeAudit",
                newName: "UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "LoanId",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanId",
                schema: "main",
                table: "LoanAssigneeAudit");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "main",
                table: "LoanAssigneeAudit",
                newName: "OfficerId");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountDue",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseDate",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CloseProbability",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ClosingCost",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentLoanBalance",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "InterestRate",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LTV",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LenderCredit",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoanNumber",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanPropertyTypeId",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyPayment",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginationPercent",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageId",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ThirdPartyLoanBalance",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalLoanAmount",
                schema: "main",
                table: "LoanAssigneeAudit",
                nullable: true);
        }
    }
}
