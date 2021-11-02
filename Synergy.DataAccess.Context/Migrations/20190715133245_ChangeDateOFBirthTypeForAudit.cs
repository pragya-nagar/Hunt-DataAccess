using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeDateOFBirthTypeForAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"UPDATE main.""OpportunityBorrowerBaseAudit"" SET  ""SSN""= NULL, ""DateOfBirth""= NULL";
            migrationBuilder.Sql(sql, true);

            migrationBuilder.DropForeignKey(
                name: "FK_OpportunityBorrowerBaseAudit_Opportunity_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.DropIndex(
                name: "IX_OpportunityBorrowerBaseAudit_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit');", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityBorrowerBaseAudit_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                column: "OpportunityId");

            migrationBuilder.AddForeignKey(
                name: "FK_OpportunityBorrowerBaseAudit_Opportunity_OpportunityId",
                schema: "main",
                table: "OpportunityBorrowerBaseAudit",
                column: "OpportunityId",
                principalSchema: "main",
                principalTable: "Opportunity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
