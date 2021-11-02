using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddOpportunityBorrowerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstBorrowerCellPhone",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerDateOfBirth",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerEmail",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerFax",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerFirstName",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerLastName",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerMerried",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerMiddleName",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerSSN",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerWorkPhone",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerCellPhone",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerDateOfBirth",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerEmail",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerFax",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerFirstName",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerLastName",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerMerried",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerMiddleName",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerSSN",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerWorkPhone",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerCellPhone",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerDateOfBirth",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerEmail",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerFax",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerFirstName",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerLastName",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerMerried",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerMiddleName",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerSSN",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerWorkPhone",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerCellPhone",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerDateOfBirth",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerEmail",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerFax",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerFirstName",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerLastName",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerMerried",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerMiddleName",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerSSN",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerWorkPhone",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.AddColumn<Guid>(
                name: "CommercialBorrowerId",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FirstBorrowerId",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SecondBorrowerId",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CommercialBorrowerId",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FirstBorrowerId",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SecondBorrowerId",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OpportunityBorrowerBase",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    SSN = table.Column<string>(nullable: true),
                    IsMarried = table.Column<bool>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    EntityName = table.Column<string>(nullable: true),
                    TaxIdNumber = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityBorrowerBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityBorrowerBase_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityBorrowerBase_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityBorrowerBaseAudit",
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                    SSN = table.Column<string>(nullable: true),
                    IsMarried = table.Column<bool>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    EntityName = table.Column<string>(nullable: true),
                    TaxIdNumber = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityBorrowerBaseAudit", x => new { x.Id, x.InsertedOn });
                    table.ForeignKey(
                        name: "FK_OpportunityBorrowerBaseAudit_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityBorrowerBaseAudit_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_CommercialBorrowerId",
                schema: "main",
                table: "Opportunity",
                column: "CommercialBorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_FirstBorrowerId",
                schema: "main",
                table: "Opportunity",
                column: "FirstBorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_SecondBorrowerId",
                schema: "main",
                table: "Opportunity",
                column: "SecondBorrowerId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBase_CreatedById",
                schema: "main",
                table: "OpportunityBorrowerBase",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBase_ModifiedById",
                schema: "main",
                table: "OpportunityBorrowerBase",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBaseAudit_CreatedById",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBaseAudit_ModifiedById",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_OpportunityBorrowerBase_CommercialBorrowerId",
                schema: "main",
                table: "Opportunity",
                column: "CommercialBorrowerId",
                principalSchema: "main",
                principalTable: "OpportunityBorrowerBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_OpportunityBorrowerBase_FirstBorrowerId",
                schema: "main",
                table: "Opportunity",
                column: "FirstBorrowerId",
                principalSchema: "main",
                principalTable: "OpportunityBorrowerBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_OpportunityBorrowerBase_SecondBorrowerId",
                schema: "main",
                table: "Opportunity",
                column: "SecondBorrowerId",
                principalSchema: "main",
                principalTable: "OpportunityBorrowerBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit');", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_OpportunityBorrowerBase_CommercialBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_OpportunityBorrowerBase_FirstBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_OpportunityBorrowerBase_SecondBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropTable(
                name: "OpportunityBorrowerBase",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityBorrowerBaseAudit",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Opportunity_CommercialBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_Opportunity_FirstBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_Opportunity_SecondBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "CommercialBorrowerId",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerId",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerId",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "CommercialBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "FirstBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "SecondBorrowerId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerCellPhone",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstBorrowerDateOfBirth",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerEmail",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerFax",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerFirstName",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerLastName",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FirstBorrowerMerried",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerMiddleName",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerSSN",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerWorkPhone",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerCellPhone",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondBorrowerDateOfBirth",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerEmail",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerFax",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerFirstName",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerLastName",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SecondBorrowerMerried",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerMiddleName",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerSSN",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerWorkPhone",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerCellPhone",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstBorrowerDateOfBirth",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerEmail",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerFax",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerFirstName",
                schema: "main",
                table: "Opportunity",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerLastName",
                schema: "main",
                table: "Opportunity",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "FirstBorrowerMerried",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerMiddleName",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerSSN",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBorrowerWorkPhone",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerCellPhone",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondBorrowerDateOfBirth",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerEmail",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerFax",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerFirstName",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerLastName",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SecondBorrowerMerried",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerMiddleName",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerSSN",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBorrowerWorkPhone",
                schema: "main",
                table: "Opportunity",
                nullable: true);
        }
    }
}
