using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class UpdateTriggers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SELECT system.create_audit_triggers('main', 'Audit');", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
