using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddGISUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GisURL",
                schema: "main",
                table: "PropertySupplementalEventDataAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GisURL",
                schema: "main",
                table: "PropertySupplementalEventData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GisURL",
                schema: "main",
                table: "PropertySupplementalEventDataAudit");

            migrationBuilder.DropColumn(
                name: "GisURL",
                schema: "main",
                table: "PropertySupplementalEventData");
        }
    }
}
