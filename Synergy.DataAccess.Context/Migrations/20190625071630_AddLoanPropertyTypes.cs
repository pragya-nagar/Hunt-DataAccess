using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddLoanPropertyTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "LoanPropertyType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "LoanId", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Residential – Owner Occupied", null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ResidentialOwnerOccupied" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Residential – Non-Owner Occupied", null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ResidentialNonOwnerOccupied" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial – Individually Owned", null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommercialIndividuallyOwned" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial – Entity Owned", null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommercialEntityOwned" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial - Land", null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommercialLand" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanPropertyType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanPropertyType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanPropertyType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanPropertyType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanPropertyType",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
