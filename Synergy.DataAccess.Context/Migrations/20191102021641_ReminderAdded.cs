using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ReminderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reminder",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: true),
                    OpportunityId = table.Column<Guid>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SheduledDate = table.Column<DateTime>(nullable: false),
                    SheduledTime = table.Column<TimeSpan>(nullable: false),
                    IsPushNotification = table.Column<bool>(nullable: true),
                    IsEmailNotification = table.Column<bool>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    IsRead = table.Column<bool>(nullable: true),
                    InstantPushNotificationSentDateTime = table.Column<DateTime>(nullable: true),
                    PushNotificationSentDateTime = table.Column<DateTime>(nullable: true),
                    EmailNotificationSentDateTime = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminder_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reminder_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reminder_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReminderAudit",
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
                    UserId = table.Column<Guid>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: true),
                    OpportunityId = table.Column<Guid>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SheduledDate = table.Column<DateTime>(nullable: false),
                    SheduledTime = table.Column<TimeSpan>(nullable: false),
                    IsPushNotification = table.Column<bool>(nullable: true),
                    IsEmailNotification = table.Column<bool>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    IsRead = table.Column<bool>(nullable: true),
                    InstantPushNotificationSentDateTime = table.Column<DateTime>(nullable: true),
                    PushNotificationSentDateTime = table.Column<DateTime>(nullable: true),
                    EmailNotificationSentDateTime = table.Column<DateTime>(nullable: true),
                    InsertedBy = table.Column<Guid>(nullable: false),
                    OperationId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReminderAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_CreatedById",
                schema: "main",
                table: "Reminder",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_ModifiedById",
                schema: "main",
                table: "Reminder",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_UserId",
                schema: "main",
                table: "Reminder",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminder",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ReminderAudit",
                schema: "main");
        }
    }
}
