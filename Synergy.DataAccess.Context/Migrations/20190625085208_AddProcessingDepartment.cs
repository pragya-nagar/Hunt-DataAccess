using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddProcessingDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "Department",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[] { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Processing", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "Department",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
