using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class UpdateAddedMonthlyAndPecentageFieldInOpportunity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonthlyPrepay",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PercentagePrepay",
                schema: "main",
                table: "OpportunityAudit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPrepay",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PercentagePrepay",
                schema: "main",
                table: "Opportunity",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OpportunityMonthlyPrepay",
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
                    MonthlyPrepay = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityMonthlyPrepay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityMonthlyPrepay_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityMonthlyPrepay_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityPercentagePrepay",
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
                    PercentagePrepay = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityPercentagePrepay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityPercentagePrepay_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityPercentagePrepay_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "OpportunityMonthlyPrepay",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "MonthlyPrepay" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "OpportunityPercentagePrepay",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PercentagePrepay" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.5m },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.0m },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.5m },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.0m },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5m },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0m },
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityMonthlyPrepay_CreatedById",
                schema: "main",
                table: "OpportunityMonthlyPrepay",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityMonthlyPrepay_ModifiedById",
                schema: "main",
                table: "OpportunityMonthlyPrepay",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityPercentagePrepay_CreatedById",
                schema: "main",
                table: "OpportunityPercentagePrepay",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityPercentagePrepay_ModifiedById",
                schema: "main",
                table: "OpportunityPercentagePrepay",
                column: "ModifiedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpportunityMonthlyPrepay",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityPercentagePrepay",
                schema: "main");

            migrationBuilder.DropColumn(
                name: "MonthlyPrepay",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "PercentagePrepay",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "MonthlyPrepay",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "PercentagePrepay",
                schema: "main",
                table: "Opportunity");
        }
    }
}
