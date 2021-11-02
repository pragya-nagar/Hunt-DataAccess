using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddRolesAndEventUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_User_AccountingUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_User_AcquizitionUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_User_AssetManagementUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_User_DataUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_User_ManagementUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_AccountingUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_AcquizitionUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_AssetManagementUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_DataUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_ManagementUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "AccountingUserId",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "AcquizitionUserId",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "AssetManagementUserId",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "DataUserId",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "ManagementUserId",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "AccountingUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "AcquizitionUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "AssetManagementUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "DataUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ManagementUserId",
                schema: "main",
                table: "Event");

            migrationBuilder.CreateTable(
                name: "EventUser",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    EventId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventUser_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUser_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "main",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUser_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUser_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventUserAudit",
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
                    EventId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUserAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Role",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("20027277-8151-4ef3-85be-897d55299fd0"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounting", null },
                    { new Guid("df712225-1e14-472e-b9b9-bef411113663"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounting Manager", null },
                    { new Guid("eb9745bd-1285-440d-b5d8-c35370b38906"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asset Management", null },
                    { new Guid("2fbbc95e-576c-4acb-b811-e1e1eca5c76a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asset Management Manager", null },
                    { new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Management", null },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DepartmentRole",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "IsManager", "ModifiedById", "ModifiedOn", "RoleId" },
                values: new object[,]
                {
                    { new Guid("8226a4b3-bcf2-481d-94d6-9edd181f3c0a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20027277-8151-4ef3-85be-897d55299fd0") },
                    { new Guid("c08c5ca6-1761-403b-84a3-169118e8d1e9"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df712225-1e14-472e-b9b9-bef411113663") },
                    { new Guid("35dbcc54-a127-4e23-a1ac-4a8b8492cb9f"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb9745bd-1285-440d-b5d8-c35370b38906") },
                    { new Guid("96c64245-62a6-4bf2-8648-7d19aa83afed"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2fbbc95e-576c-4acb-b811-e1e1eca5c76a") },
                    { new Guid("5ec63add-d3ad-452d-bf83-6d09f77a8757"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649") },
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_CreatedById",
                schema: "main",
                table: "EventUser",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_DepartmentId",
                schema: "main",
                table: "EventUser",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_EventId",
                schema: "main",
                table: "EventUser",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_ModifiedById",
                schema: "main",
                table: "EventUser",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_UserId",
                schema: "main",
                table: "EventUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventUser",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventUserAudit",
                schema: "main");

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("35dbcc54-a127-4e23-a1ac-4a8b8492cb9f"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("5ec63add-d3ad-452d-bf83-6d09f77a8757"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("8226a4b3-bcf2-481d-94d6-9edd181f3c0a"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("96c64245-62a6-4bf2-8648-7d19aa83afed"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "DepartmentRole",
                keyColumn: "Id",
                keyValue: new Guid("c08c5ca6-1761-403b-84a3-169118e8d1e9"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("20027277-8151-4ef3-85be-897d55299fd0"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2fbbc95e-576c-4acb-b811-e1e1eca5c76a"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("df712225-1e14-472e-b9b9-bef411113663"));

            migrationBuilder.DeleteData(
                schema: "main",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("eb9745bd-1285-440d-b5d8-c35370b38906"));

            migrationBuilder.AddColumn<Guid>(
                name: "AccountingUserId",
                schema: "main",
                table: "EventAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AcquizitionUserId",
                schema: "main",
                table: "EventAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssetManagementUserId",
                schema: "main",
                table: "EventAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DataUserId",
                schema: "main",
                table: "EventAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManagementUserId",
                schema: "main",
                table: "EventAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AccountingUserId",
                schema: "main",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AcquizitionUserId",
                schema: "main",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssetManagementUserId",
                schema: "main",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DataUserId",
                schema: "main",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManagementUserId",
                schema: "main",
                table: "Event",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_AccountingUserId",
                schema: "main",
                table: "Event",
                column: "AccountingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AcquizitionUserId",
                schema: "main",
                table: "Event",
                column: "AcquizitionUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AssetManagementUserId",
                schema: "main",
                table: "Event",
                column: "AssetManagementUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_DataUserId",
                schema: "main",
                table: "Event",
                column: "DataUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ManagementUserId",
                schema: "main",
                table: "Event",
                column: "ManagementUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_User_AccountingUserId",
                schema: "main",
                table: "Event",
                column: "AccountingUserId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_User_AcquizitionUserId",
                schema: "main",
                table: "Event",
                column: "AcquizitionUserId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_User_AssetManagementUserId",
                schema: "main",
                table: "Event",
                column: "AssetManagementUserId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_User_DataUserId",
                schema: "main",
                table: "Event",
                column: "DataUserId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_User_ManagementUserId",
                schema: "main",
                table: "Event",
                column: "ManagementUserId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
