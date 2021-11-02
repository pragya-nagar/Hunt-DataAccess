using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class UpdateOpportunityStages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"UPDATE main.""Opportunity"" SET ""OpportunityStageId"" = 1 WHERE ""OpportunityStageId"" > 3;
                        UPDATE main.""OpportunityAudit"" SET ""OpportunityStageId"" = 1 WHERE ""OpportunityStageId"" > 3";
            migrationBuilder.Sql(sql, true);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "OpportunityStage",
                keyColumn: "Id",
                keyValue: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "main",
                table: "OpportunityStage",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Disclosed", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disclosed" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Processing", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Underwriting", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting" },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Approved", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Denied", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denied" },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Scheduled", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled" },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Docs Sent", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "DocsSent" },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Funded", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Funded" },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Shipping Expected", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShippingExpected" },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Completion", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completion" },
                });
        }
    }
}
