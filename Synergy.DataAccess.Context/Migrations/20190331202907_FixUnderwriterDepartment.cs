using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class FixUnderwriterDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "main",
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ModifiedOn", "Name" },
                values: new object[] { "Underwriters", new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriters" });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinitionDepartment",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "ModifiedById", "ModifiedOn", "OriginalId", "TaskDefinitionId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0001-0001-00000000000e"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-00000000000e") },
                    { new Guid("00000000-0000-0001-0001-00000000000f"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-00000000000f") },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinitionDepartment",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0001-0001-00000000000e"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "TaskDefinitionDepartment",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0001-0001-00000000000f"));

            migrationBuilder.UpdateData(
                schema: "main",
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ModifiedOn", "Name" },
                values: new object[] { "Underwriting", new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting" });
        }
    }
}
