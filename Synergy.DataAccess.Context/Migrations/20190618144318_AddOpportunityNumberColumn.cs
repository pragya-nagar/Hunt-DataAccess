using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddOpportunityNumberColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpportunityNumber",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpportunityNumber",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_OpportunityNumber",
                schema: "main",
                table: "Opportunity",
                column: "OpportunityNumber",
                unique: true);

            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit');", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Opportunity_OpportunityNumber",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "OpportunityNumber",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "OpportunityNumber",
                schema: "main",
                table: "Opportunity");
        }
    }
}
