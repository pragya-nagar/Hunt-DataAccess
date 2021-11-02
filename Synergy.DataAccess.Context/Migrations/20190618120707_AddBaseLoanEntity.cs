using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddBaseLoanEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loan",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LoanNumber = table.Column<string>(nullable: true),
                    TotalLoanAmount = table.Column<decimal>(nullable: true),
                    ThirdPartyLoanBalance = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    Term = table.Column<int>(nullable: true),
                    LenderCredit = table.Column<decimal>(nullable: true),
                    OriginationPercent = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loan_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loan_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanAudit",
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
                    LoanNumber = table.Column<string>(nullable: true),
                    TotalLoanAmount = table.Column<decimal>(nullable: true),
                    ThirdPartyLoanBalance = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    Term = table.Column<int>(nullable: true),
                    LenderCredit = table.Column<decimal>(nullable: true),
                    OriginationPercent = table.Column<decimal>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "LoanPropertyAudit",
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
                    LoanId = table.Column<Guid>(nullable: false),
                    PropertyId = table.Column<Guid>(nullable: false),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanPropertyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "LoanProperty",
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
                    PropertyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanProperty_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProperty_Loan_LoanId",
                        column: x => x.LoanId,
                        principalSchema: "main",
                        principalTable: "Loan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProperty_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanProperty_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "main",
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_CreatedById",
                schema: "main",
                table: "Loan",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_ModifiedById",
                schema: "main",
                table: "Loan",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProperty_CreatedById",
                schema: "main",
                table: "LoanProperty",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProperty_LoanId",
                schema: "main",
                table: "LoanProperty",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProperty_ModifiedById",
                schema: "main",
                table: "LoanProperty",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanProperty_PropertyId",
                schema: "main",
                table: "LoanProperty",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanProperty",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanPropertyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Loan",
                schema: "main");
        }
    }
}
