using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddBorrowerMarriedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Married",
                schema: "main",
                table: "BorrowerAudit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Married",
                schema: "main",
                table: "Borrower",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Married",
                schema: "main",
                table: "BorrowerAudit");

            migrationBuilder.DropColumn(
                name: "Married",
                schema: "main",
                table: "Borrower");
        }
    }
}
