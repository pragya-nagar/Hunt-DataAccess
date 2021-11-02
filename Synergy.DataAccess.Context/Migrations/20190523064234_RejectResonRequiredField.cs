using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class RejectResonRequiredField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRejectReasonRequired",
                schema: "main",
                table: "EventAudit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRejectReasonRequired",
                schema: "main",
                table: "Event",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRejectReasonRequired",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "IsRejectReasonRequired",
                schema: "main",
                table: "Event");
        }
    }
}
