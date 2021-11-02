using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Synergy.DataAccess.Context.Migrations
{
    public partial class AddNewAuditFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_EventEntity_FinalPaymentTypeId",
                schema: "main",
                table: "Event");

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "UserRoleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "UserRoleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "UserPermissionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "UserPermissionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "UserAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "UserAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "TemplateTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "TemplateTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "TemplateFileCountyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "TemplateFileCountyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "TemplateFileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "TemplateFileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "StateTaxeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "StateTaxeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "StateAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "StateAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "SaleDateStatusAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "SaleDateStatusAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "RolePermissionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "RolePermissionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "RoleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "RoleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "ResultAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "ResultAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyValuationAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyValuationAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertySupplementalEventDataAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertySupplementalEventDataAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileStateAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileStateAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRulePropertyProfileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRulePropertyProfileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleItemValueAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleItemValueAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleItemAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleItemAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleFieldAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleFieldAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileLogicTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileLogicTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileFieldTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileFieldTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileDelinquencyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileDelinquencyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyDisplayStrategyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyDisplayStrategyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyAttachmentTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyAttachmentTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyAttachmentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PropertyAttachmentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "PermissionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "PermissionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityStageAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "OpportunityStageAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityPropertyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "OpportunityPropertyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityContactAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "OpportunityContactAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "OpportunityAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "ModuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "ModuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "LoanTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "LoanTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "LeadCommentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "LeadCommentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "LeadAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "LeadAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "InternalLandUseCodeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "InternalLandUseCodeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "GeneralLandUseCodeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "GeneralLandUseCodeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "FinalPaymentTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "FinalPaymentTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventUserAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventUserAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventEntityAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventEntityAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventDecisionLevelUserAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventDecisionLevelUserAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventDecisionLevelPropertyProfileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventDecisionLevelPropertyProfileAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventDecisionLevelAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventDecisionLevelAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventDataCutStrategyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventDataCutStrategyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventDataCutRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventDataCutRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventDataCutDecisionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventDataCutDecisionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "EventAttachmentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "EventAttachmentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DepartmentRoleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DepartmentRoleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DepartmentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DepartmentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyPropertyScoringAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyPropertyScoringAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyCommentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyCommentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DecisionTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DecisionTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DecisionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DecisionAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutRuleItemAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DataCutRuleItemAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutRuleFieldAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DataCutRuleFieldAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DataCutRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutResultTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DataCutResultTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutLogicTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DataCutLogicTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutFieldTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "DataCutFieldTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CountyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CountyAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "ContactTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "ContactTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "ContactAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "ContactAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CollectingEntityTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CollectingEntityTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CollectingEntityAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CollectingEntityAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleItemAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleItemAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleFieldAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleFieldAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleCampaignAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleCampaignAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignLogicTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignLogicTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignLeadAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignLeadAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignFieldTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignFieldTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignCommentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignCommentAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "CampaignAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "BidAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "BidAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsertedBy",
                schema: "main",
                table: "AuctionTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                schema: "main",
                table: "AuctionTypeAudit",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Event_FinalPaymentType_FinalPaymentTypeId",
                schema: "main",
                table: "Event",
                column: "FinalPaymentTypeId",
                principalSchema: "main",
                principalTable: "FinalPaymentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_FinalPaymentType_FinalPaymentTypeId",
                schema: "main",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "UserRoleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "UserRoleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "UserPermissionAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "UserPermissionAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "UserAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "UserAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "TemplateTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "TemplateTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "TemplateFileCountyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "TemplateFileCountyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "TemplateFileAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "TemplateFileAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "StateTaxeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "StateTaxeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "StateAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "StateAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "SaleDateStatusAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "SaleDateStatusAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "RolePermissionAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "RolePermissionAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "RoleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "RoleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "ResultAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "ResultAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyValuationAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyValuationAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertySupplementalEventDataAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertySupplementalEventDataAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileStateAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileStateAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRulePropertyProfileAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRulePropertyProfileAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleItemValueAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleItemValueAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleItemAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleItemAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleFieldAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleFieldAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileRuleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileRuleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileLogicTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileLogicTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileFieldTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileFieldTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileDelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileDelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyProfileAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyProfileAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyDisplayStrategyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyDisplayStrategyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyAttachmentTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyAttachmentTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PropertyAttachmentAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PropertyAttachmentAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "PermissionAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "PermissionAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityStageAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "OpportunityStageAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityPropertyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "OpportunityPropertyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityContactAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "OpportunityContactAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "OpportunityAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "ModuleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "ModuleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "LoanTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "LoanTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "LeadCommentAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "LeadCommentAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "LeadAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "LeadAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "InternalLandUseCodeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "InternalLandUseCodeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "GeneralLandUseCodeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "GeneralLandUseCodeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "FinalPaymentTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "FinalPaymentTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventUserAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventUserAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventEntityAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventEntityAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventDecisionLevelUserAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventDecisionLevelUserAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventDecisionLevelPropertyProfileAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventDecisionLevelPropertyProfileAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventDecisionLevelAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventDecisionLevelAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventDataCutStrategyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventDataCutStrategyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventDataCutRuleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventDataCutRuleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventDataCutDecisionAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventDataCutDecisionAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "EventAttachmentAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "EventAttachmentAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DepartmentRoleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DepartmentRoleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DepartmentAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DepartmentAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyPropertyScoringAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyPropertyScoringAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyPropertyDisplayStrategyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyCommentAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyCommentAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DelinquencyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DecisionTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DecisionTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DecisionAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DecisionAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutRuleItemAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DataCutRuleItemAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutRuleFieldAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DataCutRuleFieldAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutRuleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DataCutRuleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutResultTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DataCutResultTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutLogicTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DataCutLogicTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "DataCutFieldTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "DataCutFieldTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CountyAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CountyAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "ContactTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "ContactTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "ContactAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "ContactAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CollectingEntityTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CollectingEntityTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CollectingEntityAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CollectingEntityAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleItemAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleItemAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleFieldAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleFieldAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleCampaignAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleCampaignAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignRuleAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignRuleAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignLogicTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignLogicTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignLeadAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignLeadAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignFieldTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignFieldTypeAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignCommentAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignCommentAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "CampaignAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "CampaignAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "BidAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "BidAudit");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                schema: "main",
                table: "AuctionTypeAudit");

            migrationBuilder.DropColumn(
                name: "OperationId",
                schema: "main",
                table: "AuctionTypeAudit");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_EventEntity_FinalPaymentTypeId",
                schema: "main",
                table: "Event",
                column: "FinalPaymentTypeId",
                principalSchema: "main",
                principalTable: "EventEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
