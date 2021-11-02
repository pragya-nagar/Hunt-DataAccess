using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddIndexDelinquencyIdPropertyProfileId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyProfileDelinquency_DelinquencyId",
                schema: "main",
                table: "PropertyProfileDelinquency");

            migrationBuilder.InsertData(
                schema: "main",
                table: "Department",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[] { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Underwriting", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting" });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DepartmentRole",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "IsManager", "ModifiedById", "ModifiedOn", "RoleId" },
                values: new object[,]
                {
                    { new Guid("00dbcc54-a127-4e23-a1ac-4a8b8492cb00"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { new Guid("00c64245-62a6-4bf2-8648-7d19aa83af00"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileDelinquency_DelinquencyId_PropertyProfileId",
                schema: "main",
                table: "PropertyProfileDelinquency",
                columns: new[] { "DelinquencyId", "PropertyProfileId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyProfileDelinquency_DelinquencyId_PropertyProfileId",
                schema: "main",
                table: "PropertyProfileDelinquency");

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("00c64245-62a6-4bf2-8648-7d19aa83af00"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("00dbcc54-a127-4e23-a1ac-4a8b8492cb00"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Department",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileDelinquency_DelinquencyId",
                schema: "main",
                table: "PropertyProfileDelinquency",
                column: "DelinquencyId");
        }
    }
}
