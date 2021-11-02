using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeDelinquencyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Delinquency_EventId_PropertyId",
                schema: "main",
                table: "Delinquency");

            migrationBuilder.AddColumn<decimal>(
                name: "LTVPercent",
                schema: "main",
                table: "DelinquencyAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RUAmount",
                schema: "main",
                table: "DelinquencyAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RULTVPercent",
                schema: "main",
                table: "DelinquencyAudit",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LTVPercent",
                schema: "main",
                table: "Delinquency",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RUAmount",
                schema: "main",
                table: "Delinquency",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RULTVPercent",
                schema: "main",
                table: "Delinquency",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Delinquency_EventId_PropertyId_DelinquencyTaxYear",
                schema: "main",
                table: "Delinquency",
                columns: new[] { "EventId", "PropertyId", "DelinquencyTaxYear" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Delinquency_EventId_PropertyId_DelinquencyTaxYear",
                schema: "main",
                table: "Delinquency");

            migrationBuilder.DropColumn(
                name: "LTVPercent",
                schema: "main",
                table: "DelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "RUAmount",
                schema: "main",
                table: "DelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "RULTVPercent",
                schema: "main",
                table: "DelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "LTVPercent",
                schema: "main",
                table: "Delinquency");

            migrationBuilder.DropColumn(
                name: "RUAmount",
                schema: "main",
                table: "Delinquency");

            migrationBuilder.DropColumn(
                name: "RULTVPercent",
                schema: "main",
                table: "Delinquency");

            migrationBuilder.CreateIndex(
                name: "IX_Delinquency_EventId_PropertyId",
                schema: "main",
                table: "Delinquency",
                columns: new[] { "EventId", "PropertyId" },
                unique: true);
        }
    }
}
