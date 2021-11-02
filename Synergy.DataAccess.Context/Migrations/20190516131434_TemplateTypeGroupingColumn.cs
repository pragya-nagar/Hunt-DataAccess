using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class TemplateTypeGroupingColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupingType",
                schema: "main",
                table: "TemplateTypeAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupingType",
                schema: "main",
                table: "TemplateType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupingType",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GroupingType", "Name" },
                values: new object[] { 1, "Post-Sale Letters" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupingType",
                schema: "main",
                table: "TemplateTypeAudit");

            migrationBuilder.DropColumn(
                name: "GroupingType",
                schema: "main",
                table: "TemplateType");

            migrationBuilder.UpdateData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Post-sale Letters");
        }
    }
}
