using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeOpportunityBorrowerDateOfBirthToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Clear old data
            var sql = @"UPDATE main.""OpportunityBorrowerBase"" SET  ""SSN""= NULL, ""DateOfBirth""= NULL";
            migrationBuilder.Sql(sql, true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                schema: "main",
                table: "OpportunityBorrowerBase",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                schema: "main",
                table: "OpportunityBorrowerBase",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
