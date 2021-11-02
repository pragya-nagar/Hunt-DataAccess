using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeRelationsBetweenOpportunityAndBorrowerTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Discriminator",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBase",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "main",
                table: "OpportunityBorrowerBase",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBaseAudit_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBase_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBase",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBase_OpportunityId1",
                schema: "main",
                table: "OpportunityBorrowerBase",
                column: "OpportunityId");

            migrationBuilder.AddForeignKey(
                name: "FK_OpportunityBorrowerBase_Opportunity_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBase",
                column: "OpportunityId",
                principalSchema: "main",
                principalTable: "Opportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpportunityBorrowerBase_Opportunity_OpportunityId1",
                schema: "main",
                table: "OpportunityBorrowerBase",
                column: "OpportunityId",
                principalSchema: "main",
                principalTable: "Opportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpportunityBorrowerBaseAudit_Opportunity_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                column: "OpportunityId",
                principalSchema: "main",
                principalTable: "Opportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit');", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpportunityBorrowerBase_Opportunity_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBase");

            migrationBuilder.DropForeignKey(
                name: "FK_OpportunityBorrowerBase_Opportunity_OpportunityId1",
                schema: "main",
                table: "OpportunityBorrowerBase");

            migrationBuilder.DropForeignKey(
                name: "FK_OpportunityBorrowerBaseAudit_Opportunity_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.DropIndex(
                name: "IX_OpportunityBorrowerBaseAudit_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.DropIndex(
                name: "IX_OpportunityBorrowerBase_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBase");

            migrationBuilder.DropIndex(
                name: "IX_OpportunityBorrowerBase_OpportunityId1",
                schema: "main",
                table: "OpportunityBorrowerBase");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.DropColumn(
                name: "Order",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBase");

            migrationBuilder.DropColumn(
                name: "Order",
                schema: "main",
                table: "OpportunityBorrowerBase");

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
        }
    }
}
