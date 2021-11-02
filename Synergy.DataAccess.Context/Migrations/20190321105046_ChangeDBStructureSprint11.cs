using System;

using Microsoft.EntityFrameworkCore.Migrations;

using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class ChangeDBStructureSprint11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Event_EventId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskStatus_TaskStatusId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskType_TaskTypeId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_UserId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropTable(
                name: "TaskAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskStatus",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskStatusAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskTypeAudit",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Task_TaskStatusId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_TaskTypeId",
                schema: "main",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "main",
                table: "Task",
                newName: "WorkflowId");

            migrationBuilder.RenameColumn(
                name: "TaskTypeId",
                schema: "main",
                table: "Task",
                newName: "WorkflowType");

            migrationBuilder.RenameColumn(
                name: "TaskStatusId",
                schema: "main",
                table: "Task",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "EventId",
                schema: "main",
                table: "Task",
                newName: "TaskDefinitionId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_UserId",
                schema: "main",
                table: "Task",
                newName: "IX_Task_WorkflowId2");

            migrationBuilder.RenameIndex(
                name: "IX_Task_EventId",
                schema: "main",
                table: "Task",
                newName: "IX_Task_TaskDefinitionId2");

            migrationBuilder.CreateSequence(
                name: "EntityFrameworkHiLoSequence",
                schema: "main",
                incrementBy: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "main",
                table: "Task",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                schema: "main",
                table: "Task",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                schema: "main",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EventDecisionLevelPropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelUserAudit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EventDecisionLevelPropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelUser",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Department",
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
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Department_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentAudit",
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
                    InsertedOn = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentRoleAudit",
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
                    RoleId = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    IsManager = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentRoleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EtlDelinquency",
                schema: "main",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtlDelinquency", x => new { x.DelinquencyId, x.EventId });
                    table.ForeignKey(
                        name: "FK_EtlDelinquency_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtlDelinquency_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDecisionLevelPropertyProfileAudit",
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
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                    EventDecisionLevelId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecisionLevelPropertyProfileAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "NotificationMessages",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    EntityId = table.Column<Guid>(nullable: false),
                    TypeIdentifier = table.Column<string>(nullable: true),
                    Metadata = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationMessages_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationMessages_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SequenceHiLo),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionAudit",
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
                    Action = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfile",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfile_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfile_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileAudit",
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
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileDelinquencyAudit",
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
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileDelinquencyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileFieldType",
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
                    table.PrimaryKey("PK_PropertyProfileFieldType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileFieldType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileFieldType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileFieldTypeAudit",
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
                    Description = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileFieldTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileLogicTypeAudit",
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
                    Description = table.Column<string>(nullable: true),
                    PropertyProfileFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileLogicTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRule",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRule_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRule_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleAudit",
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
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleFieldAudit",
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
                    Description = table.Column<string>(nullable: true),
                    PropertyProfileFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleFieldAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleItemAudit",
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
                    PropertyProfileRuleId = table.Column<Guid>(nullable: false),
                    PropertyProfileLogicTypeId = table.Column<int>(nullable: false),
                    PropertyProfileRuleFieldId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleItemAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleItemValueAudit",
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
                    Value = table.Column<string>(nullable: true),
                    PropertyProfileRuleItemId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleItemValueAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRulePropertyProfileAudit",
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
                    PropertyProfileRuleId = table.Column<Guid>(nullable: false),
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRulePropertyProfileAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileStateAudit",
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
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileStateAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "RoleAudit",
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
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "RolePermissionAudit",
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
                    RoleId = table.Column<Guid>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissionAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TaskDefinition",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TriggerDayOffset = table.Column<int>(nullable: false, defaultValue: 0),
                    TriggerSourceTypeId = table.Column<int>(nullable: false, defaultValue: 1),
                    LogicTypeId = table.Column<int>(nullable: true),
                    NotificationType = table.Column<int>(nullable: false, defaultValue: 0),
                    OriginalId = table.Column<Guid>(nullable: true),
                    WorkflowType = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDefinition_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinition_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskUser",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    TaskId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CompletedDate = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskUser_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskUser_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskUser_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "main",
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPermissionAudit",
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
                    UserId = table.Column<Guid>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissionAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "UserRoleAudit",
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
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "WorkflowDefinition",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OriginalId = table.Column<Guid>(nullable: true),
                    WorkflowType = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowDefinition_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkflowDefinition_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PermissionId = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Role_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "main",
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPermission",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermission_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermission_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "main",
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermission_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDecisionLevelPropertyProfile",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                    EventDecisionLevelId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecisionLevelPropertyProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelPropertyProfile_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelPropertyProfile_EventDecisionLevel_EventD~",
                        column: x => x.EventDecisionLevelId,
                        principalSchema: "main",
                        principalTable: "EventDecisionLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelPropertyProfile_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelPropertyProfile_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelPropertyProfile_PropertyProfile_PropertyP~",
                        column: x => x.PropertyProfileId,
                        principalSchema: "main",
                        principalTable: "PropertyProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileDelinquency",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileDelinquency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileDelinquency_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileDelinquency_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileDelinquency_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileDelinquency_PropertyProfile_PropertyProfileId",
                        column: x => x.PropertyProfileId,
                        principalSchema: "main",
                        principalTable: "PropertyProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileState",
                schema: "main",
                columns: table => new
                {
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileState", x => new { x.PropertyProfileId, x.StateId });
                    table.ForeignKey(
                        name: "FK_PropertyProfileState_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileState_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileState_PropertyProfile_PropertyProfileId",
                        column: x => x.PropertyProfileId,
                        principalSchema: "main",
                        principalTable: "PropertyProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileState_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileLogicType",
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
                    PropertyProfileFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileLogicType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileLogicType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileLogicType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileLogicType_PropertyProfileFieldType_PropertyP~",
                        column: x => x.PropertyProfileFieldTypeId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileFieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleField",
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
                    PropertyProfileFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleField_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleField_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleField_PropertyProfileFieldType_PropertyP~",
                        column: x => x.PropertyProfileFieldTypeId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileFieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRulePropertyProfile",
                schema: "main",
                columns: table => new
                {
                    PropertyProfileRuleId = table.Column<Guid>(nullable: false),
                    PropertyProfileId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRulePropertyProfile", x => new { x.PropertyProfileRuleId, x.PropertyProfileId });
                    table.ForeignKey(
                        name: "FK_PropertyProfileRulePropertyProfile_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRulePropertyProfile_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRulePropertyProfile_PropertyProfile_Property~",
                        column: x => x.PropertyProfileId,
                        principalSchema: "main",
                        principalTable: "PropertyProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRulePropertyProfile_PropertyProfileRule_Prop~",
                        column: x => x.PropertyProfileRuleId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskDefinitionDepartment",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    TaskDefinitionId = table.Column<Guid>(nullable: false),
                    OriginalId = table.Column<Guid>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDefinitionDepartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionDepartment_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "main",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionDepartment_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionDepartment_TaskDefinition_TaskDefinitionId",
                        column: x => x.TaskDefinitionId,
                        principalSchema: "main",
                        principalTable: "TaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskDefinitionUser",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    TaskDefinitionId = table.Column<Guid>(nullable: false),
                    OriginalId = table.Column<Guid>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDefinitionUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionUser_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionUser_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionUser_TaskDefinition_TaskDefinitionId",
                        column: x => x.TaskDefinitionId,
                        principalSchema: "main",
                        principalTable: "TaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskDefinitionUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessingWorkflowTaskDefinition",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    WorkflowDefinitionId = table.Column<Guid>(nullable: false),
                    TaskDefinitionId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    DependencyTypeId = table.Column<int>(nullable: false, defaultValue: 1),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessingWorkflowTaskDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDefinition_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDefinition_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDefinition_TaskDefinition_TaskDefinit~",
                        column: x => x.TaskDefinitionId,
                        principalSchema: "main",
                        principalTable: "TaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDefinition_WorkflowDefinition_Workflo~",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicingWorkflowTaskDefinition",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    WorkflowDefinitionId = table.Column<Guid>(nullable: false),
                    TaskDefinitionId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    DependencyTypeId = table.Column<int>(nullable: false, defaultValue: 1),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicingWorkflowTaskDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDefinition_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDefinition_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDefinition_TaskDefinition_TaskDefiniti~",
                        column: x => x.TaskDefinitionId,
                        principalSchema: "main",
                        principalTable: "TaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDefinition_WorkflowDefinition_Workflow~",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnderwritingWorkflowDefinitionEventType",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    EventTypeId = table.Column<int>(nullable: false),
                    WorkflowDefinitionId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderwritingWorkflowDefinitionEventType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionEventType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionEventType_EventType_EventType~",
                        column: x => x.EventTypeId,
                        principalSchema: "main",
                        principalTable: "EventType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionEventType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionEventType_WorkflowDefinition_~",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnderwritingWorkflowDefinitionState",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    WorkflowDefinitionId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderwritingWorkflowDefinitionState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionState_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionState_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionState_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowDefinitionState_WorkflowDefinition_Work~",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnderwritingWorkflowTaskDefinition",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    WorkflowDefinitionId = table.Column<Guid>(nullable: false),
                    TaskDefinitionId = table.Column<Guid>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    DependencyTypeId = table.Column<int>(nullable: false, defaultValue: 1),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderwritingWorkflowTaskDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDefinition_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDefinition_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDefinition_TaskDefinition_TaskDefin~",
                        column: x => x.TaskDefinitionId,
                        principalSchema: "main",
                        principalTable: "TaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDefinition_WorkflowDefinition_Workf~",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    WorkflowDefinitionId = table.Column<Guid>(nullable: false),
                    WorkflowType = table.Column<int>(nullable: false),
                    EventId = table.Column<Guid>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workflow_WorkflowDefinition_WorkflowDefinitionId",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workflow_WorkflowDefinition_WorkflowDefinitionId1",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workflow_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workflow_WorkflowDefinition_WorkflowDefinitionId2",
                        column: x => x.WorkflowDefinitionId,
                        principalSchema: "main",
                        principalTable: "WorkflowDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workflow_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workflow_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentRole",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    IsManager = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentRole_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentRole_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "main",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentRole_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "main",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
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
                    RoleId = table.Column<Guid>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermission_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "main",
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "main",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "main",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleItem",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    PropertyProfileRuleId = table.Column<Guid>(nullable: false),
                    PropertyProfileLogicTypeId = table.Column<int>(nullable: false),
                    PropertyProfileRuleFieldId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItem_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItem_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItem_PropertyProfileLogicType_PropertyPr~",
                        column: x => x.PropertyProfileLogicTypeId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileLogicType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItem_PropertyProfileRuleField_PropertyPr~",
                        column: x => x.PropertyProfileRuleFieldId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileRuleField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItem_PropertyProfileRule_PropertyProfile~",
                        column: x => x.PropertyProfileRuleId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessingWorkflowTaskDependency",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DependentId = table.Column<Guid>(nullable: false),
                    DependencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessingWorkflowTaskDependency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDependency_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDependency_ProcessingWorkflowTaskDefi~",
                        column: x => x.DependencyId,
                        principalSchema: "main",
                        principalTable: "ProcessingWorkflowTaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDependency_ProcessingWorkflowTaskDef~1",
                        column: x => x.DependentId,
                        principalSchema: "main",
                        principalTable: "ProcessingWorkflowTaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcessingWorkflowTaskDependency_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicingWorkflowTaskDependency",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DependentId = table.Column<Guid>(nullable: false),
                    DependencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicingWorkflowTaskDependency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDependency_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDependency_ServicingWorkflowTaskDefini~",
                        column: x => x.DependencyId,
                        principalSchema: "main",
                        principalTable: "ServicingWorkflowTaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDependency_ServicingWorkflowTaskDefin~1",
                        column: x => x.DependentId,
                        principalSchema: "main",
                        principalTable: "ServicingWorkflowTaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicingWorkflowTaskDependency_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnderwritingWorkflowTaskDependency",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DependentId = table.Column<Guid>(nullable: false),
                    DependencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderwritingWorkflowTaskDependency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDependency_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDependency_UnderwritingWorkflowTask~",
                        column: x => x.DependencyId,
                        principalSchema: "main",
                        principalTable: "UnderwritingWorkflowTaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDependency_UnderwritingWorkflowTas~1",
                        column: x => x.DependentId,
                        principalSchema: "main",
                        principalTable: "UnderwritingWorkflowTaskDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderwritingWorkflowTaskDependency_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProfileRuleItemValue",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    PropertyProfileRuleItemId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProfileRuleItemValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItemValue_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItemValue_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProfileRuleItemValue_PropertyProfileRuleItem_Proper~",
                        column: x => x.PropertyProfileRuleItemId,
                        principalSchema: "main",
                        principalTable: "PropertyProfileRuleItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Department",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Data", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Accounting", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accounting" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Management", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Management" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Acquisition", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acquisition" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Asset Management", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asset Management" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Permission",
                columns: new[] { "Id", "Action", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn" },
                values: new object[,]
                {
                    { 24, "Underwriting.EventAssignment.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Underwriting.EventDataCut.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Underwriting.EventDataCut.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Underwriting.EventBidList.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Underwriting.EventBidList.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Underwriting.EventBidList.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Underwriting.EventResultsUpload.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Underwriting.ReviewPage.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Underwriting.ReviewPage.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Underwriting.Attachments.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Underwriting.ReviewComments.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Underwriting.EventAssignment.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Underwriting.Attachments.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Underwriting.PropertyProfile.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Underwriting.PropertyProfile.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Workflow.TaskType.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Workflow.TaskType.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Workflow.WorkflowType.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Workflow.WorkflowType.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Underwriting.ReviewComments.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Underwriting.EventDataDump.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Underwriting.Attachments.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Underwriting.Event.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "Landing.Dashboard.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "CRM.Dashboard.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "CRM.Records.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "CRM.Properties.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "CRM.Opportunities.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "CRM.Opportunities.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "CRM.SensitiveData.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "CRM.SensitiveData.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "CRM.Contacts.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Underwriting.Event.Lock", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "CRM.Contacts.Delete", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "CRM.Campaigns.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "CRM.Campaigns.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "CRM.CampaignsDataDump.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "CRM.CampaignComments.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "CRM.CampaignComments.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "CRM.RecordComments.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "CRM.RecordComments.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Underwriting.Event.Read", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "CRM.Contacts.Write", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "PropertyProfileFieldType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Multiple Value", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "MultipleValue" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Numeric", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numeric" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "Role",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting", null },
                    { new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Manager", null },
                    { new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting Manager", null },
                    { new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audit", null },
                    { new Guid("046fe758-8915-4697-8d97-26024d0357ed"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loan Officer", null },
                    { new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acquisition Manager", null },
                    { new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acquisition", null },
                    { new Guid("0648e7b1-f99e-415d-8055-3978690cbc48"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data", null },
                    { new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loan Officer Manager", null },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinition",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "IsActive", "LogicTypeId", "ModifiedById", "ModifiedOn", "Name", "NotificationType", "OriginalId", "TriggerDayOffset", "TriggerSourceTypeId", "WorkflowType" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0001-000000000014"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 20, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Create Workset", 3, null, 2, 2, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000013"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 19, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Import Results", 3, null, 1, 2, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000012"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 18, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Funding", 3, null, 0, 2, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000011"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 17, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prepare Bid File", 3, null, -3, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000010"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 16, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lock Event", 3, null, -3, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-00000000000f"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Round Review", 3, null, -4, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-00000000000e"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N Round Review", 3, null, -6, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-00000000000d"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assign Reviewer", 3, null, -10, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-00000000000c"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Import Inspections", 3, null, -10, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-00000000000b"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Order Inspections", 3, null, -21, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000009"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pre Lim List (Mail Merge)", 3, null, -40, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000008"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Filters", 3, null, -40, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000007"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Import Data", 3, null, -40, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000006"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supplemental Data", 3, null, -45, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000005"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Run Data Macro", 3, null, -45, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deposit", 3, null, -45, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Registration", 3, null, -45, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upload Delinquent Listing", 3, null, -45, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enter Sale Info", 3, null, -45, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000015"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 21, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Certificates (Mail Merge)", 3, null, -45, 2, 1 },
                    { new Guid("00000000-0000-0000-0001-00000000000a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pre-Sale Letters", 3, null, -35, 1, 1 },
                    { new Guid("00000000-0000-0000-0001-000000000016"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, 22, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post-Sale Letters (Mail Merge)", 3, null, -45, 2, 1 },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DepartmentRole",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "IsManager", "ModifiedById", "ModifiedOn", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4652ba7a-dfef-405d-b0f5-c5e1d7597e04"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { new Guid("5eea7407-38cb-4653-acc8-cc751ea079c2"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { new Guid("cc75b207-c5be-459e-a005-8a805c9604af"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, true, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { new Guid("0e29d810-1756-4c6a-ba5a-7e53368b7d76"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "PropertyProfileLogicType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name", "PropertyProfileFieldTypeId" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Include", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Include", 1 },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Exclude", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exclude", 1 },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Less Than", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "LessThan", 2 },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Less Than Or Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "LessThanOrEqual", 2 },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Greater Than", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "GreaterThan", 2 },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Greater Than Or Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "GreaterThanOrEqual", 2 },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "PropertyProfileRuleField",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name", "PropertyProfileFieldTypeId" },
                values: new object[,]
                {
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RU LTV%", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "RULTV", 2 },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LTV %", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "LTV", 2 },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Assessed Value", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assessed Value", 2 },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Total Due Amount", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Total Due Amount", 2 },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Land Use Codes", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Land Use Codes", 1 },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Internal Land Use Code", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal Land Use Code", 1 },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "General Land Use Code", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Land Use Code", 1 },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "RolePermission",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 144, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 146, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 77, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 92, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 98, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 145, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 124, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 127, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 133, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 136, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 142, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 141, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 147, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 102, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2") },
                    { 135, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 62, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 126, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 18, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 28, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 31, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 35, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 37, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 41, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 44, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 46, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 50, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 52, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 53, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 57, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 66, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 71, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 76, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 123, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 132, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a") },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 48, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 16, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 120, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 129, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 138, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 19, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 24, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 116, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 29, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 51, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 58, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 67, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 78, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 125, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 134, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 143, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 42, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9") },
                    { 112, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 108, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 104, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 21, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 26, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 33, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 39, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 55, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 60, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 64, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 69, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 73, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 80, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 83, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 86, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 89, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 93, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 96, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 100, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a") },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 23, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd") },
                    { 65, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 119, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 128, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 137, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 74, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 81, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 87, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 115, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 70, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 109, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 113, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 117, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 121, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 130, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 139, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 150, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 105, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 111, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 107, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 103, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 20, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 25, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 32, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 38, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 47, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 54, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 59, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 63, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 68, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 72, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 79, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 85, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 95, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 99, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new Guid("0648e7b1-f99e-415d-8055-3978690cbc48") },
                    { 151, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 156, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 90, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 158, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 154, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 155, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 17, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 22, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 27, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 153, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 30, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 36, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 40, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 43, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 45, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 49, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 56, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 61, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 157, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 152, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 34, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new Guid("046fe758-8915-4697-8d97-26024d0357ed") },
                    { 148, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 149, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 159, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f") },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 75, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 84, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 88, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 91, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 94, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 82, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 101, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 106, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 110, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 114, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 118, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 122, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 131, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 97, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                    { 140, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8") },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskDefinitionDepartment",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "DepartmentId", "ModifiedById", "ModifiedOn", "OriginalId", "TaskDefinitionId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0001-0001-00000000000d"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-00000000000d") },
                    { new Guid("00000000-0000-0001-0001-000000000010"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000010") },
                    { new Guid("00000000-0000-0001-0001-000000000011"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000011") },
                    { new Guid("00000000-0000-0001-0001-000000000012"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000012") },
                    { new Guid("00000000-0000-0002-0001-000000000013"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000013") },
                    { new Guid("00000000-0000-0001-0001-000000000013"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000013") },
                    { new Guid("00000000-0000-0001-0001-000000000014"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000014") },
                    { new Guid("00000000-0000-0001-0001-00000000000c"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-00000000000c") },
                    { new Guid("00000000-0000-0002-0001-000000000012"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000012") },
                    { new Guid("00000000-0000-0001-0001-00000000000b"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-00000000000b") },
                    { new Guid("00000000-0000-0001-0001-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000002") },
                    { new Guid("00000000-0000-0001-0001-000000000009"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000009") },
                    { new Guid("00000000-0000-0002-0001-000000000008"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000008") },
                    { new Guid("00000000-0000-0001-0001-000000000008"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000008") },
                    { new Guid("00000000-0000-0001-0001-000000000007"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000007") },
                    { new Guid("00000000-0000-0001-0001-000000000006"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000006") },
                    { new Guid("00000000-0000-0001-0001-000000000005"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000005") },
                    { new Guid("00000000-0000-0001-0001-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000004") },
                    { new Guid("00000000-0000-0001-0001-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000003") },
                    { new Guid("00000000-0000-0001-0001-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000001") },
                    { new Guid("00000000-0000-0001-0001-000000000015"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000015") },
                    { new Guid("00000000-0000-0001-0001-00000000000a"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-00000000000a") },
                    { new Guid("00000000-0000-0001-0001-000000000016"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0001-000000000016") },
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_WorkflowId",
                schema: "main",
                table: "Task",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskDefinitionId1",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_WorkflowId1",
                schema: "main",
                table: "Task",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelUser_EventDecisionLevelPropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelUser",
                column: "EventDecisionLevelPropertyProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CreatedById",
                schema: "main",
                table: "Department",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ModifiedById",
                schema: "main",
                table: "Department",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentRole_CreatedById",
                schema: "main",
                table: "DepartmentRole",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentRole_DepartmentId",
                schema: "main",
                table: "DepartmentRole",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentRole_ModifiedById",
                schema: "main",
                table: "DepartmentRole",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentRole_RoleId",
                schema: "main",
                table: "DepartmentRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EtlDelinquency_EventId",
                schema: "main",
                table: "EtlDelinquency",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelPropertyProfile_CreatedById",
                schema: "main",
                table: "EventDecisionLevelPropertyProfile",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelPropertyProfile_EventId",
                schema: "main",
                table: "EventDecisionLevelPropertyProfile",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelPropertyProfile_ModifiedById",
                schema: "main",
                table: "EventDecisionLevelPropertyProfile",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelPropertyProfile_PropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelPropertyProfile",
                column: "PropertyProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelPropertyProfile_EventDecisionLevelId_Prop~",
                schema: "main",
                table: "EventDecisionLevelPropertyProfile",
                columns: new[] { "EventDecisionLevelId", "PropertyProfileId", "Order" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMessages_CreatedById",
                schema: "main",
                table: "NotificationMessages",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMessages_ModifiedById",
                schema: "main",
                table: "NotificationMessages",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_CreatedById",
                schema: "main",
                table: "Permission",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_ModifiedById",
                schema: "main",
                table: "Permission",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDefinition_CreatedById",
                schema: "main",
                table: "ProcessingWorkflowTaskDefinition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDefinition_ModifiedById",
                schema: "main",
                table: "ProcessingWorkflowTaskDefinition",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDefinition_TaskDefinitionId",
                schema: "main",
                table: "ProcessingWorkflowTaskDefinition",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDefinition_WorkflowDefinitionId",
                schema: "main",
                table: "ProcessingWorkflowTaskDefinition",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDependency_CreatedById",
                schema: "main",
                table: "ProcessingWorkflowTaskDependency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDependency_DependencyId",
                schema: "main",
                table: "ProcessingWorkflowTaskDependency",
                column: "DependencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDependency_DependentId",
                schema: "main",
                table: "ProcessingWorkflowTaskDependency",
                column: "DependentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessingWorkflowTaskDependency_ModifiedById",
                schema: "main",
                table: "ProcessingWorkflowTaskDependency",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfile_CreatedById",
                schema: "main",
                table: "PropertyProfile",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfile_ModifiedById",
                schema: "main",
                table: "PropertyProfile",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileDelinquency_CreatedById",
                schema: "main",
                table: "PropertyProfileDelinquency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileDelinquency_DelinquencyId",
                schema: "main",
                table: "PropertyProfileDelinquency",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileDelinquency_ModifiedById",
                schema: "main",
                table: "PropertyProfileDelinquency",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileDelinquency_PropertyProfileId",
                schema: "main",
                table: "PropertyProfileDelinquency",
                column: "PropertyProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileFieldType_CreatedById",
                schema: "main",
                table: "PropertyProfileFieldType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileFieldType_ModifiedById",
                schema: "main",
                table: "PropertyProfileFieldType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileLogicType_CreatedById",
                schema: "main",
                table: "PropertyProfileLogicType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileLogicType_ModifiedById",
                schema: "main",
                table: "PropertyProfileLogicType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileLogicType_PropertyProfileFieldTypeId",
                schema: "main",
                table: "PropertyProfileLogicType",
                column: "PropertyProfileFieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRule_CreatedById",
                schema: "main",
                table: "PropertyProfileRule",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRule_ModifiedById",
                schema: "main",
                table: "PropertyProfileRule",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleField_CreatedById",
                schema: "main",
                table: "PropertyProfileRuleField",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleField_ModifiedById",
                schema: "main",
                table: "PropertyProfileRuleField",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleField_PropertyProfileFieldTypeId",
                schema: "main",
                table: "PropertyProfileRuleField",
                column: "PropertyProfileFieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItem_CreatedById",
                schema: "main",
                table: "PropertyProfileRuleItem",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItem_ModifiedById",
                schema: "main",
                table: "PropertyProfileRuleItem",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItem_PropertyProfileLogicTypeId",
                schema: "main",
                table: "PropertyProfileRuleItem",
                column: "PropertyProfileLogicTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItem_PropertyProfileRuleFieldId",
                schema: "main",
                table: "PropertyProfileRuleItem",
                column: "PropertyProfileRuleFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItem_PropertyProfileRuleId",
                schema: "main",
                table: "PropertyProfileRuleItem",
                column: "PropertyProfileRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItemValue_CreatedById",
                schema: "main",
                table: "PropertyProfileRuleItemValue",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItemValue_ModifiedById",
                schema: "main",
                table: "PropertyProfileRuleItemValue",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRuleItemValue_PropertyProfileRuleItemId",
                schema: "main",
                table: "PropertyProfileRuleItemValue",
                column: "PropertyProfileRuleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRulePropertyProfile_CreatedById",
                schema: "main",
                table: "PropertyProfileRulePropertyProfile",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRulePropertyProfile_ModifiedById",
                schema: "main",
                table: "PropertyProfileRulePropertyProfile",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileRulePropertyProfile_PropertyProfileId",
                schema: "main",
                table: "PropertyProfileRulePropertyProfile",
                column: "PropertyProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileState_CreatedById",
                schema: "main",
                table: "PropertyProfileState",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileState_ModifiedById",
                schema: "main",
                table: "PropertyProfileState",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProfileState_StateId",
                schema: "main",
                table: "PropertyProfileState",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedById",
                schema: "main",
                table: "Role",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ModifiedById",
                schema: "main",
                table: "Role",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Role_PermissionId",
                schema: "main",
                table: "Role",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_CreatedById",
                schema: "main",
                table: "RolePermission",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_ModifiedById",
                schema: "main",
                table: "RolePermission",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_PermissionId",
                schema: "main",
                table: "RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_RoleId",
                schema: "main",
                table: "RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDefinition_CreatedById",
                schema: "main",
                table: "ServicingWorkflowTaskDefinition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDefinition_ModifiedById",
                schema: "main",
                table: "ServicingWorkflowTaskDefinition",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDefinition_TaskDefinitionId",
                schema: "main",
                table: "ServicingWorkflowTaskDefinition",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDefinition_WorkflowDefinitionId",
                schema: "main",
                table: "ServicingWorkflowTaskDefinition",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDependency_CreatedById",
                schema: "main",
                table: "ServicingWorkflowTaskDependency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDependency_DependencyId",
                schema: "main",
                table: "ServicingWorkflowTaskDependency",
                column: "DependencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDependency_DependentId",
                schema: "main",
                table: "ServicingWorkflowTaskDependency",
                column: "DependentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingWorkflowTaskDependency_ModifiedById",
                schema: "main",
                table: "ServicingWorkflowTaskDependency",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinition_CreatedById",
                schema: "main",
                table: "TaskDefinition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinition_ModifiedById",
                schema: "main",
                table: "TaskDefinition",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionDepartment_CreatedById",
                schema: "main",
                table: "TaskDefinitionDepartment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionDepartment_DepartmentId",
                schema: "main",
                table: "TaskDefinitionDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionDepartment_ModifiedById",
                schema: "main",
                table: "TaskDefinitionDepartment",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionDepartment_TaskDefinitionId",
                schema: "main",
                table: "TaskDefinitionDepartment",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionUser_CreatedById",
                schema: "main",
                table: "TaskDefinitionUser",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionUser_ModifiedById",
                schema: "main",
                table: "TaskDefinitionUser",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionUser_TaskDefinitionId",
                schema: "main",
                table: "TaskDefinitionUser",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDefinitionUser_UserId",
                schema: "main",
                table: "TaskDefinitionUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_CreatedById",
                schema: "main",
                table: "TaskUser",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_ModifiedById",
                schema: "main",
                table: "TaskUser",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_TaskId",
                schema: "main",
                table: "TaskUser",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_UserId",
                schema: "main",
                table: "TaskUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionEventType_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionEventType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionEventType_EventTypeId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionEventType",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionEventType_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionEventType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionEventType_WorkflowDefinitionId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionEventType",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_StateId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowDefinitionState_WorkflowDefinitionId",
                schema: "main",
                table: "UnderwritingWorkflowDefinitionState",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDefinition_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowTaskDefinition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDefinition_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowTaskDefinition",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDefinition_TaskDefinitionId",
                schema: "main",
                table: "UnderwritingWorkflowTaskDefinition",
                column: "TaskDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDefinition_WorkflowDefinitionId",
                schema: "main",
                table: "UnderwritingWorkflowTaskDefinition",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDependency_CreatedById",
                schema: "main",
                table: "UnderwritingWorkflowTaskDependency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDependency_DependencyId",
                schema: "main",
                table: "UnderwritingWorkflowTaskDependency",
                column: "DependencyId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDependency_DependentId",
                schema: "main",
                table: "UnderwritingWorkflowTaskDependency",
                column: "DependentId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderwritingWorkflowTaskDependency_ModifiedById",
                schema: "main",
                table: "UnderwritingWorkflowTaskDependency",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_CreatedById",
                schema: "main",
                table: "UserPermission",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_ModifiedById",
                schema: "main",
                table: "UserPermission",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_PermissionId",
                schema: "main",
                table: "UserPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_UserId",
                schema: "main",
                table: "UserPermission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedById",
                schema: "main",
                table: "UserRole",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_ModifiedById",
                schema: "main",
                table: "UserRole",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "main",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                schema: "main",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_WorkflowDefinitionId",
                schema: "main",
                table: "Workflow",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_WorkflowDefinitionId1",
                schema: "main",
                table: "Workflow",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_EventId",
                schema: "main",
                table: "Workflow",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_WorkflowDefinitionId2",
                schema: "main",
                table: "Workflow",
                column: "WorkflowDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_CreatedById",
                schema: "main",
                table: "Workflow",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Workflow_ModifiedById",
                schema: "main",
                table: "Workflow",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_CreatedById",
                schema: "main",
                table: "WorkflowDefinition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowDefinition_ModifiedById",
                schema: "main",
                table: "WorkflowDefinition",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_EventDecisionLevelUser_EventDecisionLevelPropertyProfile_Ev~",
                schema: "main",
                table: "EventDecisionLevelUser",
                column: "EventDecisionLevelPropertyProfileId",
                principalSchema: "main",
                principalTable: "EventDecisionLevelPropertyProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskDefinition_TaskDefinitionId",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId",
                principalSchema: "main",
                principalTable: "TaskDefinition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Workflow_WorkflowId",
                schema: "main",
                table: "Task",
                column: "WorkflowId",
                principalSchema: "main",
                principalTable: "Workflow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskDefinition_TaskDefinitionId1",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId",
                principalSchema: "main",
                principalTable: "TaskDefinition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Workflow_WorkflowId1",
                schema: "main",
                table: "Task",
                column: "WorkflowId",
                principalSchema: "main",
                principalTable: "Workflow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskDefinition_TaskDefinitionId2",
                schema: "main",
                table: "Task",
                column: "TaskDefinitionId",
                principalSchema: "main",
                principalTable: "TaskDefinition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Workflow_WorkflowId2",
                schema: "main",
                table: "Task",
                column: "WorkflowId",
                principalSchema: "main",
                principalTable: "Workflow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDecisionLevelUser_EventDecisionLevelPropertyProfile_Ev~",
                schema: "main",
                table: "EventDecisionLevelUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskDefinition_TaskDefinitionId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Workflow_WorkflowId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskDefinition_TaskDefinitionId1",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Workflow_WorkflowId1",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskDefinition_TaskDefinitionId2",
                schema: "main",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Workflow_WorkflowId2",
                schema: "main",
                table: "Task");

            migrationBuilder.DropTable(
                name: "DepartmentAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DepartmentRole",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DepartmentRoleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EtlDelinquency",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDecisionLevelPropertyProfile",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDecisionLevelPropertyProfileAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "NotificationMessages",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PermissionAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ProcessingWorkflowTaskDependency",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileDelinquency",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileDelinquencyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileFieldTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileLogicTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleFieldAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleItemAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleItemValue",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleItemValueAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRulePropertyProfile",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRulePropertyProfileAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileState",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileStateAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "RoleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "RolePermission",
                schema: "main");

            migrationBuilder.DropTable(
                name: "RolePermissionAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ServicingWorkflowTaskDependency",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskDefinitionDepartment",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskDefinitionUser",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskUser",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UnderwritingWorkflowDefinitionEventType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UnderwritingWorkflowDefinitionState",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UnderwritingWorkflowTaskDependency",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UserPermission",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UserPermissionAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UserRoleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Workflow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ProcessingWorkflowTaskDefinition",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleItem",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfile",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ServicingWorkflowTaskDefinition",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UnderwritingWorkflowTaskDefinition",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileLogicType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRuleField",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileRule",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskDefinition",
                schema: "main");

            migrationBuilder.DropTable(
                name: "WorkflowDefinition",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Permission",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyProfileFieldType",
                schema: "main");

            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_WorkflowId",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_TaskDefinitionId1",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_WorkflowId1",
                schema: "main",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_EventDecisionLevelUser_EventDecisionLevelPropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelUser");

            migrationBuilder.DropSequence(
                name: "EntityFrameworkHiLoSequence",
                schema: "main");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "Notes",
                schema: "main",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "EventDecisionLevelPropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelUserAudit");

            migrationBuilder.DropColumn(
                name: "EventDecisionLevelPropertyProfileId",
                schema: "main",
                table: "EventDecisionLevelUser");

            migrationBuilder.RenameColumn(
                name: "WorkflowType",
                schema: "main",
                table: "Task",
                newName: "TaskTypeId");

            migrationBuilder.RenameColumn(
                name: "WorkflowId",
                schema: "main",
                table: "Task",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TaskDefinitionId",
                schema: "main",
                table: "Task",
                newName: "EventId");

            migrationBuilder.RenameColumn(
                name: "Order",
                schema: "main",
                table: "Task",
                newName: "TaskStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_WorkflowId2",
                schema: "main",
                table: "Task",
                newName: "IX_Task_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_TaskDefinitionId2",
                schema: "main",
                table: "Task",
                newName: "IX_Task_EventId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "main",
                table: "Task",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TaskAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    TaskStatusId = table.Column<int>(nullable: false),
                    TaskTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TaskStatus",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedById = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskStatus_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskStatus_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatusAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatusAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TaskType",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedById = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypeAudit",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InsertedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskStatus",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In Progress", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Completed", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Overdue", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overdue" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 22, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Create Workset", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CreateWorkset" },
                    { 21, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Import Results", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImportResults" },
                    { 20, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Funding", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Funding" },
                    { 19, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Prepare Bid File", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PrepareBidFile" },
                    { 18, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lock Event", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "LockEvent" },
                    { 17, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Final Review", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FinalReview" },
                    { 16, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Second Round Review", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecondRoundReview" },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "First Round Review", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FirstRoundReview" },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Assign Reviewer", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AssignReviewer" },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Import Inspections", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImportInspections" },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Order Inspections", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrderInspections" },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pre-Sale Letters", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PreSaleLetters" },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pre Lim List (Mail Merge)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PreLimList" },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Data Filters", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "DataFilters" },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Import Data", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImportData" },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Supplemental Data", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SupplementalData" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Run Data Macro", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "RunDataMacro" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Deposit", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deposit" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Registration", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Registration" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Upload Delinquent Listing", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "UploadDelinquentListing" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Enter Sale Info", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "EnterSaleInfo" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Create Event", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CreateEvent" },
                    { 23, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Certificates (Mail Merge)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Certificates" },
                    { 24, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Post-Sale Letters (Mail Merge)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PostSaleLetters" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskStatusId",
                schema: "main",
                table: "Task",
                column: "TaskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskTypeId",
                schema: "main",
                table: "Task",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatus_CreatedById",
                schema: "main",
                table: "TaskStatus",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatus_ModifiedById",
                schema: "main",
                table: "TaskStatus",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskType_CreatedById",
                schema: "main",
                table: "TaskType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TaskType_ModifiedById",
                schema: "main",
                table: "TaskType",
                column: "ModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Event_EventId",
                schema: "main",
                table: "Task",
                column: "EventId",
                principalSchema: "main",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskStatus_TaskStatusId",
                schema: "main",
                table: "Task",
                column: "TaskStatusId",
                principalSchema: "main",
                principalTable: "TaskStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskType_TaskTypeId",
                schema: "main",
                table: "Task",
                column: "TaskTypeId",
                principalSchema: "main",
                principalTable: "TaskType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_UserId",
                schema: "main",
                table: "Task",
                column: "UserId",
                principalSchema: "main",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
