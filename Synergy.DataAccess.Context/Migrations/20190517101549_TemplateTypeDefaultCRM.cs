using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class TemplateTypeDefaultCRM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "TemplateType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "GroupingType", "ModifiedById", "ModifiedOn", "ModuleId", "Name" },
                values: new object[] { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "TemplateType",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
