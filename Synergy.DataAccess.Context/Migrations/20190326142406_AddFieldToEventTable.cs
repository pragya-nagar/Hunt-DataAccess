using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddFieldToEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFreezed",
                schema: "main",
                table: "EventAudit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFreezed",
                schema: "main",
                table: "Event",
                nullable: false,
                defaultValue: false);

            string sqlScript = @"SELECT system.create_audit_triggers('main', 'Audit', 'InsertedOn')";
            migrationBuilder.Sql(sqlScript, true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFreezed",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "IsFreezed",
                schema: "main",
                table: "Event");
        }
    }
}
