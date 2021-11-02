using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeLoanTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CampaignCountyAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CampaignId = table.Column<Guid>(nullable: false),
                    CountyId = table.Column<int>(nullable: false),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCountyAudit", x => new { x.Id, x.InsertedOn });
                });

            string regenerateTriger = @"
                                    SELECT system.create_audit_triggers('main', 'Audit');
                                    ";
            migrationBuilder.Sql(regenerateTriger, true);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "NewConsolidation" });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refi" });

            migrationBuilder.InsertData(
                schema: "main",
                table: "LoanType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "RefiConsolidation" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syl" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "SylConsolidation" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignCountyAudit",
                schema: "main");

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refi" });

            migrationBuilder.UpdateData(
                schema: "main",
                table: "LoanType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "Name" },
                values: new object[] { new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consolidation" });
        }
    }
}
