using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeDelinquencyTableAddIsLoanAndAddLoanOfficersDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLoan",
                schema: "main",
                table: "DelinquencyAudit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLoan",
                schema: "main",
                table: "Delinquency",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "main",
                table: "Department",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[] { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Loan Officers", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loan Officers" });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DepartmentRole",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "IsManager", "ModifiedById", "ModifiedOn", "RoleId" },
                values: new object[,]
                {
                    { new Guid("ab40020d-42cf-45f0-9704-fb28ea83b250"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { new Guid("a574d65d-273b-4a1b-9ff4-b59a1dc175b7"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("a574d65d-273b-4a1b-9ff4-b59a1dc175b7"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("ab40020d-42cf-45f0-9704-fb28ea83b250"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Department",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "IsLoan",
                schema: "main",
                table: "DelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "IsLoan",
                schema: "main",
                table: "Delinquency");
        }
    }
}
