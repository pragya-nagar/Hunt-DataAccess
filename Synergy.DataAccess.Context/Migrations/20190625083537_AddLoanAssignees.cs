using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddLoanAssignees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropIndex(
                name: "IX_Loan_AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.CreateTable(
                name: "LoanAssignee",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LoanId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanAssignee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanAssignee_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanAssignee_Loan_LoanId",
                        column: x => x.LoanId,
                        principalSchema: "main",
                        principalTable: "Loan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanAssignee_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanAssignee_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanAssigneeAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    StageId = table.Column<int>(nullable: false),
                    AssigneeId = table.Column<Guid>(nullable: true),
                    OfficerId = table.Column<Guid>(nullable: false),
                    LoanTypeId = table.Column<int>(nullable: true),
                    LoanPropertyTypeId = table.Column<int>(nullable: false),
                    LoanNumber = table.Column<string>(nullable: true),
                    AmountDue = table.Column<decimal>(nullable: true),
                    TotalLoanAmount = table.Column<decimal>(nullable: true),
                    LTV = table.Column<decimal>(nullable: true),
                    CloseDate = table.Column<DateTime>(nullable: true),
                    CloseProbability = table.Column<decimal>(nullable: true),
                    ClosingCost = table.Column<decimal>(nullable: true),
                    CurrentLoanBalance = table.Column<decimal>(nullable: true),
                    ThirdPartyLoanBalance = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    Term = table.Column<int>(nullable: true),
                    MonthlyPayment = table.Column<decimal>(nullable: true),
                    LenderCredit = table.Column<decimal>(nullable: true),
                    OriginationPercent = table.Column<decimal>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanAssigneeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanAssignee_CreatedById",
                schema: "main",
                table: "LoanAssignee",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAssignee_LoanId",
                schema: "main",
                table: "LoanAssignee",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAssignee_ModifiedById",
                schema: "main",
                table: "LoanAssignee",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanAssignee_UserId",
                schema: "main",
                table: "LoanAssignee",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanAssignee",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanAssigneeAudit",
                schema: "main");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_AssigneeId",
                schema: "main",
                table: "Loan",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan",
                column: "AssigneeId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
