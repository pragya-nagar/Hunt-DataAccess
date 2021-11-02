using System;

using Microsoft.EntityFrameworkCore.Migrations;

using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class MailMergeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Module",
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
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Module_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Module_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TemplateFileAudit",
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
                    FileId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TemplateTypeId = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateFileAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TemplateFileCountyAudit",
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
                    TemplateFileId = table.Column<Guid>(nullable: false),
                    CountyId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateFileCountyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TemplateTypeAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TemplateType",
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
                    ModuleId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateType_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalSchema: "main",
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateFile",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    FileId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TemplateTypeId = table.Column<int>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateFile_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateFile_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateFile_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateFile_TemplateType_TemplateTypeId",
                        column: x => x.TemplateTypeId,
                        principalSchema: "main",
                        principalTable: "TemplateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateFileCounty",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    TemplateFileId = table.Column<Guid>(nullable: false),
                    CountyId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateFileCounty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateFileCounty_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "main",
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateFileCounty_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateFileCounty_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateFileCounty_TemplateFile_TemplateFileId",
                        column: x => x.TemplateFileId,
                        principalSchema: "main",
                        principalTable: "TemplateFile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Module",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9867), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9869), "Underwriting" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9895), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 869, DateTimeKind.Utc).AddTicks(9895), "CRM" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TemplateType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "ModuleId", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5046), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5047), 1, "Pre-Sale Letters" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5124), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5126), 1, "Post-sale Letters" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5130), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 4, 24, 12, 2, 15, 877, DateTimeKind.Utc).AddTicks(5131), 1, "Certificates" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_Module_CreatedById",
                schema: "main",
                table: "Module",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Module_ModifiedById",
                schema: "main",
                table: "Module",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFile_CreatedById",
                schema: "main",
                table: "TemplateFile",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFile_ModifiedById",
                schema: "main",
                table: "TemplateFile",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFile_StateId",
                schema: "main",
                table: "TemplateFile",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFile_TemplateTypeId",
                schema: "main",
                table: "TemplateFile",
                column: "TemplateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFileCounty_CountyId",
                schema: "main",
                table: "TemplateFileCounty",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFileCounty_CreatedById",
                schema: "main",
                table: "TemplateFileCounty",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFileCounty_ModifiedById",
                schema: "main",
                table: "TemplateFileCounty",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateFileCounty_TemplateFileId_CountyId",
                schema: "main",
                table: "TemplateFileCounty",
                columns: new[] { "TemplateFileId", "CountyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TemplateType_CreatedById",
                schema: "main",
                table: "TemplateType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateType_ModifiedById",
                schema: "main",
                table: "TemplateType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateType_ModuleId",
                schema: "main",
                table: "TemplateType",
                column: "ModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TemplateFileAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TemplateFileCounty",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TemplateFileCountyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TemplateTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TemplateFile",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TemplateType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Module",
                schema: "main");
        }
    }
}
