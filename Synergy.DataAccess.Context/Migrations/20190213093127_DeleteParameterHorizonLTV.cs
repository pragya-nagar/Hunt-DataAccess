using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class DeleteParameterHorizonLTV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM main.\"DataCutRuleItem\"	WHERE \"DataCutRuleFieldId\" = 13;");

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DataCutRuleField",
                keyColumn: "Id",
                keyValue: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "DataCutRuleField",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DataCutFieldTypeId", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[] { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Horizon LTV%", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "HorizonLTVPercent" });
        }
    }
}
