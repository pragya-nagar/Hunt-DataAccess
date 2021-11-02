using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class FixDispositionStrategySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "PropertyDisplayStrategy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "FORECLOSURE IMMEDIATELY", "ForeclosureImmediately" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "PropertyDisplayStrategy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "FORECLOSRE IMMEDIATELY", "ForeclorseImmediately" });
        }
    }
}
