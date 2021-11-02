using System;

using Microsoft.EntityFrameworkCore.Migrations;

using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "main");

            migrationBuilder.CreateTable(
                name: "AuctionTypeAudit",
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
                    table.PrimaryKey("PK_AuctionTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "BidAudit",
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
                    Number = table.Column<string>(nullable: true),
                    Entity = table.Column<string>(nullable: true),
                    Portfolio = table.Column<string>(nullable: true),
                    EventId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignAudit",
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
                    TargetDate = table.Column<DateTime>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CampaignName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CampaignTypeId = table.Column<int>(nullable: false),
                    CampaignSubTypeId = table.Column<int>(nullable: true),
                    AssignedUserId = table.Column<Guid>(nullable: false),
                    CountyId = table.Column<int>(nullable: false),
                    TotalRecords = table.Column<int>(nullable: true),
                    TotalAmountRecords = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignCommentAudit",
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
                    AuthorId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCommentAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignFieldTypeAudit",
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
                    table.PrimaryKey("PK_CampaignFieldTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignLeadAudit",
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
                    LeadId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignLeadAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignLogicTypeAudit",
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
                    CampaignFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignLogicTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleAudit",
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
                    table.PrimaryKey("PK_CampaignRuleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleCampaignAudit",
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
                    CampaignRuleId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignRuleCampaignAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleFieldAudit",
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
                    CampaignFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignRuleFieldAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleItemAudit",
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
                    CampaignRuleId = table.Column<Guid>(nullable: false),
                    CampaignLogicTypeId = table.Column<int>(nullable: false),
                    CampaignRuleFieldId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignRuleItemAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CampaignTypeAudit",
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
                    ParentTypeId = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CollectingEntityAudit",
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
                    AmountDue = table.Column<decimal>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    CollectingEntityTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectingEntityAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CollectingEntityTypeAudit",
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
                    table.PrimaryKey("PK_CollectingEntityTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "ContactAudit",
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
                    LeadId = table.Column<Guid>(nullable: false),
                    ContactTypeId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    OfficePhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MailingAddress1 = table.Column<string>(nullable: true),
                    MailingAddress2 = table.Column<string>(nullable: true),
                    MailingAddress3 = table.Column<string>(nullable: true),
                    MailingCity = table.Column<string>(nullable: true),
                    MailingStateId = table.Column<int>(nullable: true),
                    MailingZipCode = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "ContactTypeAudit",
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
                    table.PrimaryKey("PK_ContactTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "CountyAudit",
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
                    StateId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DataCutFieldTypeAudit",
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
                    table.PrimaryKey("PK_DataCutFieldTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DataCutLogicTypeAudit",
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
                    DataCutFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutLogicTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DataCutResultTypeAudit",
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
                    table.PrimaryKey("PK_DataCutResultTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DataCutRuleAudit",
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
                    CountyId = table.Column<int>(nullable: false),
                    DataCutResultTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutRuleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DataCutRuleFieldAudit",
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
                    DataCutFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutRuleFieldAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DataCutRuleItemAudit",
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
                    DataCutRuleId = table.Column<Guid>(nullable: false),
                    DataCutLogicTypeId = table.Column<int>(nullable: false),
                    DataCutRuleFieldId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutRuleItemAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DecisionAudit",
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
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    EventDecisionLevelId = table.Column<Guid>(nullable: false),
                    DecisionTypeId = table.Column<int>(nullable: true),
                    DecisionDate = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecisionAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DecisionTypeAudit",
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
                    table.PrimaryKey("PK_DecisionTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyAudit",
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
                    DelinquencyTaxYear = table.Column<int>(nullable: false),
                    PropertyId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyCommentAudit",
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
                    AuthorId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyCommentAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyPropertyDisplayStrategyAudit",
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
                    PropertyDisplayStrategyId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyPropertyDisplayStrategyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyPropertyScoringAudit",
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
                    PropertyScoring = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyPropertyScoringAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventAttachmentAudit",
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
                    FileName = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttachmentAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventAudit",
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
                    EventNumber = table.Column<string>(nullable: true),
                    CountyId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CurrentTask = table.Column<string>(nullable: true),
                    Progress = table.Column<string>(nullable: true),
                    FundingDate = table.Column<DateTime>(nullable: true),
                    RegistrationDeadline = table.Column<DateTime>(nullable: true),
                    DepositDeadline = table.Column<DateTime>(nullable: true),
                    DepositAmount = table.Column<decimal>(nullable: true),
                    TreasurerFee = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    AuctionAddress = table.Column<string>(nullable: true),
                    AuctionStartTime = table.Column<DateTime>(nullable: true),
                    TreasurerName = table.Column<string>(nullable: true),
                    TreasurerEmail = table.Column<string>(nullable: true),
                    EstimatedPurchaseAmount = table.Column<decimal>(nullable: true),
                    EstimatedDepositAmount = table.Column<decimal>(nullable: true),
                    RefundAmount = table.Column<decimal>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: false),
                    AccountingUserId = table.Column<Guid>(nullable: true),
                    AcquizitionUserId = table.Column<Guid>(nullable: true),
                    AssetManagementUserId = table.Column<Guid>(nullable: true),
                    DataUserId = table.Column<Guid>(nullable: true),
                    ManagementUserId = table.Column<Guid>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    EventTypeId = table.Column<int>(nullable: false),
                    AuctionTypeId = table.Column<int>(nullable: false),
                    SaleDateStatusId = table.Column<int>(nullable: false),
                    EventEntityId = table.Column<int>(nullable: true),
                    FinalPaymentTypeId = table.Column<int>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    OriginalListCount = table.Column<int>(nullable: true),
                    OriginalListAmount = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventDataCutDecisionAudit",
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
                    EventDataCutStrategyId = table.Column<Guid>(nullable: false),
                    DecisionTypeId = table.Column<int>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDataCutDecisionAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventDataCutRuleAudit",
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
                    EventDataCutStrategyId = table.Column<Guid>(nullable: false),
                    DataCutRuleId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDataCutRuleAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventDataCutStrategyAudit",
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
                    IsActive = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDataCutStrategyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventDecisionLevelAudit",
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
                    Order = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsFinal = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecisionLevelAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventDecisionLevelUserAudit",
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
                    AssigmentCount = table.Column<int>(nullable: false),
                    EventDecisionLevelId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecisionLevelUserAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventEntityAudit",
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
                    table.PrimaryKey("PK_EventEntityAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "EventTypeAudit",
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
                    table.PrimaryKey("PK_EventTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "FinalPaymentTypeAudit",
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
                    table.PrimaryKey("PK_FinalPaymentTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "GeneralLandUseCodeAudit",
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
                    table.PrimaryKey("PK_GeneralLandUseCodeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "InternalLandUseCodeAudit",
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
                    table.PrimaryKey("PK_InternalLandUseCodeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "LeadAudit",
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
                    AccountName = table.Column<string>(nullable: true),
                    MailingAddress1 = table.Column<string>(nullable: true),
                    MailingAddress2 = table.Column<string>(nullable: true),
                    MailingAddress3 = table.Column<string>(nullable: true),
                    MailingCity = table.Column<string>(nullable: true),
                    MailingStateId = table.Column<int>(nullable: true),
                    MailingZipCode = table.Column<string>(nullable: true),
                    DoNotContact = table.Column<bool>(nullable: false),
                    TotalAmountDueProperties = table.Column<decimal>(nullable: true),
                    AppraisedValueOfProperties = table.Column<decimal>(nullable: true),
                    LeadBK = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "LeadCommentAudit",
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
                    LeadId = table.Column<Guid>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCommentAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "LoanTypeAudit",
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
                    table.PrimaryKey("PK_LoanTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "OpportunityAudit",
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
                    LeadId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    OpportunityStageId = table.Column<int>(nullable: false),
                    LoanTypeId = table.Column<int>(nullable: true),
                    CampaignId = table.Column<Guid>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    FirstBorrowerFirstName = table.Column<string>(nullable: true),
                    FirstBorrowerLastName = table.Column<string>(nullable: true),
                    FirstBorrowerMiddleName = table.Column<string>(nullable: true),
                    FirstBorrowerSSN = table.Column<string>(nullable: true),
                    FirstBorrowerEmail = table.Column<string>(nullable: true),
                    FirstBorrowerCellPhone = table.Column<string>(nullable: true),
                    FirstBorrowerWorkPhone = table.Column<string>(nullable: true),
                    FirstBorrowerFax = table.Column<string>(nullable: true),
                    FirstBorrowerMerried = table.Column<bool>(nullable: true),
                    FirstBorrowerDateOfBirth = table.Column<DateTime>(nullable: true),
                    SecondBorrowerFirstName = table.Column<string>(nullable: true),
                    SecondBorrowerLastName = table.Column<string>(nullable: true),
                    SecondBorrowerMiddleName = table.Column<string>(nullable: true),
                    SecondBorrowerSSN = table.Column<string>(nullable: true),
                    SecondBorrowerEmail = table.Column<string>(nullable: true),
                    SecondBorrowerCellPhone = table.Column<string>(nullable: true),
                    SecondBorrowerWorkPhone = table.Column<string>(nullable: true),
                    SecondBorrowerFax = table.Column<string>(nullable: true),
                    SecondBorrowerMerried = table.Column<bool>(nullable: true),
                    SecondBorrowerDateOfBirth = table.Column<DateTime>(nullable: true),
                    CloseDate = table.Column<DateTime>(nullable: true),
                    CloseProbabilityPercent = table.Column<decimal>(nullable: true),
                    LoanToValuePercent = table.Column<decimal>(nullable: true),
                    OriginationPercent = table.Column<decimal>(nullable: true),
                    ClosingCost = table.Column<decimal>(nullable: true),
                    LenderCredit = table.Column<decimal>(nullable: true),
                    AmountDue = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    CurrentLoanBalance = table.Column<decimal>(nullable: true),
                    ThirdPartyLoanBalance = table.Column<decimal>(nullable: true),
                    Term = table.Column<int>(nullable: true),
                    PrePay = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "OpportunityContactAudit",
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
                    OpportunityId = table.Column<Guid>(nullable: false),
                    ContactId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityContactAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "OpportunityPropertyAudit",
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
                    PropertyId = table.Column<Guid>(nullable: false),
                    OpportunityId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityPropertyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "OpportunityStageAudit",
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
                    table.PrimaryKey("PK_OpportunityStageAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyAttachmentAudit",
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
                    PropertyId = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    FileCreatedOn = table.Column<DateTime>(nullable: false),
                    PropertyAttachmentTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAttachmentAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyAttachmentTypeAudit",
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
                    table.PrimaryKey("PK_PropertyAttachmentTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyAudit",
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
                    LeadId = table.Column<Guid>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    GeneralLandUseCodeId = table.Column<int>(nullable: true),
                    InternalLandUseCodeId = table.Column<int>(nullable: true),
                    PropertyBK = table.Column<string>(nullable: true),
                    ParcelId = table.Column<string>(nullable: true),
                    CADId = table.Column<string>(nullable: true),
                    TAXId = table.Column<string>(nullable: true),
                    FolioId = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    CountyId = table.Column<int>(nullable: false),
                    LegalDescription = table.Column<string>(nullable: true),
                    LandStateCode = table.Column<string>(nullable: true),
                    ImprovementStateCode = table.Column<string>(nullable: true),
                    LandUseCode = table.Column<string>(nullable: true),
                    Over65SurvivingSpouse = table.Column<bool>(nullable: false),
                    DisabilityExemption = table.Column<bool>(nullable: false),
                    Mortgage = table.Column<bool>(nullable: false),
                    PaymentPlan = table.Column<bool>(nullable: false),
                    Veteran = table.Column<bool>(nullable: false),
                    Bankruptcy = table.Column<bool>(nullable: false),
                    ThirdPartyForeclosure = table.Column<bool>(nullable: false),
                    LandAcres = table.Column<float>(nullable: true),
                    BuildingSqFt = table.Column<int>(nullable: true),
                    YearBuilt = table.Column<int>(nullable: true),
                    Latitude = table.Column<float>(nullable: true),
                    Longitude = table.Column<float>(nullable: true),
                    Homestead = table.Column<bool>(nullable: true),
                    RUAmount = table.Column<decimal>(nullable: true),
                    RULTVPercent = table.Column<decimal>(nullable: true),
                    LTVPercent = table.Column<decimal>(nullable: true),
                    TotalAmountDue = table.Column<decimal>(nullable: false),
                    LastYearDue = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyDisplayStrategyAudit",
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
                    table.PrimaryKey("PK_PropertyDisplayStrategyAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertySupplementalEventDataAudit",
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
                    PropertyId = table.Column<Guid>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    LastSaleDate = table.Column<DateTime>(nullable: true),
                    LastSaleAmount = table.Column<decimal>(nullable: true),
                    MortgageLender1 = table.Column<string>(nullable: true),
                    MortgageLoanAmount1 = table.Column<decimal>(nullable: true),
                    MortgageOriginationDate1 = table.Column<DateTime>(nullable: true),
                    MortgageMaturityDate1 = table.Column<DateTime>(nullable: true),
                    MortgageLender2 = table.Column<string>(nullable: true),
                    MortgageLoanAmount2 = table.Column<decimal>(nullable: true),
                    MortgageOriginationDate2 = table.Column<DateTime>(nullable: true),
                    MortgageMaturityDate2 = table.Column<DateTime>(nullable: true),
                    InspectorComment = table.Column<string>(nullable: true),
                    InspectorPropertyRating = table.Column<decimal>(nullable: true),
                    InspectorAreaRating = table.Column<decimal>(nullable: true),
                    InspectorOccupied = table.Column<bool>(nullable: true),
                    InspectorRoofCondition = table.Column<string>(nullable: true),
                    InspectorLawnMaintained = table.Column<string>(nullable: true),
                    OpenLiens = table.Column<int>(nullable: true),
                    ClosedLiens = table.Column<int>(nullable: true),
                    RecentBuyerName = table.Column<string>(nullable: true),
                    RecentBuyerRate = table.Column<decimal>(nullable: true),
                    AdvertisementBatch = table.Column<string>(nullable: true),
                    AdvertisementNumber = table.Column<string>(nullable: true),
                    AssessorURL = table.Column<string>(nullable: true),
                    TreasurerURL = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySupplementalEventDataAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "PropertyValuationAudit",
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
                    PropertyId = table.Column<Guid>(nullable: false),
                    AppraisedYear = table.Column<int>(nullable: false),
                    LandValue = table.Column<decimal>(nullable: true),
                    ImprovementValue = table.Column<decimal>(nullable: true),
                    AppraisedValue = table.Column<decimal>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyValuationAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "ResultAudit",
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
                    BidNumber = table.Column<string>(nullable: true),
                    CertNo = table.Column<string>(nullable: true),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    Overbid = table.Column<decimal>(nullable: true),
                    Premium = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: false),
                    PenaltyRate = table.Column<decimal>(nullable: true),
                    RecoverableFees = table.Column<decimal>(nullable: true),
                    NonRecoverableFees = table.Column<decimal>(nullable: true),
                    BidId = table.Column<Guid>(nullable: true),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "SaleDateStatusAudit",
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
                    table.PrimaryKey("PK_SaleDateStatusAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "StateAudit",
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
                    Abbreviation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "StateTaxeAudit",
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
                    StateId = table.Column<int>(nullable: false),
                    TaxRate = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTaxeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TaskAudit",
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
                    DueDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    TaskTypeId = table.Column<int>(nullable: false),
                    TaskStatusId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TaskStatusAudit",
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
                    table.PrimaryKey("PK_TaskStatusAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "TaskTypeAudit",
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
                    table.PrimaryKey("PK_TaskTypeAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAudit",
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAudit", x => new { x.Id, x.InsertedOn });
                });

            migrationBuilder.CreateTable(
                name: "AuctionType",
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
                    table.PrimaryKey("PK_AuctionType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuctionType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignFieldType",
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
                    table.PrimaryKey("PK_CampaignFieldType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignFieldType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignFieldType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignRule",
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
                    table.PrimaryKey("PK_CampaignRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignRule_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRule_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignType",
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
                    ParentTypeId = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignType_CampaignType_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalSchema: "main",
                        principalTable: "CampaignType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollectingEntityType",
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
                    table.PrimaryKey("PK_CollectingEntityType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectingEntityType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectingEntityType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactType",
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
                    table.PrimaryKey("PK_ContactType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataCutFieldType",
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
                    table.PrimaryKey("PK_DataCutFieldType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCutFieldType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutFieldType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataCutResultType",
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
                    table.PrimaryKey("PK_DataCutResultType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCutResultType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutResultType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecisionType",
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
                    table.PrimaryKey("PK_DecisionType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecisionType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DecisionType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventEntity",
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
                    table.PrimaryKey("PK_EventEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventEntity_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventEntity_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
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
                    table.PrimaryKey("PK_EventType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinalPaymentType",
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
                    table.PrimaryKey("PK_FinalPaymentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalPaymentType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinalPaymentType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLandUseCode",
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
                    table.PrimaryKey("PK_GeneralLandUseCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralLandUseCode_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneralLandUseCode_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternalLandUseCode",
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
                    table.PrimaryKey("PK_InternalLandUseCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalLandUseCode_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternalLandUseCode_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoanType",
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
                    table.PrimaryKey("PK_LoanType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationStatus",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Code = table.Column<int>(nullable: false),
                    Progress = table.Column<int>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationStatus", x => new { x.Id, x.CreatedOn });
                    table.ForeignKey(
                        name: "FK_OperationStatus_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationStatus_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityStage",
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
                    table.PrimaryKey("PK_OpportunityStage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpportunityStage_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityStage_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAttachmentType",
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
                    table.PrimaryKey("PK_PropertyAttachmentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyAttachmentType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyAttachmentType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDisplayStrategy",
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
                    table.PrimaryKey("PK_PropertyDisplayStrategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyDisplayStrategy_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyDisplayStrategy_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleDateStatus",
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
                    table.PrimaryKey("PK_SaleDateStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDateStatus_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDateStatus_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "State",
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
                    Abbreviation = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_State_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatus",
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
                name: "TaskType",
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
                name: "CampaignLogicType",
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
                    CampaignFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignLogicType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignLogicType_CampaignFieldType_CampaignFieldTypeId",
                        column: x => x.CampaignFieldTypeId,
                        principalSchema: "main",
                        principalTable: "CampaignFieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignLogicType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignLogicType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleField",
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
                    CampaignFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignRuleField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignRuleField_CampaignFieldType_CampaignFieldTypeId",
                        column: x => x.CampaignFieldTypeId,
                        principalSchema: "main",
                        principalTable: "CampaignFieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleField_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleField_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataCutLogicType",
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
                    DataCutFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutLogicType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCutLogicType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutLogicType_DataCutFieldType_DataCutFieldTypeId",
                        column: x => x.DataCutFieldTypeId,
                        principalSchema: "main",
                        principalTable: "DataCutFieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutLogicType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataCutRuleField",
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
                    DataCutFieldTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutRuleField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCutRuleField_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRuleField_DataCutFieldType_DataCutFieldTypeId",
                        column: x => x.DataCutFieldTypeId,
                        principalSchema: "main",
                        principalTable: "DataCutFieldType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRuleField_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "County",
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
                    StateId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_County", x => x.Id);
                    table.ForeignKey(
                        name: "FK_County_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_County_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_County_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lead",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    MailingAddress1 = table.Column<string>(nullable: true),
                    MailingAddress2 = table.Column<string>(nullable: true),
                    MailingAddress3 = table.Column<string>(nullable: true),
                    MailingCity = table.Column<string>(nullable: true),
                    MailingStateId = table.Column<int>(nullable: true),
                    MailingZipCode = table.Column<string>(nullable: true),
                    DoNotContact = table.Column<bool>(nullable: false),
                    TotalAmountDueProperties = table.Column<decimal>(nullable: true),
                    AppraisedValueOfProperties = table.Column<decimal>(nullable: true),
                    LeadBK = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lead_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lead_State_MailingStateId",
                        column: x => x.MailingStateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lead_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateTaxe",
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
                    StateId = table.Column<int>(nullable: false),
                    TaxRate = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTaxe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StateTaxe_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateTaxe_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateTaxe_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleItem",
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
                    CampaignRuleId = table.Column<Guid>(nullable: false),
                    CampaignLogicTypeId = table.Column<int>(nullable: false),
                    CampaignRuleFieldId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignRuleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignRuleItem_CampaignLogicType_CampaignLogicTypeId",
                        column: x => x.CampaignLogicTypeId,
                        principalSchema: "main",
                        principalTable: "CampaignLogicType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleItem_CampaignRuleField_CampaignRuleFieldId",
                        column: x => x.CampaignRuleFieldId,
                        principalSchema: "main",
                        principalTable: "CampaignRuleField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleItem_CampaignRule_CampaignRuleId",
                        column: x => x.CampaignRuleId,
                        principalSchema: "main",
                        principalTable: "CampaignRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleItem_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleItem_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    TargetDate = table.Column<DateTime>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CampaignName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CampaignTypeId = table.Column<int>(nullable: false),
                    CampaignSubTypeId = table.Column<int>(nullable: true),
                    AssignedUserId = table.Column<Guid>(nullable: false),
                    CountyId = table.Column<int>(nullable: false),
                    TotalRecords = table.Column<int>(nullable: true),
                    TotalAmountRecords = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaign_User_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_CampaignType_CampaignSubTypeId",
                        column: x => x.CampaignSubTypeId,
                        principalSchema: "main",
                        principalTable: "CampaignType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Campaign_CampaignType_CampaignTypeId",
                        column: x => x.CampaignTypeId,
                        principalSchema: "main",
                        principalTable: "CampaignType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "main",
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Campaign_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataCutRule",
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
                    CountyId = table.Column<int>(nullable: false),
                    DataCutResultTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCutRule_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "main",
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRule_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRule_DataCutResultType_DataCutResultTypeId",
                        column: x => x.DataCutResultTypeId,
                        principalSchema: "main",
                        principalTable: "DataCutResultType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRule_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    EventNumber = table.Column<string>(nullable: true),
                    CountyId = table.Column<int>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CurrentTask = table.Column<string>(nullable: true),
                    Progress = table.Column<string>(nullable: true),
                    FundingDate = table.Column<DateTime>(nullable: true),
                    RegistrationDeadline = table.Column<DateTime>(nullable: true),
                    DepositDeadline = table.Column<DateTime>(nullable: true),
                    DepositAmount = table.Column<decimal>(nullable: true),
                    TreasurerFee = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    AuctionAddress = table.Column<string>(nullable: true),
                    AuctionStartTime = table.Column<DateTime>(nullable: true),
                    TreasurerName = table.Column<string>(nullable: true),
                    TreasurerEmail = table.Column<string>(nullable: true),
                    EstimatedPurchaseAmount = table.Column<decimal>(nullable: true),
                    EstimatedDepositAmount = table.Column<decimal>(nullable: true),
                    RefundAmount = table.Column<decimal>(nullable: true),
                    IsLocked = table.Column<bool>(nullable: false),
                    AccountingUserId = table.Column<Guid>(nullable: true),
                    AcquizitionUserId = table.Column<Guid>(nullable: true),
                    AssetManagementUserId = table.Column<Guid>(nullable: true),
                    DataUserId = table.Column<Guid>(nullable: true),
                    ManagementUserId = table.Column<Guid>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    EventTypeId = table.Column<int>(nullable: false),
                    AuctionTypeId = table.Column<int>(nullable: false),
                    SaleDateStatusId = table.Column<int>(nullable: false),
                    EventEntityId = table.Column<int>(nullable: true),
                    FinalPaymentTypeId = table.Column<int>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    OriginalListCount = table.Column<int>(nullable: true),
                    OriginalListAmount = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_User_AccountingUserId",
                        column: x => x.AccountingUserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_User_AcquizitionUserId",
                        column: x => x.AcquizitionUserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_User_AssetManagementUserId",
                        column: x => x.AssetManagementUserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_AuctionType_AuctionTypeId",
                        column: x => x.AuctionTypeId,
                        principalSchema: "main",
                        principalTable: "AuctionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "main",
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_User_DataUserId",
                        column: x => x.DataUserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_EventEntity_EventEntityId",
                        column: x => x.EventEntityId,
                        principalSchema: "main",
                        principalTable: "EventEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_EventType_EventTypeId",
                        column: x => x.EventTypeId,
                        principalSchema: "main",
                        principalTable: "EventType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_EventEntity_FinalPaymentTypeId",
                        column: x => x.FinalPaymentTypeId,
                        principalSchema: "main",
                        principalTable: "EventEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_User_ManagementUserId",
                        column: x => x.ManagementUserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_SaleDateStatus_SaleDateStatusId",
                        column: x => x.SaleDateStatusId,
                        principalSchema: "main",
                        principalTable: "SaleDateStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: false),
                    ContactTypeId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    OfficePhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MailingAddress1 = table.Column<string>(nullable: true),
                    MailingAddress2 = table.Column<string>(nullable: true),
                    MailingAddress3 = table.Column<string>(nullable: true),
                    MailingCity = table.Column<string>(nullable: true),
                    MailingStateId = table.Column<int>(nullable: true),
                    MailingZipCode = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_ContactType_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalSchema: "main",
                        principalTable: "ContactType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_Lead_LeadId",
                        column: x => x.LeadId,
                        principalSchema: "main",
                        principalTable: "Lead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_State_MailingStateId",
                        column: x => x.MailingStateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeadComment",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadComment_User_AuthorId",
                        column: x => x.AuthorId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadComment_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadComment_Lead_LeadId",
                        column: x => x.LeadId,
                        principalSchema: "main",
                        principalTable: "Lead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadComment_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    GeneralLandUseCodeId = table.Column<int>(nullable: true),
                    InternalLandUseCodeId = table.Column<int>(nullable: true),
                    PropertyBK = table.Column<string>(nullable: true),
                    ParcelId = table.Column<string>(nullable: true),
                    CADId = table.Column<string>(nullable: true),
                    TAXId = table.Column<string>(nullable: true),
                    FolioId = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    CountyId = table.Column<int>(nullable: false),
                    LegalDescription = table.Column<string>(nullable: true),
                    LandStateCode = table.Column<string>(nullable: true),
                    ImprovementStateCode = table.Column<string>(nullable: true),
                    LandUseCode = table.Column<string>(nullable: true),
                    Over65SurvivingSpouse = table.Column<bool>(nullable: false),
                    DisabilityExemption = table.Column<bool>(nullable: false),
                    Mortgage = table.Column<bool>(nullable: false),
                    PaymentPlan = table.Column<bool>(nullable: false),
                    Veteran = table.Column<bool>(nullable: false),
                    Bankruptcy = table.Column<bool>(nullable: false),
                    ThirdPartyForeclosure = table.Column<bool>(nullable: false),
                    LandAcres = table.Column<float>(nullable: true),
                    BuildingSqFt = table.Column<int>(nullable: true),
                    YearBuilt = table.Column<int>(nullable: true),
                    Latitude = table.Column<float>(nullable: true),
                    Longitude = table.Column<float>(nullable: true),
                    Homestead = table.Column<bool>(nullable: true),
                    RUAmount = table.Column<decimal>(nullable: true),
                    RULTVPercent = table.Column<decimal>(nullable: true),
                    LTVPercent = table.Column<decimal>(nullable: true),
                    TotalAmountDue = table.Column<decimal>(nullable: false),
                    LastYearDue = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "main",
                        principalTable: "County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_GeneralLandUseCode_GeneralLandUseCodeId",
                        column: x => x.GeneralLandUseCodeId,
                        principalSchema: "main",
                        principalTable: "GeneralLandUseCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_InternalLandUseCode_InternalLandUseCodeId",
                        column: x => x.InternalLandUseCodeId,
                        principalSchema: "main",
                        principalTable: "InternalLandUseCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Property_Lead_LeadId",
                        column: x => x.LeadId,
                        principalSchema: "main",
                        principalTable: "Lead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Property_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "main",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignComment",
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
                    AuthorId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignComment_User_AuthorId",
                        column: x => x.AuthorId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignComment_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalSchema: "main",
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignComment_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignComment_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignLead",
                schema: "main",
                columns: table => new
                {
                    CampaignId = table.Column<Guid>(nullable: false),
                    LeadId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignLead", x => new { x.CampaignId, x.LeadId });
                    table.ForeignKey(
                        name: "FK_CampaignLead_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalSchema: "main",
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignLead_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignLead_Lead_LeadId",
                        column: x => x.LeadId,
                        principalSchema: "main",
                        principalTable: "Lead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignLead_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignRuleCampaign",
                schema: "main",
                columns: table => new
                {
                    CampaignId = table.Column<Guid>(nullable: false),
                    CampaignRuleId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignRuleCampaign", x => new { x.CampaignId, x.CampaignRuleId });
                    table.ForeignKey(
                        name: "FK_CampaignRuleCampaign_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalSchema: "main",
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleCampaign_CampaignRule_CampaignRuleId",
                        column: x => x.CampaignRuleId,
                        principalSchema: "main",
                        principalTable: "CampaignRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleCampaign_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignRuleCampaign_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataCutRuleItem",
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
                    DataCutRuleId = table.Column<Guid>(nullable: false),
                    DataCutLogicTypeId = table.Column<int>(nullable: false),
                    DataCutRuleFieldId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCutRuleItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataCutRuleItem_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRuleItem_DataCutLogicType_DataCutLogicTypeId",
                        column: x => x.DataCutLogicTypeId,
                        principalSchema: "main",
                        principalTable: "DataCutLogicType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRuleItem_DataCutRuleField_DataCutRuleFieldId",
                        column: x => x.DataCutRuleFieldId,
                        principalSchema: "main",
                        principalTable: "DataCutRuleField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRuleItem_DataCutRule_DataCutRuleId",
                        column: x => x.DataCutRuleId,
                        principalSchema: "main",
                        principalTable: "DataCutRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataCutRuleItem_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bid",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Entity = table.Column<string>(nullable: true),
                    Portfolio = table.Column<string>(nullable: true),
                    EventId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bid_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bid_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bid_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAttachment",
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
                    FileName = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAttachment_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAttachment_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAttachment_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDataCutStrategy",
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
                    IsActive = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDataCutStrategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventDataCutStrategy_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutStrategy_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutStrategy_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDecisionLevel",
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
                    Order = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsFinal = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecisionLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevel_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevel_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevel_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: false),
                    TaskTypeId = table.Column<int>(nullable: false),
                    TaskStatusId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Task_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Task_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Task_TaskStatus_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalSchema: "main",
                        principalTable: "TaskStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Task_TaskType_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalSchema: "main",
                        principalTable: "TaskType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Task_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Opportunity",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    LeadId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    OpportunityStageId = table.Column<int>(nullable: false),
                    LoanTypeId = table.Column<int>(nullable: true),
                    CampaignId = table.Column<Guid>(nullable: true),
                    ContactId = table.Column<Guid>(nullable: true),
                    FirstBorrowerFirstName = table.Column<string>(nullable: false),
                    FirstBorrowerLastName = table.Column<string>(nullable: false),
                    FirstBorrowerMiddleName = table.Column<string>(nullable: true),
                    FirstBorrowerSSN = table.Column<string>(nullable: true),
                    FirstBorrowerEmail = table.Column<string>(nullable: true),
                    FirstBorrowerCellPhone = table.Column<string>(nullable: true),
                    FirstBorrowerWorkPhone = table.Column<string>(nullable: true),
                    FirstBorrowerFax = table.Column<string>(nullable: true),
                    FirstBorrowerMerried = table.Column<bool>(nullable: true),
                    FirstBorrowerDateOfBirth = table.Column<DateTime>(nullable: true),
                    SecondBorrowerFirstName = table.Column<string>(nullable: true),
                    SecondBorrowerLastName = table.Column<string>(nullable: true),
                    SecondBorrowerMiddleName = table.Column<string>(nullable: true),
                    SecondBorrowerSSN = table.Column<string>(nullable: true),
                    SecondBorrowerEmail = table.Column<string>(nullable: true),
                    SecondBorrowerCellPhone = table.Column<string>(nullable: true),
                    SecondBorrowerWorkPhone = table.Column<string>(nullable: true),
                    SecondBorrowerFax = table.Column<string>(nullable: true),
                    SecondBorrowerMerried = table.Column<bool>(nullable: true),
                    SecondBorrowerDateOfBirth = table.Column<DateTime>(nullable: true),
                    CloseDate = table.Column<DateTime>(nullable: true),
                    CloseProbabilityPercent = table.Column<decimal>(nullable: true),
                    LoanToValuePercent = table.Column<decimal>(nullable: true),
                    OriginationPercent = table.Column<decimal>(nullable: true),
                    ClosingCost = table.Column<decimal>(nullable: true),
                    LenderCredit = table.Column<decimal>(nullable: true),
                    AmountDue = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: true),
                    CurrentLoanBalance = table.Column<decimal>(nullable: true),
                    ThirdPartyLoanBalance = table.Column<decimal>(nullable: true),
                    Term = table.Column<int>(nullable: true),
                    PrePay = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Opportunity_Campaign_CampaignId",
                        column: x => x.CampaignId,
                        principalSchema: "main",
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_Contact_ContactId",
                        column: x => x.ContactId,
                        principalSchema: "main",
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opportunity_Lead_LeadId",
                        column: x => x.LeadId,
                        principalSchema: "main",
                        principalTable: "Lead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opportunity_LoanType_LoanTypeId",
                        column: x => x.LoanTypeId,
                        principalSchema: "main",
                        principalTable: "LoanType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opportunity_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opportunity_OpportunityStage_OpportunityStageId",
                        column: x => x.OpportunityStageId,
                        principalSchema: "main",
                        principalTable: "OpportunityStage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opportunity_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delinquency",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DelinquencyTaxYear = table.Column<int>(nullable: false),
                    PropertyId = table.Column<Guid>(nullable: false),
                    EventId = table.Column<Guid>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delinquency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Delinquency_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delinquency_Event_EventId",
                        column: x => x.EventId,
                        principalSchema: "main",
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Delinquency_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delinquency_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "main",
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAttachment",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    PropertyId = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    FileCreatedOn = table.Column<DateTime>(nullable: false),
                    PropertyAttachmentTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyAttachment_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyAttachment_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyAttachment_PropertyAttachmentType_PropertyAttachmen~",
                        column: x => x.PropertyAttachmentTypeId,
                        principalSchema: "main",
                        principalTable: "PropertyAttachmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyAttachment_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "main",
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyValuation",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    PropertyId = table.Column<Guid>(nullable: false),
                    AppraisedYear = table.Column<int>(nullable: false),
                    LandValue = table.Column<decimal>(nullable: true),
                    ImprovementValue = table.Column<decimal>(nullable: true),
                    AppraisedValue = table.Column<decimal>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyValuation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyValuation_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyValuation_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyValuation_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "main",
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDataCutRule",
                schema: "main",
                columns: table => new
                {
                    EventDataCutStrategyId = table.Column<Guid>(nullable: false),
                    DataCutRuleId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDataCutRule", x => new { x.EventDataCutStrategyId, x.DataCutRuleId });
                    table.ForeignKey(
                        name: "FK_EventDataCutRule_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutRule_DataCutRule_DataCutRuleId",
                        column: x => x.DataCutRuleId,
                        principalSchema: "main",
                        principalTable: "DataCutRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutRule_EventDataCutStrategy_EventDataCutStrategyId",
                        column: x => x.EventDataCutStrategyId,
                        principalSchema: "main",
                        principalTable: "EventDataCutStrategy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutRule_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDecisionLevelUser",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    AssigmentCount = table.Column<int>(nullable: false),
                    EventDecisionLevelId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDecisionLevelUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelUser_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelUser_EventDecisionLevel_EventDecisionLeve~",
                        column: x => x.EventDecisionLevelId,
                        principalSchema: "main",
                        principalTable: "EventDecisionLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelUser_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDecisionLevelUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityContact",
                schema: "main",
                columns: table => new
                {
                    OpportunityId = table.Column<Guid>(nullable: false),
                    ContactId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityContact", x => new { x.OpportunityId, x.ContactId });
                    table.ForeignKey(
                        name: "FK_OpportunityContact_Contact_ContactId",
                        column: x => x.ContactId,
                        principalSchema: "main",
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityContact_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityContact_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityContact_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalSchema: "main",
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpportunityProperty",
                schema: "main",
                columns: table => new
                {
                    PropertyId = table.Column<Guid>(nullable: false),
                    OpportunityId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpportunityProperty", x => new { x.PropertyId, x.OpportunityId });
                    table.ForeignKey(
                        name: "FK_OpportunityProperty_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityProperty_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityProperty_Opportunity_OpportunityId",
                        column: x => x.OpportunityId,
                        principalSchema: "main",
                        principalTable: "Opportunity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpportunityProperty_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "main",
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectingEntity",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    AmountDue = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    CollectingEntityTypeId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectingEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectingEntity_CollectingEntityType_CollectingEntityTypeId",
                        column: x => x.CollectingEntityTypeId,
                        principalSchema: "main",
                        principalTable: "CollectingEntityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectingEntity_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectingEntity_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectingEntity_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decision",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    EventDecisionLevelId = table.Column<Guid>(nullable: false),
                    DecisionTypeId = table.Column<int>(nullable: true),
                    DecisionDate = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decision", x => x.Id);
                    table.UniqueConstraint("AK_Decision_DelinquencyId_EventDecisionLevelId", x => new { x.DelinquencyId, x.EventDecisionLevelId });
                    table.ForeignKey(
                        name: "FK_Decision_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decision_DecisionType_DecisionTypeId",
                        column: x => x.DecisionTypeId,
                        principalSchema: "main",
                        principalTable: "DecisionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Decision_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decision_EventDecisionLevel_EventDecisionLevelId",
                        column: x => x.EventDecisionLevelId,
                        principalSchema: "main",
                        principalTable: "EventDecisionLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decision_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decision_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyComment",
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
                    AuthorId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DelinquencyComment_User_AuthorId",
                        column: x => x.AuthorId,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyComment_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyComment_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyComment_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyPropertyDisplayStrategy",
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
                    PropertyDisplayStrategyId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyPropertyDisplayStrategy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyDisplayStrategy_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyDisplayStrategy_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyDisplayStrategy_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyDisplayStrategy_PropertyDisplayStrategy_~",
                        column: x => x.PropertyDisplayStrategyId,
                        principalSchema: "main",
                        principalTable: "PropertyDisplayStrategy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DelinquencyPropertyScoring",
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
                    PropertyScoring = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelinquencyPropertyScoring", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyScoring_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyScoring_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DelinquencyPropertyScoring_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDataCutDecision",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    EventDataCutStrategyId = table.Column<Guid>(nullable: false),
                    DecisionTypeId = table.Column<int>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDataCutDecision", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventDataCutDecision_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutDecision_DecisionType_DecisionTypeId",
                        column: x => x.DecisionTypeId,
                        principalSchema: "main",
                        principalTable: "DecisionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutDecision_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutDecision_EventDataCutStrategy_EventDataCutStrat~",
                        column: x => x.EventDataCutStrategyId,
                        principalSchema: "main",
                        principalTable: "EventDataCutStrategy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDataCutDecision_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertySupplementalEventData",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    PropertyId = table.Column<Guid>(nullable: false),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                    LastSaleDate = table.Column<DateTime>(nullable: true),
                    LastSaleAmount = table.Column<decimal>(nullable: true),
                    MortgageLender1 = table.Column<string>(nullable: true),
                    MortgageLoanAmount1 = table.Column<decimal>(nullable: true),
                    MortgageOriginationDate1 = table.Column<DateTime>(nullable: true),
                    MortgageMaturityDate1 = table.Column<DateTime>(nullable: true),
                    MortgageLender2 = table.Column<string>(nullable: true),
                    MortgageLoanAmount2 = table.Column<decimal>(nullable: true),
                    MortgageOriginationDate2 = table.Column<DateTime>(nullable: true),
                    MortgageMaturityDate2 = table.Column<DateTime>(nullable: true),
                    InspectorComment = table.Column<string>(nullable: true),
                    InspectorPropertyRating = table.Column<decimal>(nullable: true),
                    InspectorAreaRating = table.Column<decimal>(nullable: true),
                    InspectorOccupied = table.Column<bool>(nullable: true),
                    InspectorRoofCondition = table.Column<string>(nullable: true),
                    InspectorLawnMaintained = table.Column<string>(nullable: true),
                    OpenLiens = table.Column<int>(nullable: true),
                    ClosedLiens = table.Column<int>(nullable: true),
                    RecentBuyerName = table.Column<string>(nullable: true),
                    RecentBuyerRate = table.Column<decimal>(nullable: true),
                    AdvertisementBatch = table.Column<string>(nullable: true),
                    AdvertisementNumber = table.Column<string>(nullable: true),
                    AssessorURL = table.Column<string>(nullable: true),
                    TreasurerURL = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySupplementalEventData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertySupplementalEventData_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertySupplementalEventData_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertySupplementalEventData_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertySupplementalEventData_Property_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "main",
                        principalTable: "Property",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedById = table.Column<Guid>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    BidNumber = table.Column<string>(nullable: true),
                    CertNo = table.Column<string>(nullable: true),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    Overbid = table.Column<decimal>(nullable: true),
                    Premium = table.Column<decimal>(nullable: true),
                    InterestRate = table.Column<decimal>(nullable: false),
                    PenaltyRate = table.Column<decimal>(nullable: true),
                    RecoverableFees = table.Column<decimal>(nullable: true),
                    NonRecoverableFees = table.Column<decimal>(nullable: true),
                    BidId = table.Column<Guid>(nullable: true),
                    DelinquencyId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Result_Bid_BidId",
                        column: x => x.BidId,
                        principalSchema: "main",
                        principalTable: "Bid",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_User_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_Delinquency_DelinquencyId",
                        column: x => x.DelinquencyId,
                        principalSchema: "main",
                        principalTable: "Delinquency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalSchema: "main",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "User",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Email", "FirstName", "LastName", "ModifiedById", "ModifiedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "system@user", "system", "user", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                schema: "main",
                table: "AuctionType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RFP", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "RFP" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auction - Live", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AuctionLive" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auction - Online", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AuctionOnline" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Negotiated Contract", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "NegotiatedContract" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "CampaignFieldType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Text" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numeric" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShortcutedLogicText" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "CampaignType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name", "ParentTypeId" },
                values: new object[,]
                {
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Digital", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digital", null },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Email", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Email", null },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Commerical Trip", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CommericalTrip", null },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mailer", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mailer", null },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Outbound", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Outbound", null },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "CollectingEntityType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "County", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "County" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "City", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "City" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ISD", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ISD" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Other", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Other" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "ContactType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SOS Research", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SOSResearch" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Other", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Other" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DataCutFieldType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numeric" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Text" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DataCutResultType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Data Approve", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "DataApprove" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Data Reject", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "DataReject" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DecisionType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Reject", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reject" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Approve", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approve" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auto Reject", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AutoReject" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auto Approve", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AutoApprove" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Manual Review", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ManualReview" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Research", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Research" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "EventEntity",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CCF II", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CCFII" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CCF 1", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CCF1" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "'Tax Ease Ohio II", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TaxEaseOhioII" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TEF-1", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEF1" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Caz", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caz" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "EventType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "New", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sub", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sub" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Portfolio", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portfolio" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Public Sale", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PublicSale" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "FinalPaymentType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wire", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wire" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Certified Funds", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CertifiedFunds" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Company Check", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "CompanyCheck" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "GeneralLandUseCode",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unknown" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agricultural" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vacant" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commercial" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Residential" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "InternalLandUseCode",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 65, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-SELF-SERVE LAUDROMAT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 64, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-RETAIL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 63, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-RESTAURANT; CAFETERIA AND/OR BAR", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 62, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-RESEARCH & CHEM LAB", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 61, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-REGIONAL SHOPPING CENTER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 60, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-RECREATIONAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 59, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-RADIO/TV STATION", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 58, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-PARKING LOT, STRUCTURE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 57, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-PARKING GARAGE, STRUCTURES & L", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 56, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OTHER INDUSTRIAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 55, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OTHER COMMERCIAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 54, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OFFICE/STORAGE OVER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 53, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OFFICE/APARTMENTS OVER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 52, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OFFICE CONDOMINIUMS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 51, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OFFICE BLDGS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 50, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-OFFICE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 49, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-NURSING HOMES & PRIV HOSPITALS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 48, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-NEIGHBORHOOD SHOPPING CENTER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 47, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MOTELS AND TOURIST CABINS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 66, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-SENIOR COMMUNITY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 46, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MORTUARY/CEMETERY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 67, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-SERVICE SHOP", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 69, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-SUPERMARKETS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 88, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VACANT-NON-AG ACREAGE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 87, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VACANT- RESIDENTIAL LAND", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 86, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VACANT- INDUSTRIAL LAND", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 85, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VACANT- COMMERCIAL LAND", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 84, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-TWO FAMILY DWELLING", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 83, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-THREE FAMILY DWELLING", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 82, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-SINGLE FAMILY RESIDENTIAL (RENTAL PROPERTIES)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 81, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-SINGLE FAMILY DWELLING", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 68, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-SHOPPING CENTER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 80, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-MH & LAND", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 78, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-CONDOMINIUM", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 77, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "GOV-MUNICIPAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 76, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-WAREHOUSES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 75, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-WAREHOUSE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 73, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-TRUCK FARM EQUIP. SALES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 72, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-TRAILER OR MOBILE HOME PARK", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 71, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-TOURIST ATTRACTION", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 70, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-THEATERS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 79, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "RES-FOUR FAMILY DWELLING", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 45, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MIXED USE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 74, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-TRUCK TERMINALS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 43, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MARINE SERVICE FACILITIES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 19, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-DAYCARE - PRIVATE SCHOOL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 18, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-DAIRY/FEED LOT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 16, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-CONDO", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-CLUBS/LODGE HALLS/EVENT HALLS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 44, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MEDICAL CLINICS AND OFFICES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-CHURCH & CHARITABLE LAND", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-CAR WASH", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-CAMP GROUNDS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-BOWLING ALLEYS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-BARS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-BANK", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-AUTOMOTIVE SERVICE STATION", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-AUTOMOBILE CAR SALES & SERVICE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-AUTO RACING/HORSE TRACKS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-AUDITORIUM/THEATER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-APARTMENT RENTAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-ANIMAL CLINIC", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-AIRPORT TERMINAL/HANGER OR BUS TERMINAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AGRICULTURAL-FARM", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 20, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-DOG/CAT KENNELS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 21, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-DRIVE-IN RESTAURANT OR FOOD SERVICE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 17, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-CONVENIENCE STORE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 23, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-DRY CLEANING PLANTS & LAUNDRIES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 42, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MARINA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 41, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MANUFACTURING LIGHT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 40, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-MANUFACTURING HEAVY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 39, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-LODGE HALLS & AMUSEMENT PARKS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 38, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-LIGHT INDUSTRIAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 37, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-INDUSTRIAL CONDO", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 22, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-DRIVING RANGE/MINIATURE GOLF", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 35, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-HOTELS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 34, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-HEALTH CLUB/GYM", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 33, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-GREENHOUSE/NURSERY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 36, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-INDUSTRIAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 31, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-GENERAL STORAGE/MINI-STORAGE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 32, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-GOLF COURSES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 25, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-FOOD SERVICE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 26, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-FOUNDRIES & HEAVY MANUF PLANTS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 24, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-FLORIST/GREENHOUSE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 28, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-FUNERAL HOMES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 29, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-GARAGES", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 30, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-GAS STATION", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                    { 27, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "COM-FULL SERVICE BANKS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), string.Empty },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "LoanType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refi" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consolidation" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "OpportunityStage",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Scheduled", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled" },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Completion", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completion" },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Shipping Expected", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShippingExpected" },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Funded", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Funded" },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Docs Sent", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "DocsSent" },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Denied", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denied" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Initial Contact", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "InitialContact" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Underwriting", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underwriting" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Processing", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Disclosed", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disclosed" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "File Started", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FileStarted" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Verified Prospect", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VerifiedProspect" },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Approved", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "PropertyAttachmentType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aerial", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aerial" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Attachment", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Attachment" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Property Image", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "PropertyImage" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "PropertyDisplayStrategy",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SETTLE WITH OWNER", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SettleWithOwner" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SEEK SIE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SeekSie" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SEEK TO ASSIGN", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SeekToAssign" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FORECLOSRE IMMEDIATELY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForeclorseImmediately" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DO NOT BUY SUBS/NON-ACCRUAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "DoNotBuySubs_NonAccrual" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HOLD", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hold" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "SaleDateStatus",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Estimate", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estimate" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Confirmed", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Confirmed" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "State",
                columns: new[] { "Id", "Abbreviation", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 38, "OR", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oregon" },
                    { 30, "NH", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Hampshire" },
                    { 31, "NJ", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Jersey" },
                    { 32, "NM", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Mexico" },
                    { 29, "NV", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevada" },
                    { 33, "NY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York" },
                    { 34, "NC", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Carolina" },
                    { 35, "ND", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Dakota" },
                    { 36, "OH", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ohio" },
                    { 37, "OK", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oklahoma" },
                    { 39, "PA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pennsylvania" },
                    { 51, "WY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyoming" },
                    { 41, "SC", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Carolina" },
                    { 42, "SD", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Dakota" },
                    { 43, "TN", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee" },
                    { 44, "TX", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Texas" },
                    { 45, "UT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Utah" },
                    { 46, "VT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vermont" },
                    { 47, "VA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia" },
                    { 48, "WA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington" },
                    { 49, "WV", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Virginia" },
                    { 50, "WI", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wisconsin" },
                    { 28, "NE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nebraska" },
                    { 40, "RI", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rhode Island" },
                    { 27, "MT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montana" },
                    { 4, "AR", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arkansas" },
                    { 25, "MS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mississippi" },
                    { 1, "AL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alabama" },
                    { 2, "AK", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alaska" },
                    { 3, "AZ", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arizona" },
                    { 5, "CA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "California" },
                    { 6, "CO", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorado" },
                    { 7, "CT", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connecticut" },
                    { 8, "DE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delaware" },
                    { 9, "DC", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "District Of Columbia" },
                    { 10, "FL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florida" },
                    { 11, "GA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia" },
                    { 12, "HI", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hawaii" },
                    { 13, "ID", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Idaho" },
                    { 14, "IL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illinois" },
                    { 15, "IN", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indiana" },
                    { 16, "IA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iowa" },
                    { 17, "KS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kansas" },
                    { 18, "KY", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kentucky" },
                    { 19, "LA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louisiana" },
                    { 20, "ME", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maine" },
                    { 21, "MD", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maryland" },
                    { 22, "MA", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massachusetts" },
                    { 23, "MI", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michigan" },
                    { 24, "MN", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minnesota" },
                    { 26, "MO", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missouri" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskStatus",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Overdue", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overdue" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "In Progress", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "InProgress" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Completed", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "TaskType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 23, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Certificates (Mail Merge)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Certificates" },
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
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pre-Sale Letters", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PreSaleLetters" },
                    { 24, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Post-Sale Letters (Mail Merge)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PostSaleLetters" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "CampaignLogicType",
                columns: new[] { "Id", "CampaignFieldTypeId", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Contains", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contains" },
                    { 2, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Does Not Contain", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "DoesNotContain" },
                    { 3, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equal" },
                    { 4, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Not Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotEqual" },
                    { 5, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Less Than", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "LessThan" },
                    { 6, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Less Than Or Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "LessThanOrEqual" },
                    { 7, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Greater Than", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GreaterThan" },
                    { 8, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Greater Than Or Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GreaterThanOrEqual" },
                    { 10, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Not Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotEqual" },
                    { 9, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equal" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "CampaignRuleField",
                columns: new[] { "Id", "CampaignFieldTypeId", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 13, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Do Not Contact", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "DoNotContact" },
                    { 12, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Veteran", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veteran" },
                    { 11, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Disability Exemption", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "DisabilityExemption" },
                    { 10, 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Over 65/Surviving Spouse", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Over65/SurvivingSpouse" },
                    { 9, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Appraised Value (of all related properties)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppraisedValueOfProperties) " },
                    { 8, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Appraised Value", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppraisedValue" },
                    { 7, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LTV% (of all related properties)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "LTV%OfProperties" },
                    { 6, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LTV % (LTV% = Total Tax Due / Appraised Value)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "LTV%" },
                    { 5, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Total Amount Due (of all related properties)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "TotalAmountDueProperties)" },
                    { 4, 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Total Amount Due (of a single property)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "TotalAmountDue" },
                    { 3, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "General Land Use Code (Residential or Commercial)", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GeneralLandUseCode" },
                    { 2, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "County", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "County" },
                    { 1, 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Account Name", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "AccountName" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "CampaignType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name", "ParentTypeId" },
                values: new object[,]
                {
                    { 24, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Landing Page", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "LandingPage", 5 },
                    { 23, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Display", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Display", 5 },
                    { 22, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Google Paid", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GooglePaid", 5 },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ETX", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ETX", 4 },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "WTX", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "WTX", 4 },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "STX-Jul", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "STXJul", 4 },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "STX-Mar", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "STXMar", 4 },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HOU-Dec", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HOUDec", 4 },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HOU-Aug", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HOUAug", 4 },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DFW-Jan", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "DFWJan", 4 },
                    { 21, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LO MAIL MERGE", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "LOMAILMERGE", 3 },
                    { 20, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CSR", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSR", 3 },
                    { 19, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DTR", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "DTR", 2 },
                    { 18, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "HISTORICAL LEADS", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HISTORICALLEADS", 2 },
                    { 17, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CSR-REFI", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSRREFI", 2 },
                    { 16, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SPECIAL", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SPECIAL", 1 },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JUN", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "JUN", 1 },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FEB", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FEB", 1 },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DFW-Feb", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "DFWFeb", 4 },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "County",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "Name", "StateId" },
                values: new object[,]
                {
                    { 457, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coshocton", 36 },
                    { 464, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fairfield", 36 },
                    { 463, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erie", 36 },
                    { 462, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delaware", 36 },
                    { 458, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crawford", 36 },
                    { 460, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darke", 36 },
                    { 459, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuyahoga", 36 },
                    { 465, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fayette", 36 },
                    { 461, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Defiance", 36 },
                    { 466, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin", 36 },
                    { 471, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guernsey", 36 },
                    { 468, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gallia", 36 },
                    { 469, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geauga", 36 },
                    { 470, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greene", 36 },
                    { 472, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamilton", 36 },
                    { 473, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hancock", 36 },
                    { 474, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardin", 36 },
                    { 475, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison", 36 },
                    { 476, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", 36 },
                    { 467, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fulton", 36 },
                    { 456, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbiana", 36 },
                    { 435, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Long Branch Borough (Monmouth)", 31 },
                    { 454, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clermont", 36 },
                    { 477, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Highland", 36 },
                    { 436, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Milford Township (Passaic)", 31 },
                    { 437, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Westampton Township (Burlington)", 31 },
                    { 438, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willingboro Township (Burlington)", 31 },
                    { 439, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodbridge Township (Middlesex)", 31 },
                    { 440, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodbury City (Gloucester)", 31 },
                    { 441, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nassau", 33 },
                    { 442, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adams", 36 },
                    { 443, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", 36 },
                    { 444, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashland", 36 },
                    { 445, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashtabula", 36 },
                    { 446, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athens", 36 },
                    { 447, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auglaize", 36 },
                    { 448, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belmont", 36 },
                    { 449, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", 36 },
                    { 450, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butler", 36 },
                    { 451, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carroll", 36 },
                    { 452, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Champaign", 36 },
                    { 453, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", 36 },
                    { 455, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clinton", 36 },
                    { 478, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hocking", 36 },
                    { 499, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", 36 },
                    { 480, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huron", 36 },
                    { 505, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perry", 36 },
                    { 506, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pickaway", 36 },
                    { 507, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pike", 36 },
                    { 508, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portage", 36 },
                    { 509, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preble", 36 },
                    { 510, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Putnam", 36 },
                    { 511, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richland", 36 },
                    { 512, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross", 36 },
                    { 513, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandusky", 36 },
                    { 514, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scioto", 36 },
                    { 515, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seneca", 36 },
                    { 516, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelby", 36 },
                    { 517, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stark", 36 },
                    { 518, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summit", 36 },
                    { 519, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trumbull", 36 },
                    { 520, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuscarawas", 36 },
                    { 521, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Union", 36 },
                    { 522, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van Wert", 36 },
                    { 523, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinton", 36 },
                    { 504, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paulding", 36 },
                    { 503, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ottawa", 36 },
                    { 502, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noble", 36 },
                    { 501, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muskingum", 36 },
                    { 481, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 36 },
                    { 482, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jefferson", 36 },
                    { 483, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knox", 36 },
                    { 484, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lake", 36 },
                    { 485, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lawrence", 36 },
                    { 486, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licking", 36 },
                    { 487, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", 36 },
                    { 488, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorain", 36 },
                    { 489, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucas", 36 },
                    { 479, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holmes", 36 },
                    { 490, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", 36 },
                    { 492, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion", 36 },
                    { 493, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medina", 36 },
                    { 494, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meigs", 36 },
                    { 495, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercer", 36 },
                    { 496, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", 36 },
                    { 497, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monroe", 36 },
                    { 498, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montgomery", 36 },
                    { 434, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wenonah Borough (Gloucester)", 31 },
                    { 500, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morrow", 36 },
                    { 491, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mahoning", 36 },
                    { 433, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Weehawken Township (Hudson)", 31 },
                    { 412, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Amboy City (Middlesex)", 31 },
                    { 431, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington Township (Gloucester)", 31 },
                    { 365, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marlboro Township (Monmouth)", 31 },
                    { 366, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matawan Borough (Monmouth)", 31 },
                    { 367, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medford Township (Burlington)", 31 },
                    { 368, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Millstone Township (Monmouth)", 31 },
                    { 369, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Millville City (Cumberland)", 31 },
                    { 370, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monroe Township (Middlesex)", 31 },
                    { 371, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montague Township (Sussex)", 31 },
                    { 372, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montclair Township (Essex)", 31 },
                    { 373, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morristown Town (Morris)", 31 },
                    { 374, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mount Holly Township (Burlington)", 31 },
                    { 375, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neptune City Borough (Monmouth)", 31 },
                    { 376, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neptune Township (Monmouth)", 31 },
                    { 377, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newark City (Essex)", 31 },
                    { 378, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Arlington Borough (Bergen)", 31 },
                    { 379, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Haledon Borough (Passaic)", 31 },
                    { 380, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "North Plainfield Borough (Somerset)", 31 },
                    { 381, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nutley Township (Essex)", 31 },
                    { 382, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oakland Borough (Bergen)", 31 },
                    { 383, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ocean Township (Monmouth)", 31 },
                    { 364, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maplewood Township (Essex)", 31 },
                    { 384, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oldmans Township (Salem)", 31 },
                    { 363, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manville Borough (Somerset)", 31 },
                    { 361, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long Hill Township (Morris)", 31 },
                    { 342, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamilton Township (Mercer)", 31 },
                    { 343, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hazlet Township (Monmouth)", 31 },
                    { 344, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Highland Park Borough (Middlesex)", 31 },
                    { 345, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Highlands Borough (Monmouth)", 31 },
                    { 346, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hillsborough Township (Somerset)", 31 },
                    { 347, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoboken City (Hudson)", 31 },
                    { 348, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hopatcong Borough (Sussex)", 31 },
                    { 349, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hopewell Township (Cumberland)", 31 },
                    { 350, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Howell Township (Monmouth)", 31 },
                    { 351, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irvington Township (Essex)", 31 },
                    { 352, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson Township (Ocean)", 31 },
                    { 353, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jersey City (Hudson)", 31 },
                    { 354, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lacey Township (Ocean)", 31 },
                    { 355, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lakewood Township (Ocean)", 31 },
                    { 356, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lambertville City (Hunterdon)", 31 },
                    { 357, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linden City (Union)", 31 },
                    { 358, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindenwold Borough (Camden)", 31 },
                    { 359, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Falls Township (Passaic)", 31 },
                    { 360, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Livingston Township (Essex)", 31 },
                    { 362, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manasquan Borough (Monmouth)", 31 },
                    { 385, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oxford Township (Warren)", 31 },
                    { 386, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parsippany-Troy Hills Township (Morris)", 31 },
                    { 387, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Passaic City (Passaic)", 31 },
                    { 524, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warren", 36 },
                    { 413, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Orange Village Township (Essex)", 31 },
                    { 414, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Plainfield Borough (Middlesex)", 31 },
                    { 415, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Southampton Township (Burlington)", 31 },
                    { 416, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Springfield Township (Union)", 31 },
                    { 417, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stafford Township (Ocean)", 31 },
                    { 418, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teaneck Township (Bergen)", 31 },
                    { 419, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toms River Township (Ocean)", 31 },
                    { 420, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trenton City (Mercer)", 31 },
                    { 421, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuckerton Borough (Ocean)", 31 },
                    { 422, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Union Beach Borough (Monmouth)", 31 },
                    { 423, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Union City (Hudson)", 31 },
                    { 424, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upper Deerfield Township", 31 },
                    { 425, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upper Deerfield Township (Cumberland)", 31 },
                    { 426, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upper Saddle River Borough (Bergen)", 31 },
                    { 427, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ventnor City (Atlantic)", 31 },
                    { 428, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vernon Township (Sussex)", 31 },
                    { 429, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voorhees Township (Camden)", 31 },
                    { 430, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wall Township (Monmouth)", 31 },
                    { 411, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somers Point City (Atlantic)", 31 },
                    { 410, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seaside Heights Borough (Ocean)", 31 },
                    { 409, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salem City (Salem)", 31 },
                    { 408, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Runnemede Borough (Camden)", 31 },
                    { 388, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paterson City (Passaic)", 31 },
                    { 389, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pemberton Borough (Burlington)", 31 },
                    { 390, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pemberton Township (Burlington)", 31 },
                    { 391, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Penns Grove Borough (Salem)", 31 },
                    { 392, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pennsauken Township (Camden)", 31 },
                    { 393, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pennsville Township (Salem)", 31 },
                    { 394, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequannock Township (Morris)", 31 },
                    { 395, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phillipsburg Town (Warren)", 31 },
                    { 396, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pine Hill Borough (Camden)", 31 },
                    { 432, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington Township (Morris)", 31 },
                    { 397, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitman Borough (Gloucester)", 31 },
                    { 399, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plainsboro Township (Middlesex)", 31 },
                    { 400, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pleasantville City (Atlantic)", 31 },
                    { 401, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plumsted Township (Ocean)", 31 },
                    { 402, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Point Pleasant Borough (Ocean)", 31 },
                    { 403, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pompton Lakes Borough (Passaic)", 31 },
                    { 404, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahway City (Union)", 31 },
                    { 405, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randolph Township (Morris)", 31 },
                    { 406, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Bank Borough (Monmouth)", 31 },
                    { 407, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rockaway Township (Morris)", 31 },
                    { 398, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pittsgrove Township (Salem)", 31 },
                    { 525, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", 36 },
                    { 546, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorchester", 41 },
                    { 527, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", 36 },
                    { 645, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lamar", 44 },
                    { 646, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", 44 },
                    { 647, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leon", 44 },
                    { 648, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liberty", 44 },
                    { 649, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limestone", 44 },
                    { 650, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Live Oak", 44 },
                    { 651, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lubbock", 44 },
                    { 652, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matagorda", 44 },
                    { 653, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maverick", 44 },
                    { 654, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McLennan", 44 },
                    { 655, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medina", 44 },
                    { 656, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midland", 44 },
                    { 657, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milam", 44 },
                    { 658, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mills", 44 },
                    { 659, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitchell", 44 },
                    { 660, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montague", 44 },
                    { 661, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montgomery", 44 },
                    { 662, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morris", 44 },
                    { 663, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nacogdoches", 44 },
                    { 644, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kleberg", 44 },
                    { 664, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navarro", 44 },
                    { 643, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kendall", 44 },
                    { 641, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jones", 44 },
                    { 622, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamilton", 44 },
                    { 623, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardin", 44 },
                    { 624, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", 44 },
                    { 625, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison", 44 },
                    { 626, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hays", 44 },
                    { 627, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henderson", 44 },
                    { 628, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hidalgo", 44 },
                    { 629, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hill", 44 },
                    { 630, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hood", 44 },
                    { 631, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", 44 },
                    { 632, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Howard", 44 },
                    { 633, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hunt", 44 },
                    { 634, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hutchinson", 44 },
                    { 635, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", 44 },
                    { 636, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 44 },
                    { 637, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasper", 44 },
                    { 638, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jefferson", 44 },
                    { 639, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jim Wells", 44 },
                    { 640, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", 44 },
                    { 642, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaufman", 44 },
                    { 665, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nolan", 44 },
                    { 666, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nueces", 44 },
                    { 667, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", 44 },
                    { 692, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler", 44 },
                    { 693, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upshur", 44 },
                    { 694, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uvalde", 44 },
                    { 695, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Val Verde", 44 },
                    { 696, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van Zandt", 44 },
                    { 697, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria", 44 },
                    { 698, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker", 44 },
                    { 699, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waller", 44 },
                    { 700, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", 44 },
                    { 701, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webb", 44 },
                    { 702, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wharton", 44 },
                    { 703, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wheeler", 44 },
                    { 704, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wichita", 44 },
                    { 705, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilbarger", 44 },
                    { 706, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willacy", 44 },
                    { 707, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williamson", 44 },
                    { 708, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", 44 },
                    { 709, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wise", 44 },
                    { 710, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood", 44 },
                    { 691, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trinity", 44 },
                    { 690, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis", 44 },
                    { 689, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Green", 44 },
                    { 688, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", 44 },
                    { 668, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palo Pinto", 44 },
                    { 669, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parker", 44 },
                    { 670, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polk", 44 },
                    { 671, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potter", 44 },
                    { 672, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rains", 44 },
                    { 673, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randall", 44 },
                    { 674, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reeves", 44 },
                    { 675, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robertson", 44 },
                    { 676, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rockwall", 44 },
                    { 621, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hale", 44 },
                    { 677, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Runnels", 44 },
                    { 679, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabine", 44 },
                    { 680, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Augustine", 44 },
                    { 681, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Jacinto", 44 },
                    { 682, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Patricio", 44 },
                    { 683, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelby", 44 },
                    { 684, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", 44 },
                    { 685, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somervell", 44 },
                    { 686, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starr", 44 },
                    { 687, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarrant", 44 },
                    { 678, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rusk", 44 },
                    { 620, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guadalupe", 44 },
                    { 619, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grimes", 44 },
                    { 618, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gregg", 44 },
                    { 552, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hampton", 41 },
                    { 553, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horry", 41 },
                    { 554, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasper", 41 },
                    { 555, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kershaw", 41 },
                    { 556, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lancaster", 41 },
                    { 557, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laurens", 41 },
                    { 558, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexington", 41 },
                    { 559, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion", 41 },
                    { 560, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marlboro", 41 },
                    { 561, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McCormick", 41 },
                    { 562, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newberry", 41 },
                    { 563, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oconee", 41 },
                    { 564, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orangeburg", 41 },
                    { 565, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pickens", 41 },
                    { 566, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Richland", 41 },
                    { 567, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spartanburg", 41 },
                    { 568, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sumter", 41 },
                    { 569, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williamsburg", 41 },
                    { 570, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "York", 41 },
                    { 551, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greenwood", 41 },
                    { 550, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greenville", 41 },
                    { 549, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgetown", 41 },
                    { 548, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florence", 41 },
                    { 528, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood", 36 },
                    { 529, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wyandot", 36 },
                    { 530, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abbeville", 41 },
                    { 531, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aiken", 41 },
                    { 532, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 41 },
                    { 533, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bamberg", 41 },
                    { 534, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barnwell", 41 },
                    { 535, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beaufort", 41 },
                    { 536, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berkeley", 41 },
                    { 571, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davidson", 43 },
                    { 537, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calhoun", 41 },
                    { 539, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cherokee", 41 },
                    { 540, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chester", 41 },
                    { 541, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chesterfield", 41 },
                    { 542, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clarendon", 41 },
                    { 543, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colleton", 41 },
                    { 544, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darlington", 41 },
                    { 545, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dillon", 41 },
                    { 341, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haddon Township (Camden)", 31 },
                    { 547, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edgefield", 41 },
                    { 538, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charleston", 41 },
                    { 526, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", 36 },
                    { 572, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 44 },
                    { 574, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aransas", 44 },
                    { 599, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooke", 44 },
                    { 600, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coryell", 44 },
                    { 601, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", 44 },
                    { 602, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denton", 44 },
                    { 603, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dickens", 44 },
                    { 604, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastland", 44 },
                    { 605, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ector", 44 },
                    { 606, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Paso", 44 },
                    { 607, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ellis", 44 },
                    { 608, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fannin", 44 },
                    { 609, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fayette", 44 },
                    { 610, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floyd", 44 },
                    { 611, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foard", 44 },
                    { 612, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fort Bend", 44 },
                    { 613, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin", 44 },
                    { 614, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freestone", 44 },
                    { 615, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galveston", 44 },
                    { 616, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gonzales", 44 },
                    { 617, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grayson", 44 },
                    { 598, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comal", 44 },
                    { 597, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colorado", 44 },
                    { 596, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collingsworth", 44 },
                    { 595, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collin", 44 },
                    { 575, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Archer", 44 },
                    { 576, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atascosa", 44 },
                    { 577, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bandera", 44 },
                    { 578, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bastrop", 44 },
                    { 579, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bell", 44 },
                    { 580, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bexar", 44 },
                    { 581, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bosque", 44 },
                    { 582, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bowie", 44 },
                    { 583, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazoria", 44 },
                    { 573, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angelina", 44 },
                    { 584, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazos", 44 },
                    { 586, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burnet", 44 },
                    { 587, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caldwell", 44 },
                    { 588, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calhoun", 44 },
                    { 589, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cameron", 44 },
                    { 590, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cass", 44 },
                    { 591, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Castro", 44 },
                    { 592, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chambers", 44 },
                    { 593, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cherokee", 44 },
                    { 594, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay", 44 },
                    { 585, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", 44 },
                    { 340, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gloucester Township (Camden)", 31 },
                    { 322, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deptford Township (Gloucester)", 31 },
                    { 338, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Glassboro Borough (Gloucester)", 31 },
                    { 111, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", 14 },
                    { 112, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dupage", 14 },
                    { 113, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Effingham", 14 },
                    { 114, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford", 14 },
                    { 115, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fulton", 14 },
                    { 116, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", 14 },
                    { 117, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 14 },
                    { 118, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kane", 14 },
                    { 119, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kankakee", 14 },
                    { 120, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lake", 14 },
                    { 121, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lasalle", 14 },
                    { 122, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Livingston", 14 },
                    { 123, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", 14 },
                    { 124, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macon", 14 },
                    { 125, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Macoupin", 14 },
                    { 126, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", 14 },
                    { 127, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshall", 14 },
                    { 110, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "DeWitt", 14 },
                    { 109, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cook", 14 },
                    { 108, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coles", 14 },
                    { 107, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Champaign", 14 },
                    { 88, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Palm Beach", 10 },
                    { 89, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasco", 10 },
                    { 90, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinellas", 10 },
                    { 91, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polk", 10 },
                    { 92, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Putnam", 10 },
                    { 93, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa Rosa", 10 },
                    { 94, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarasota", 10 },
                    { 95, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seminole", 10 },
                    { 128, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McDonough", 14 },
                    { 96, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "St Johns", 10 },
                    { 98, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sumter", 10 },
                    { 99, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suwannee", 10 },
                    { 100, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", 10 },
                    { 101, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volusia", 10 },
                    { 102, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wakulla", 10 },
                    { 103, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walton", 10 },
                    { 104, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", 10 },
                    { 106, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boone", 14 },
                    { 97, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "St Lucie", 10 },
                    { 87, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osceola", 10 },
                    { 129, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McHenry", 14 },
                    { 131, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Menard", 14 },
                    { 154, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delaware", 15 },
                    { 155, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elkhart", 15 },
                    { 156, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floyd", 15 },
                    { 339, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gloucester City (Camden)", 31 },
                    { 158, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamilton", 15 },
                    { 159, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hendricks", 15 },
                    { 160, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", 15 },
                    { 161, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Howard", 15 },
                    { 162, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huntington", 15 },
                    { 163, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", 15 },
                    { 164, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kosciusko", 15 },
                    { 165, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lake", 15 },
                    { 166, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", 15 },
                    { 167, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion", 15 },
                    { 168, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monroe", 15 },
                    { 169, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montgomery", 15 },
                    { 170, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porter", 15 },
                    { 153, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dekalb", 15 },
                    { 152, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dearborn", 15 },
                    { 151, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crawford", 15 },
                    { 150, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cass", 15 },
                    { 132, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercer", 14 },
                    { 133, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monroe", 14 },
                    { 134, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peoria", 14 },
                    { 135, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piatt", 14 },
                    { 136, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock Island", 14 },
                    { 137, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saline", 14 },
                    { 138, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sangamon", 14 },
                    { 139, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelby", 14 },
                    { 130, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McLean", 14 },
                    { 140, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "St Clair", 14 },
                    { 142, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stephenson", 14 },
                    { 143, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tazewell", 14 },
                    { 144, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vermilion", 14 },
                    { 145, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Will", 14 },
                    { 146, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williamson", 14 },
                    { 147, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winnebago", 14 },
                    { 148, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodford", 14 },
                    { 149, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", 15 },
                    { 141, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stark", 14 },
                    { 86, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", 10 },
                    { 85, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Okeechobee", 10 },
                    { 84, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Okaloosa", 10 },
                    { 23, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coconino", 3 },
                    { 24, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graham", 3 },
                    { 25, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "La Paz", 3 },
                    { 26, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maricopa", 3 },
                    { 27, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohave", 3 },
                    { 28, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navajo", 3 },
                    { 29, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pima", 3 },
                    { 30, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinal", 3 },
                    { 31, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa Cruz", 3 },
                    { 32, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yavapai", 3 },
                    { 33, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yuma", 3 },
                    { 34, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ansonia", 7 },
                    { 35, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bridgeport", 7 },
                    { 36, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheshire", 7 },
                    { 37, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danbury", 7 },
                    { 38, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Hartford", 7 },
                    { 39, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fairfield", 7 },
                    { 22, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cochise", 3 },
                    { 21, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apache", 3 },
                    { 20, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Talladega", 1 },
                    { 19, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "St. Clair", 1 },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autauga", 1 },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baldwin", 1 },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blount", 1 },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calhoun", 1 },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colbert", 1 },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cullman", 1 },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "DeKalb", 1 },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Etowah", 1 },
                    { 40, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milford", 7 },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin", 1 },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jefferson", 1 },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauderdale", 1 },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", 1 },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", 1 },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshall", 1 },
                    { 16, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobile", 1 },
                    { 17, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", 1 },
                    { 18, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelby", 1 },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 1 },
                    { 41, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Haven", 7 },
                    { 42, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "District Of Columbia", 9 },
                    { 43, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", 9 },
                    { 66, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hendry", 10 },
                    { 67, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernando", 10 },
                    { 68, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Highlands", 10 },
                    { 69, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hillsborough", 10 },
                    { 70, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holmes", 10 },
                    { 71, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian River", 10 },
                    { 72, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 10 },
                    { 73, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jefferson", 10 },
                    { 65, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardee", 10 },
                    { 74, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lake", 10 },
                    { 76, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leon", 10 },
                    { 77, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Levy", 10 },
                    { 78, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", 10 },
                    { 79, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manatee", 10 },
                    { 80, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion", 10 },
                    { 81, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", 10 },
                    { 82, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monroe", 10 },
                    { 83, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nassau", 10 },
                    { 75, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", 10 },
                    { 171, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelby", 15 },
                    { 64, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamilton", 10 },
                    { 62, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gilchrist", 10 },
                    { 44, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alachua", 10 },
                    { 45, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bay", 10 },
                    { 46, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradford", 10 },
                    { 47, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brevard", 10 },
                    { 48, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broward", 10 },
                    { 49, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calhoun", 10 },
                    { 50, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlotte", 10 },
                    { 51, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrus", 10 },
                    { 63, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gulf", 10 },
                    { 52, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay", 10 },
                    { 54, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbia", 10 },
                    { 55, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dade", 10 },
                    { 56, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "De Soto", 10 },
                    { 57, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dixie", 10 },
                    { 58, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duval", 10 },
                    { 59, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escambia", 10 },
                    { 60, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flagler", 10 },
                    { 61, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gadsden", 10 },
                    { 53, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Collier", 10 },
                    { 172, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "St Josephs", 15 },
                    { 157, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grant", 15 },
                    { 174, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steuben", 15 },
                    { 276, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owen", 18 },
                    { 277, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Owsley", 18 },
                    { 278, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pendleton", 18 },
                    { 279, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perry", 18 },
                    { 280, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pike", 18 },
                    { 281, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powell", 18 },
                    { 282, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulaski", 18 },
                    { 283, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robertson", 18 },
                    { 275, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oldham", 18 },
                    { 284, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rockcastle", 18 },
                    { 286, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russell", 18 },
                    { 287, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", 18 },
                    { 288, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelby", 18 },
                    { 289, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simpson", 18 },
                    { 290, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spencer", 18 },
                    { 291, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", 18 },
                    { 292, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Todd", 18 },
                    { 293, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trigg", 18 },
                    { 285, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rowan", 18 },
                    { 294, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trimble", 18 },
                    { 274, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ohio", 18 },
                    { 272, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson", 18 },
                    { 254, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madison", 18 },
                    { 255, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magoffin", 18 },
                    { 256, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion", 18 },
                    { 257, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marshall", 18 },
                    { 258, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", 18 },
                    { 259, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mason", 18 },
                    { 260, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mayfield", 18 },
                    { 261, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McCracken", 18 },
                    { 273, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", 18 },
                    { 262, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McCreary", 18 },
                    { 264, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meade", 18 },
                    { 265, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Menifee", 18 },
                    { 173, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starke", 15 },
                    { 267, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metcalfe", 18 },
                    { 268, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monroe", 18 },
                    { 269, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montgomery", 18 },
                    { 270, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan", 18 },
                    { 271, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muhlenberg", 18 },
                    { 263, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "McLean", 18 },
                    { 253, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lyon", 18 },
                    { 295, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Union", 18 },
                    { 297, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Washington", 18 },
                    { 320, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closter Borough (Bergen)", 31 },
                    { 321, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commercial Township (Cumberland)", 31 },
                    { 711, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Young", 44 },
                    { 323, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dumont Borough (Bergen)", 31 },
                    { 324, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Hanover Township (Morris)", 31 },
                    { 325, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "East Orange City (Essex)", 31 },
                    { 326, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egg Harbor Township (Atlantic)", 31 },
                    { 327, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth City (Union)", 31 },
                    { 319, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clifton City (Passaic)", 31 },
                    { 328, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmer Borough (Salem)", 31 },
                    { 330, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elsinboro Township (Salem)", 31 },
                    { 331, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Englewood City (Bergen)", 31 },
                    { 332, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evesham Township (Burlington)", 31 },
                    { 333, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fairview Borough (Bergen)", 31 },
                    { 334, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Florence Township (Burlington)", 31 },
                    { 335, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin Township (Somerset)", 31 },
                    { 336, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galloway Township (Atlantic)", 31 },
                    { 337, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gibbsboro Borough (Camden)", 31 },
                    { 329, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmwood Park Borough (Bergen)", 31 },
                    { 296, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warren", 18 },
                    { 318, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark Township (Union)", 31 },
                    { 316, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carteret Borough (Middlesex)", 31 },
                    { 298, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", 18 },
                    { 299, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Webster", 18 },
                    { 300, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whitley", 18 },
                    { 301, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wolfe", 18 },
                    { 302, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodford", 18 },
                    { 303, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas", 28 },
                    { 304, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aberdeen Township (Monmouth)", 31 },
                    { 305, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Absecon City (Atlantic)", 31 },
                    { 317, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cherry Hill Township (Camden)", 31 },
                    { 306, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asbury Park City (Monmouth)", 31 },
                    { 308, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bellmawr Borough (Camden)", 31 },
                    { 309, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly City (Burlington)", 31 },
                    { 310, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brick Township (Ocean)", 31 },
                    { 311, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bridgeton City (Cumberland)", 31 },
                    { 312, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bridgewater Township (Somerset)", 31 },
                    { 313, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burlington Township (Burlington)", 31 },
                    { 314, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camden City (Camden)", 31 },
                    { 315, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carneys Point Township (Salem)", 31 },
                    { 307, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bayonne City (Hudson)", 31 },
                    { 252, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", 18 },
                    { 266, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercer", 18 },
                    { 250, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lincoln", 18 },
                    { 195, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bullitt", 18 },
                    { 196, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butler", 18 },
                    { 197, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caldwell", 18 },
                    { 198, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calloway", 18 },
                    { 199, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campbell", 18 },
                    { 200, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlisle", 18 },
                    { 201, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carroll", 18 },
                    { 251, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Livingston", 18 },
                    { 203, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casey", 18 },
                    { 204, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", 18 },
                    { 205, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", 18 },
                    { 206, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLAY", 18 },
                    { 207, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clinton", 18 },
                    { 208, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crittenden", 18 },
                    { 209, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumberland", 18 },
                    { 210, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daviess", 18 },
                    { 211, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edmonson", 18 },
                    { 194, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breckinridge", 18 },
                    { 212, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elliott", 18 },
                    { 193, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathitt", 18 },
                    { 191, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boyle", 18 },
                    { 175, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tippecanoe", 15 },
                    { 176, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vanderburgh", 15 },
                    { 177, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vigo", 15 },
                    { 178, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warrick", 15 },
                    { 179, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", 15 },
                    { 105, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Hawk", 16 },
                    { 180, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adair", 18 },
                    { 181, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", 18 },
                    { 182, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 18 },
                    { 183, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Augusta", 18 },
                    { 184, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ballard", 18 },
                    { 185, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barren", 18 },
                    { 186, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bath", 18 },
                    { 187, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bell", 18 },
                    { 188, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boone", 18 },
                    { 189, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bourbon", 18 },
                    { 190, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boyd", 18 },
                    { 192, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bracken", 18 },
                    { 213, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estill", 18 },
                    { 202, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carter", 18 },
                    { 215, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fleming", 18 },
                    { 232, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henderson", 18 },
                    { 233, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry", 18 },
                    { 234, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hickman", 18 },
                    { 235, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hopkins", 18 },
                    { 236, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 18 },
                    { 237, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jefferson", 18 },
                    { 238, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessamine", 18 },
                    { 239, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", 18 },
                    { 231, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hart", 18 },
                    { 214, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fayette", 18 },
                    { 242, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knox", 18 },
                    { 243, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Larue", 18 },
                    { 244, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laurel", 18 },
                    { 245, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lawrence", 18 },
                    { 246, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", 18 },
                    { 247, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leslie", 18 },
                    { 248, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Letcher", 18 },
                    { 249, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lewis", 18 },
                    { 241, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knott", 18 },
                    { 230, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison", 18 },
                    { 240, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenton", 18 },
                    { 229, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harlan", 18 },
                    { 216, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Floyd", 18 },
                    { 217, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin", 18 },
                    { 218, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fulton", 18 },
                    { 219, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gallatin", 18 },
                    { 221, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerrard", 18 },
                    { 222, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grant", 18 },
                    { 223, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graves", 18 },
                    { 224, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grayson", 18 },
                    { 220, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garrard", 18 },
                    { 228, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardin", 18 },
                    { 225, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green", 18 },
                    { 226, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greenup", 18 },
                    { 227, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hancock", 18 },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DataCutLogicType",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DataCutFieldTypeId", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Contains", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contains" },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Greater Than Or Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "GreaterThanOrEqual" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Does Not Contain", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "DoesNotContain" },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Greater Than", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "GreaterThan" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Less Than Or Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LessThanOrEqual" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Not Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotEqual" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Equal", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equal" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Less Than", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LessThan" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "DataCutRuleField",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DataCutFieldTypeId", "DeletedOn", "Description", "ModifiedById", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Improvement Value", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ImprovementValue" },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Appraised Value", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppraisedValue" },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Amount Due", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AmountDue" },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Open Liens", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "OpenLiens" },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Closed Liens", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ClosedLiens" },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "LTV%", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LTVPercent" },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Horizon LTV%", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "HorizonLTVPercent" },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "RU LTV%", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "RULTVPercent" },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Property Address", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "PropertyAddress" },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Property Zip Code", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "PropertyZipCode" },
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Land Use Code", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LandUseCode" },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "Account Name", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AccountName" },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "General Land Use Code", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "GeneralLandUseCode" },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Tax Ratio%", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "TaxRatioPercent" },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "Land Value", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "LandValue" },
                });

            migrationBuilder.InsertData(
                schema: "main",
                table: "StateTaxe",
                columns: new[] { "Id", "CreatedById", "CreatedOn", "DeletedOn", "ModifiedById", "ModifiedOn", "StateId", "TaxRate" },
                values: new object[,]
                {
                    { 4, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0.56m },
                    { 3, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2.02m },
                    { 7, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 0.87m },
                    { 5, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1.5m },
                    { 10, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2.4m },
                    { 8, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 0.85m },
                    { 11, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1.65m },
                    { 9, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1.83m },
                    { 12, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1.56m },
                    { 2, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0.77m },
                    { 1, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0.43m },
                    { 13, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 0.57m },
                    { 6, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2.32m },
                    { 14, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 0.75m },
                    { 15, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1.86m },
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionType_CreatedById",
                schema: "main",
                table: "AuctionType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionType_ModifiedById",
                schema: "main",
                table: "AuctionType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_CreatedById",
                schema: "main",
                table: "Bid",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_ModifiedById",
                schema: "main",
                table: "Bid",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_EventId_Number",
                schema: "main",
                table: "Bid",
                columns: new[] { "EventId", "Number" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_AssignedUserId",
                schema: "main",
                table: "Campaign",
                column: "AssignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_CampaignSubTypeId",
                schema: "main",
                table: "Campaign",
                column: "CampaignSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_CampaignTypeId",
                schema: "main",
                table: "Campaign",
                column: "CampaignTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_CountyId",
                schema: "main",
                table: "Campaign",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_CreatedById",
                schema: "main",
                table: "Campaign",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_ModifiedById",
                schema: "main",
                table: "Campaign",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignComment_AuthorId",
                schema: "main",
                table: "CampaignComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignComment_CampaignId",
                schema: "main",
                table: "CampaignComment",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignComment_CreatedById",
                schema: "main",
                table: "CampaignComment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignComment_ModifiedById",
                schema: "main",
                table: "CampaignComment",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignFieldType_CreatedById",
                schema: "main",
                table: "CampaignFieldType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignFieldType_ModifiedById",
                schema: "main",
                table: "CampaignFieldType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLead_CreatedById",
                schema: "main",
                table: "CampaignLead",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLead_LeadId",
                schema: "main",
                table: "CampaignLead",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLead_ModifiedById",
                schema: "main",
                table: "CampaignLead",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLogicType_CampaignFieldTypeId",
                schema: "main",
                table: "CampaignLogicType",
                column: "CampaignFieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLogicType_CreatedById",
                schema: "main",
                table: "CampaignLogicType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignLogicType_ModifiedById",
                schema: "main",
                table: "CampaignLogicType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRule_CreatedById",
                schema: "main",
                table: "CampaignRule",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRule_ModifiedById",
                schema: "main",
                table: "CampaignRule",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleCampaign_CampaignRuleId",
                schema: "main",
                table: "CampaignRuleCampaign",
                column: "CampaignRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleCampaign_CreatedById",
                schema: "main",
                table: "CampaignRuleCampaign",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleCampaign_ModifiedById",
                schema: "main",
                table: "CampaignRuleCampaign",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleField_CampaignFieldTypeId",
                schema: "main",
                table: "CampaignRuleField",
                column: "CampaignFieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleField_CreatedById",
                schema: "main",
                table: "CampaignRuleField",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleField_ModifiedById",
                schema: "main",
                table: "CampaignRuleField",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleItem_CampaignLogicTypeId",
                schema: "main",
                table: "CampaignRuleItem",
                column: "CampaignLogicTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleItem_CampaignRuleFieldId",
                schema: "main",
                table: "CampaignRuleItem",
                column: "CampaignRuleFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleItem_CampaignRuleId",
                schema: "main",
                table: "CampaignRuleItem",
                column: "CampaignRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleItem_CreatedById",
                schema: "main",
                table: "CampaignRuleItem",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignRuleItem_ModifiedById",
                schema: "main",
                table: "CampaignRuleItem",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignType_CreatedById",
                schema: "main",
                table: "CampaignType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignType_ModifiedById",
                schema: "main",
                table: "CampaignType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignType_ParentTypeId",
                schema: "main",
                table: "CampaignType",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectingEntity_CollectingEntityTypeId",
                schema: "main",
                table: "CollectingEntity",
                column: "CollectingEntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectingEntity_CreatedById",
                schema: "main",
                table: "CollectingEntity",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CollectingEntity_DelinquencyId",
                schema: "main",
                table: "CollectingEntity",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectingEntity_ModifiedById",
                schema: "main",
                table: "CollectingEntity",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_CollectingEntityType_CreatedById",
                schema: "main",
                table: "CollectingEntityType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CollectingEntityType_ModifiedById",
                schema: "main",
                table: "CollectingEntityType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactTypeId",
                schema: "main",
                table: "Contact",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CreatedById",
                schema: "main",
                table: "Contact",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_LeadId",
                schema: "main",
                table: "Contact",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_MailingStateId",
                schema: "main",
                table: "Contact",
                column: "MailingStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ModifiedById",
                schema: "main",
                table: "Contact",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ContactType_CreatedById",
                schema: "main",
                table: "ContactType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ContactType_ModifiedById",
                schema: "main",
                table: "ContactType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_County_CreatedById",
                schema: "main",
                table: "County",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_County_ModifiedById",
                schema: "main",
                table: "County",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_County_StateId",
                schema: "main",
                table: "County",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutFieldType_CreatedById",
                schema: "main",
                table: "DataCutFieldType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutFieldType_ModifiedById",
                schema: "main",
                table: "DataCutFieldType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutLogicType_CreatedById",
                schema: "main",
                table: "DataCutLogicType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutLogicType_DataCutFieldTypeId",
                schema: "main",
                table: "DataCutLogicType",
                column: "DataCutFieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutLogicType_ModifiedById",
                schema: "main",
                table: "DataCutLogicType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutResultType_CreatedById",
                schema: "main",
                table: "DataCutResultType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutResultType_ModifiedById",
                schema: "main",
                table: "DataCutResultType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRule_CountyId",
                schema: "main",
                table: "DataCutRule",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRule_CreatedById",
                schema: "main",
                table: "DataCutRule",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRule_DataCutResultTypeId",
                schema: "main",
                table: "DataCutRule",
                column: "DataCutResultTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRule_ModifiedById",
                schema: "main",
                table: "DataCutRule",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleField_CreatedById",
                schema: "main",
                table: "DataCutRuleField",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleField_DataCutFieldTypeId",
                schema: "main",
                table: "DataCutRuleField",
                column: "DataCutFieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleField_ModifiedById",
                schema: "main",
                table: "DataCutRuleField",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleItem_CreatedById",
                schema: "main",
                table: "DataCutRuleItem",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleItem_DataCutLogicTypeId",
                schema: "main",
                table: "DataCutRuleItem",
                column: "DataCutLogicTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleItem_DataCutRuleFieldId",
                schema: "main",
                table: "DataCutRuleItem",
                column: "DataCutRuleFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleItem_DataCutRuleId",
                schema: "main",
                table: "DataCutRuleItem",
                column: "DataCutRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCutRuleItem_ModifiedById",
                schema: "main",
                table: "DataCutRuleItem",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Decision_CreatedById",
                schema: "main",
                table: "Decision",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Decision_DecisionTypeId",
                schema: "main",
                table: "Decision",
                column: "DecisionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Decision_EventDecisionLevelId",
                schema: "main",
                table: "Decision",
                column: "EventDecisionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Decision_ModifiedById",
                schema: "main",
                table: "Decision",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Decision_UserId",
                schema: "main",
                table: "Decision",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DecisionType_CreatedById",
                schema: "main",
                table: "DecisionType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DecisionType_ModifiedById",
                schema: "main",
                table: "DecisionType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Delinquency_CreatedById",
                schema: "main",
                table: "Delinquency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Delinquency_ModifiedById",
                schema: "main",
                table: "Delinquency",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Delinquency_PropertyId",
                schema: "main",
                table: "Delinquency",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Delinquency_EventId_PropertyId",
                schema: "main",
                table: "Delinquency",
                columns: new[] { "EventId", "PropertyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyComment_AuthorId",
                schema: "main",
                table: "DelinquencyComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyComment_CreatedById",
                schema: "main",
                table: "DelinquencyComment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyComment_DelinquencyId",
                schema: "main",
                table: "DelinquencyComment",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyComment_ModifiedById",
                schema: "main",
                table: "DelinquencyComment",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyDisplayStrategy_CreatedById",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategy",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyDisplayStrategy_DelinquencyId",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategy",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyDisplayStrategy_ModifiedById",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategy",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyDisplayStrategy_PropertyDisplayStrategyId",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategy",
                column: "PropertyDisplayStrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyScoring_CreatedById",
                schema: "main",
                table: "DelinquencyPropertyScoring",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyScoring_DelinquencyId",
                schema: "main",
                table: "DelinquencyPropertyScoring",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DelinquencyPropertyScoring_ModifiedById",
                schema: "main",
                table: "DelinquencyPropertyScoring",
                column: "ModifiedById");

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
                name: "IX_Event_AuctionTypeId",
                schema: "main",
                table: "Event",
                column: "AuctionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CountyId",
                schema: "main",
                table: "Event",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CreatedById",
                schema: "main",
                table: "Event",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Event_DataUserId",
                schema: "main",
                table: "Event",
                column: "DataUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventEntityId",
                schema: "main",
                table: "Event",
                column: "EventEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventNumber",
                schema: "main",
                table: "Event",
                column: "EventNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventTypeId",
                schema: "main",
                table: "Event",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_FinalPaymentTypeId",
                schema: "main",
                table: "Event",
                column: "FinalPaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ManagementUserId",
                schema: "main",
                table: "Event",
                column: "ManagementUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ModifiedById",
                schema: "main",
                table: "Event",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Event_SaleDateStatusId",
                schema: "main",
                table: "Event",
                column: "SaleDateStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_StateId",
                schema: "main",
                table: "Event",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                schema: "main",
                table: "Event",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttachment_CreatedById",
                schema: "main",
                table: "EventAttachment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttachment_EventId",
                schema: "main",
                table: "EventAttachment",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttachment_ModifiedById",
                schema: "main",
                table: "EventAttachment",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutDecision_CreatedById",
                schema: "main",
                table: "EventDataCutDecision",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutDecision_DecisionTypeId",
                schema: "main",
                table: "EventDataCutDecision",
                column: "DecisionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutDecision_DelinquencyId",
                schema: "main",
                table: "EventDataCutDecision",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutDecision_EventDataCutStrategyId",
                schema: "main",
                table: "EventDataCutDecision",
                column: "EventDataCutStrategyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutDecision_ModifiedById",
                schema: "main",
                table: "EventDataCutDecision",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutRule_CreatedById",
                schema: "main",
                table: "EventDataCutRule",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutRule_DataCutRuleId",
                schema: "main",
                table: "EventDataCutRule",
                column: "DataCutRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutRule_ModifiedById",
                schema: "main",
                table: "EventDataCutRule",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutStrategy_CreatedById",
                schema: "main",
                table: "EventDataCutStrategy",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutStrategy_EventId",
                schema: "main",
                table: "EventDataCutStrategy",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDataCutStrategy_ModifiedById",
                schema: "main",
                table: "EventDataCutStrategy",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevel_CreatedById",
                schema: "main",
                table: "EventDecisionLevel",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevel_EventId",
                schema: "main",
                table: "EventDecisionLevel",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevel_ModifiedById",
                schema: "main",
                table: "EventDecisionLevel",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelUser_CreatedById",
                schema: "main",
                table: "EventDecisionLevelUser",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelUser_EventDecisionLevelId",
                schema: "main",
                table: "EventDecisionLevelUser",
                column: "EventDecisionLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelUser_ModifiedById",
                schema: "main",
                table: "EventDecisionLevelUser",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventDecisionLevelUser_UserId",
                schema: "main",
                table: "EventDecisionLevelUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventEntity_CreatedById",
                schema: "main",
                table: "EventEntity",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventEntity_ModifiedById",
                schema: "main",
                table: "EventEntity",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventType_CreatedById",
                schema: "main",
                table: "EventType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EventType_ModifiedById",
                schema: "main",
                table: "EventType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_FinalPaymentType_CreatedById",
                schema: "main",
                table: "FinalPaymentType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_FinalPaymentType_ModifiedById",
                schema: "main",
                table: "FinalPaymentType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLandUseCode_CreatedById",
                schema: "main",
                table: "GeneralLandUseCode",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralLandUseCode_ModifiedById",
                schema: "main",
                table: "GeneralLandUseCode",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_InternalLandUseCode_CreatedById",
                schema: "main",
                table: "InternalLandUseCode",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_InternalLandUseCode_ModifiedById",
                schema: "main",
                table: "InternalLandUseCode",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_CreatedById",
                schema: "main",
                table: "Lead",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_LeadBK",
                schema: "main",
                table: "Lead",
                column: "LeadBK");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_MailingStateId",
                schema: "main",
                table: "Lead",
                column: "MailingStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Lead_ModifiedById",
                schema: "main",
                table: "Lead",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeadComment_AuthorId",
                schema: "main",
                table: "LeadComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadComment_CreatedById",
                schema: "main",
                table: "LeadComment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeadComment_LeadId",
                schema: "main",
                table: "LeadComment",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadComment_ModifiedById",
                schema: "main",
                table: "LeadComment",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanType_CreatedById",
                schema: "main",
                table: "LoanType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LoanType_ModifiedById",
                schema: "main",
                table: "LoanType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OperationStatus_Code",
                schema: "main",
                table: "OperationStatus",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_OperationStatus_CreatedById",
                schema: "main",
                table: "OperationStatus",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OperationStatus_ModifiedById",
                schema: "main",
                table: "OperationStatus",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_CampaignId",
                schema: "main",
                table: "Opportunity",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_ContactId",
                schema: "main",
                table: "Opportunity",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_CreatedById",
                schema: "main",
                table: "Opportunity",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_LeadId",
                schema: "main",
                table: "Opportunity",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_LoanTypeId",
                schema: "main",
                table: "Opportunity",
                column: "LoanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_ModifiedById",
                schema: "main",
                table: "Opportunity",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_OpportunityStageId",
                schema: "main",
                table: "Opportunity",
                column: "OpportunityStageId");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunity_UserId",
                schema: "main",
                table: "Opportunity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityContact_ContactId",
                schema: "main",
                table: "OpportunityContact",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityContact_CreatedById",
                schema: "main",
                table: "OpportunityContact",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityContact_ModifiedById",
                schema: "main",
                table: "OpportunityContact",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityProperty_CreatedById",
                schema: "main",
                table: "OpportunityProperty",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityProperty_ModifiedById",
                schema: "main",
                table: "OpportunityProperty",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityProperty_OpportunityId",
                schema: "main",
                table: "OpportunityProperty",
                column: "OpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityStage_CreatedById",
                schema: "main",
                table: "OpportunityStage",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OpportunityStage_ModifiedById",
                schema: "main",
                table: "OpportunityStage",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Property_CountyId",
                schema: "main",
                table: "Property",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_CreatedById",
                schema: "main",
                table: "Property",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Property_GeneralLandUseCodeId",
                schema: "main",
                table: "Property",
                column: "GeneralLandUseCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_InternalLandUseCodeId",
                schema: "main",
                table: "Property",
                column: "InternalLandUseCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_LeadId",
                schema: "main",
                table: "Property",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ModifiedById",
                schema: "main",
                table: "Property",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyBK",
                schema: "main",
                table: "Property",
                column: "PropertyBK");

            migrationBuilder.CreateIndex(
                name: "IX_Property_StateId",
                schema: "main",
                table: "Property",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAttachment_CreatedById",
                schema: "main",
                table: "PropertyAttachment",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAttachment_ModifiedById",
                schema: "main",
                table: "PropertyAttachment",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAttachment_PropertyAttachmentTypeId",
                schema: "main",
                table: "PropertyAttachment",
                column: "PropertyAttachmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAttachment_PropertyId",
                schema: "main",
                table: "PropertyAttachment",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAttachmentType_CreatedById",
                schema: "main",
                table: "PropertyAttachmentType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAttachmentType_ModifiedById",
                schema: "main",
                table: "PropertyAttachmentType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDisplayStrategy_CreatedById",
                schema: "main",
                table: "PropertyDisplayStrategy",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDisplayStrategy_ModifiedById",
                schema: "main",
                table: "PropertyDisplayStrategy",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySupplementalEventData_CreatedById",
                schema: "main",
                table: "PropertySupplementalEventData",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySupplementalEventData_DelinquencyId",
                schema: "main",
                table: "PropertySupplementalEventData",
                column: "DelinquencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertySupplementalEventData_ModifiedById",
                schema: "main",
                table: "PropertySupplementalEventData",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySupplementalEventData_PropertyId",
                schema: "main",
                table: "PropertySupplementalEventData",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValuation_CreatedById",
                schema: "main",
                table: "PropertyValuation",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValuation_ModifiedById",
                schema: "main",
                table: "PropertyValuation",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValuation_PropertyId",
                schema: "main",
                table: "PropertyValuation",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_BidId",
                schema: "main",
                table: "Result",
                column: "BidId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_CreatedById",
                schema: "main",
                table: "Result",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Result_DelinquencyId",
                schema: "main",
                table: "Result",
                column: "DelinquencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_ModifiedById",
                schema: "main",
                table: "Result",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDateStatus_CreatedById",
                schema: "main",
                table: "SaleDateStatus",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDateStatus_ModifiedById",
                schema: "main",
                table: "SaleDateStatus",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_State_CreatedById",
                schema: "main",
                table: "State",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_State_ModifiedById",
                schema: "main",
                table: "State",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_StateTaxe_CreatedById",
                schema: "main",
                table: "StateTaxe",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StateTaxe_ModifiedById",
                schema: "main",
                table: "StateTaxe",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_StateTaxe_StateId",
                schema: "main",
                table: "StateTaxe",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_CreatedById",
                schema: "main",
                table: "Task",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Task_EventId",
                schema: "main",
                table: "Task",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ModifiedById",
                schema: "main",
                table: "Task",
                column: "ModifiedById");

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
                name: "IX_Task_UserId",
                schema: "main",
                table: "Task",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedById",
                schema: "main",
                table: "User",
                column: "CreatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "BidAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignComment",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignCommentAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignFieldTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignLead",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignLeadAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignLogicTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleCampaign",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleCampaignAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleFieldAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleItem",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleItemAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CollectingEntity",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CollectingEntityAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CollectingEntityTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ContactAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ContactTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CountyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutFieldTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutLogicTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutResultTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutRuleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutRuleFieldAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutRuleItem",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutRuleItemAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Decision",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DecisionAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DecisionTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyComment",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyCommentAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyPropertyDisplayStrategy",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyPropertyDisplayStrategyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyPropertyScoring",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DelinquencyPropertyScoringAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventAttachment",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventAttachmentAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDataCutDecision",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDataCutDecisionAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDataCutRule",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDataCutRuleAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDataCutStrategyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDecisionLevelAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDecisionLevelUser",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDecisionLevelUserAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventEntityAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "FinalPaymentType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "FinalPaymentTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "GeneralLandUseCodeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "InternalLandUseCodeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LeadAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LeadComment",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LeadCommentAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OperationStatus",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityContact",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityContactAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityProperty",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityPropertyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityStageAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyAttachment",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyAttachmentAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyAttachmentTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyDisplayStrategyAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertySupplementalEventData",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertySupplementalEventDataAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyValuation",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyValuationAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Result",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ResultAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "SaleDateStatusAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "StateAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "StateTaxe",
                schema: "main");

            migrationBuilder.DropTable(
                name: "StateTaxeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Task",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskStatusAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskTypeAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "UserAudit",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignLogicType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRuleField",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignRule",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CollectingEntityType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutLogicType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutRuleField",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyDisplayStrategy",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DecisionType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutRule",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDataCutStrategy",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventDecisionLevel",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Opportunity",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PropertyAttachmentType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Bid",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Delinquency",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskStatus",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TaskType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignFieldType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutFieldType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "DataCutResultType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Campaign",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Contact",
                schema: "main");

            migrationBuilder.DropTable(
                name: "LoanType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "OpportunityStage",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Event",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Property",
                schema: "main");

            migrationBuilder.DropTable(
                name: "CampaignType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ContactType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AuctionType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventEntity",
                schema: "main");

            migrationBuilder.DropTable(
                name: "EventType",
                schema: "main");

            migrationBuilder.DropTable(
                name: "SaleDateStatus",
                schema: "main");

            migrationBuilder.DropTable(
                name: "County",
                schema: "main");

            migrationBuilder.DropTable(
                name: "GeneralLandUseCode",
                schema: "main");

            migrationBuilder.DropTable(
                name: "InternalLandUseCode",
                schema: "main");

            migrationBuilder.DropTable(
                name: "Lead",
                schema: "main");

            migrationBuilder.DropTable(
                name: "State",
                schema: "main");

            migrationBuilder.DropTable(
                name: "User",
                schema: "main");
        }
    }
}
