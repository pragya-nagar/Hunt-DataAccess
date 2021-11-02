using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class OpportunityAndLeadSourceUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentMilestone",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentMilestone",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeadSourceId",
                schema: "main",
                table: "LeadAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeadSourceId",
                schema: "main",
                table: "Lead",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LeadSourceType",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LeadSource = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSourceType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadSourceType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadSourceType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "LeadSourceType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "LeadSource", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Internet", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Mailer", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Outbound Call", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Outbound Email", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Referral", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Previous Inbound", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Current Inbound", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified), null, "Commercial Trip", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 10, 11, 16, 0, 39, 0, DateTimeKind.Unspecified) },
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lead_LeadSourceId",
                schema: "main",
                table: "Lead",
                column: "LeadSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadSourceType_CreatedById",
                schema: "main",
                table: "LeadSourceType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeadSourceType_ModifiedById",
                schema: "main",
                table: "LeadSourceType",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Lead_LeadSourceType_LeadSourceId",
                schema: "main",
                table: "Lead",
                column: "LeadSourceId",
                principalSchema: "main",
                principalTable: "LeadSourceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lead_LeadSourceType_LeadSourceId",
                schema: "main",
                table: "Lead");

            migrationBuilder.DropTable(
                name: "LeadSourceType",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Lead_LeadSourceId",
                schema: "main",
                table: "Lead");

            migrationBuilder.DropColumn(
                name: "CurrentMilestone",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "CurrentMilestone",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "LeadSourceId",
                schema: "main",
                table: "LeadAudit");

            migrationBuilder.DropColumn(
                name: "LeadSourceId",
                schema: "main",
                table: "Lead");
        }
    }
}
