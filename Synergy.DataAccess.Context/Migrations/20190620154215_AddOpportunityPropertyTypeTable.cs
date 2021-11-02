using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddOpportunityPropertyTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpportunityPropertyTypeId",
                schema: "main",
                table: "OpportunityAudit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpportunityPropertyTypeId",
                schema: "main",
                table: "Opportunity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OpportunityPropertyType",
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
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityPropertyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityPropertyType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityPropertyType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "OpportunityPropertyType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Residential – Owner Occupied", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ResidentialOwnerOccupied" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Residential – Non-Owner Occupied", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ResidentialNonOwnerOccupied" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial – Individually Owned", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommercialIndividuallyOwned" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial – Entity Owned", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommercialEntityOwned" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commercial - Land", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommercialLand" },
                });

            string stageSchemaSQL = @"
                                    UPDATE main.""Opportunity"" SET ""OpportunityPropertyTypeId"" = 1;
                                    UPDATE main.""OpportunityAudit"" SET ""OpportunityPropertyTypeId"" = 1;
                                    SELECT system.create_audit_triggers('main', 'Audit');
                                    ";

            migrationBuilder.Sql(stageSchemaSQL, true);

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_OpportunityPropertyTypeId",
                schema: "main",
                table: "Opportunity",
                column: "OpportunityPropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityPropertyType_CreatedById",
                schema: "main",
                table: "OpportunityPropertyType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityPropertyType_ModifiedById",
                schema: "main",
                table: "OpportunityPropertyType",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunity_OpportunityPropertyType_OpportunityPropertyType~",
                schema: "main",
                table: "Opportunity",
                column: "OpportunityPropertyTypeId",
                principalSchema: "main",
                principalTable: "OpportunityPropertyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunity_OpportunityPropertyType_OpportunityPropertyType~",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropTable(
                name: "OpportunityPropertyType",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Opportunity_OpportunityPropertyTypeId",
                schema: "main",
                table: "Opportunity");

            migrationBuilder.DropColumn(
                name: "OpportunityPropertyTypeId",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "OpportunityPropertyTypeId",
                schema: "main",
                table: "Opportunity");
        }
    }
}
