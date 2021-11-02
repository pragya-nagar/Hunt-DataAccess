using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeCampaignTableAddStateAndMultyCounty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaign_County_CountyId",
                schema: "main",
                table: "Campaign");

            migrationBuilder.RenameColumn(
                name: "CountyId",
                schema: "main",
                table: "CampaignAudit",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "CountyId",
                schema: "main",
                table: "Campaign",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Campaign_CountyId",
                schema: "main",
                table: "Campaign",
                newName: "IX_Campaign_StateId");

            migrationBuilder.CreateTable(
                name: "CampaignCounty",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CampaignId = table.Column<Guid>(nullable: false),
                    CountyId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCounty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignCounty_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalSchema: "main",
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignCounty_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "main",
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignCounty_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignCounty_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            string regenerateTriger = @"
                                    SELECT system.create_audit_triggers('main', 'Audit');
                                    ";
            migrationBuilder.Sql(regenerateTriger, true);

            string stageSchemaSQL = @"
                                    UPDATE main.""Campaign"" SET ""StateId"" = 1;
                                    ";
            migrationBuilder.Sql(stageSchemaSQL, true);

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCounty_CampaignId",
                schema: "main",
                table: "CampaignCounty",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCounty_CountyId",
                schema: "main",
                table: "CampaignCounty",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCounty_CreatedById",
                schema: "main",
                table: "CampaignCounty",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCounty_ModifiedById",
                schema: "main",
                table: "CampaignCounty",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaign_State_StateId",
                schema: "main",
                table: "Campaign",
                column: "StateId",
                principalSchema: "main",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaign_State_StateId",
                schema: "main",
                table: "Campaign");

            migrationBuilder.DropTable(
                name: "CampaignCounty",
                schema: "main");

            migrationBuilder.RenameColumn(
                name: "StateId",
                schema: "main",
                table: "CampaignAudit",
                newName: "CountyId");

            migrationBuilder.RenameColumn(
                name: "StateId",
                schema: "main",
                table: "Campaign",
                newName: "CountyId");

            migrationBuilder.RenameIndex(
                name: "IX_Campaign_StateId",
                schema: "main",
                table: "Campaign",
                newName: "IX_Campaign_CountyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaign_County_CountyId",
                schema: "main",
                table: "Campaign",
                column: "CountyId",
                principalSchema: "main",
                principalTable: "County",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
