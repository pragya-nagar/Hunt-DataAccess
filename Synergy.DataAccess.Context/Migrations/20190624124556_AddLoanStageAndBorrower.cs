using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddLoanStageAndBorrower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AmountDue",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseDate",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CloseProbability",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ClosingCost",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentLoanBalance",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LTV",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyPayment",
                schema: "main",
                table: "LoanAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OfficerId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "StageId",
                schema: "main",
                table: "LoanAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountDue",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssigneeId",
                schema: "main",
                table: "Loan",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseDate",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CloseProbability",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ClosingCost",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentLoanBalance",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LTV",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoanTypeId",
                schema: "main",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyPayment",
                schema: "main",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OfficerId",
                schema: "main",
                table: "Loan",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "StageId",
                schema: "main",
                table: "Loan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Borrower",
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SocialSecurityNumber = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrower_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrower_Loan_LoanId",
                        column: x => x.LoanId,
                        principalSchema: "main",
                        principalTable: "Loan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrower_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowerAudit",
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SocialSecurityNumber = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowerAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EntityBorrower",
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
                    EntityName = table.Column<string>(nullable: true),
                    TaxID = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OfficePhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    AuthorizedOfficerName = table.Column<string>(nullable: true),
                    AuthorizedOfficerTitle = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityBorrower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityBorrower_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityBorrower_Loan_LoanId",
                        column: x => x.LoanId,
                        principalSchema: "main",
                        principalTable: "Loan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityBorrower_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityBorrowerAudit",
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
                    EntityName = table.Column<string>(nullable: true),
                    TaxID = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OfficePhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    AuthorizedOfficerName = table.Column<string>(nullable: true),
                    AuthorizedOfficerTitle = table.Column<string>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityBorrowerAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "LoanStage",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanStage_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanStage_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanStageAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanStageAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "LoanStage",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "File Started", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "FileStarted" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Disclosed", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disclosed" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Processing", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Underwriting", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Scheduled", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Docs Sent", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "DocsSent" },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Funded", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Funded" },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Completion", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completion" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_AssigneeId",
                schema: "main",
                table: "Loan",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_LoanTypeId",
                schema: "main",
                table: "Loan",
                column: "LoanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_OfficerId",
                schema: "main",
                table: "Loan",
                column: "OfficerId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_StageId",
                schema: "main",
                table: "Loan",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrower_CreatedById",
                schema: "main",
                table: "Borrower",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Borrower_LoanId",
                schema: "main",
                table: "Borrower",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrower_ModifiedById",
                schema: "main",
                table: "Borrower",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EntityBorrower_CreatedById",
                schema: "main",
                table: "EntityBorrower",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EntityBorrower_LoanId",
                schema: "main",
                table: "EntityBorrower",
                column: "LoanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityBorrower_ModifiedById",
                schema: "main",
                table: "EntityBorrower",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanStage_CreatedById",
                schema: "main",
                table: "LoanStage",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanStage_ModifiedById",
                schema: "main",
                table: "LoanStage",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan",
                column: "AssigneeId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_LoanType_LoanTypeId",
                schema: "main",
                table: "Loan",
                column: "LoanTypeId",
                principalSchema: "main",
                principalTable: "LoanType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_User_OfficerId",
                schema: "main",
                table: "Loan",
                column: "OfficerId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_LoanStage_StageId",
                schema: "main",
                table: "Loan",
                column: "StageId",
                principalSchema: "main",
                principalTable: "LoanStage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loan_User_AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_LoanType_LoanTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_User_OfficerId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_LoanStage_StageId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropTable(
                name: "Borrower",
                schema: "main");

            migrationBuilder.DropTable(
                name: "BorrowerAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EntityBorrower",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EntityBorrowerAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanStage",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanStageAudit",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Loan_AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropIndex(
                name: "IX_Loan_LoanTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropIndex(
                name: "IX_Loan_OfficerId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropIndex(
                name: "IX_Loan_StageId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "AmountDue",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "CloseProbability",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "ClosingCost",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "CurrentLoanBalance",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "LTV",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "LoanTypeId",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "MonthlyPayment",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "OfficerId",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "StageId",
                schema: "main",
                table: "LoanAudit");

            migrationBuilder.DropColumn(
                name: "AmountDue",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "CloseProbability",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "ClosingCost",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "CurrentLoanBalance",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "LTV",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "LoanTypeId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "MonthlyPayment",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "OfficerId",
                schema: "main",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "StageId",
                schema: "main",
                table: "Loan");
        }
    }
}
