using Microsoft.EntityFrameworkCore;

using Synergy.DataAccess.Entities.AuditModels;
using Synergy.DataAccess.Entities.AuditModels.OpportunityEntities;
using Synergy.DataAccess.Entities.AuditModels.Processing;

namespace Synergy.DataAccess.Context
{
    public interface ISynergyAuditContext
    {
        // Loan
        DbSet<LoanAudit> LoanAudit { get; set; }

        DbSet<LoanPropertyAudit> LoanPropertyAudit { get; set; }

        DbSet<LoanPropertyTypeAudit> LoanPropertyTypeAudit { get; set; }

        DbSet<BorrowerAudit> BorrowerAudit { get; set; }

        DbSet<EntityBorrowerAudit> EntityBorrowerAudit { get; set; }

        DbSet<LoanStageAudit> LoanStageAudit { get; set; }

        DbSet<DepartmentAudit> DepartmentAudit { get; set; }

        DbSet<BidAudit> BidAudit { get; set; }

        DbSet<ResultAudit> ResultAudit { get; set; }

        DbSet<EventAudit> EventAudit { get; set; }

        DbSet<EventDecisionLevelPropertyProfileAudit> EventDecisionLevelPropertyProfileAudit { get; set; }

        DbSet<CampaignAudit> CampaignAudit { get; set; }

        DbSet<CampaignCommentAudit> CampaignCommentAudit { get; set; }

        DbSet<CampaignRuleAudit> CampaignRuleAudit { get; set; }

        DbSet<CampaignRuleItemAudit> CampaignRuleItemAudit { get; set; }

        DbSet<CampaignCountyAudit> CampaignCountyAudit { get; set; }

        DbSet<CollectingEntityAudit> CollectingEntityAudit { get; set; }

        DbSet<ContactAudit> ContactAudit { get; set; }

        DbSet<DataCutRuleAudit> DataCutRuleAudit { get; set; }

        DbSet<DataCutRuleItemAudit> DataCutRuleItemAudit { get; set; }

        DbSet<DecisionAudit> DecisionAudit { get; set; }

        DbSet<DelinquencyAudit> DelinquencyAudit { get; set; }

        DbSet<DelinquencyCommentAudit> DelinquencyCommentAudit { get; set; }

        DbSet<EventAttachmentAudit> EventAttachmentAudit { get; set; }

        DbSet<EventDataCutStrategyAudit> EventDataCutStrategyAudit { get; set; }

        DbSet<EventDataCutDecisionAudit> EventDataCutDecisionAudit { get; set; }

        DbSet<EventDecisionLevelAudit> EventDecisionLevelAudit { get; set; }

        DbSet<EventDecisionLevelUserAudit> EventDecisionLevelUserAudit { get; set; }

        DbSet<EventUserAudit> EventUserAudit { get; set; }

        DbSet<LeadAudit> LeadAudit { get; set; }

        DbSet<LeadCommentAudit> LeadCommentAudit { get; set; }

        DbSet<OpportunityAudit> OpportunityAudit { get; set; }

        DbSet<PropertyAudit> PropertyAudit { get; set; }

        DbSet<PropertyAttachmentAudit> PropertyAttachmentAudit { get; set; }

        DbSet<PropertyAttachmentTypeAudit> PropertyAttachmentTypeAudit { get; set; }

        DbSet<PropertySupplementalEventDataAudit> PropertySupplementalEventDataAudit { get; set; }

        DbSet<PropertyValuationAudit> PropertyValuationAudit { get; set; }

        DbSet<UserAudit> UserAudit { get; set; }

        DbSet<DelinquencyPropertyDisplayStrategyAudit> DelinquencyPropertyDisplayStrategyAudit { get; set; }

        DbSet<DelinquencyPropertyScoringAudit> DelinquencyPropertyScoringAudit { get; set; }

        DbSet<AuctionTypeAudit> AuctionTypeAudit { get; set; }

        DbSet<CampaignLeadAudit> CampaignLeadAudit { get; set; }

        DbSet<CampaignFieldTypeAudit> CampaignFieldTypeAudit { get; set; }

        DbSet<CampaignLogicTypeAudit> CampaignLogicTypeAudit { get; set; }

        DbSet<CampaignRuleCampaignAudit> CampaignRuleCampaignAudit { get; set; }

        DbSet<CampaignRuleFieldAudit> CampaignRuleFieldAudit { get; set; }

        DbSet<CampaignTypeAudit> CampaignTypeAudit { get; set; }

        DbSet<CollectingEntityTypeAudit> CollectingEntityTypeAudit { get; set; }

        DbSet<ContactTypeAudit> ContactTypeAudit { get; set; }

        DbSet<DataCutFieldTypeAudit> DataCutFieldTypeAudit { get; set; }

        DbSet<DataCutLogicTypeAudit> DataCutLogicTypeAudit { get; set; }

        DbSet<DataCutResultTypeAudit> DataCutResultTypeAudit { get; set; }

        DbSet<DataCutRuleFieldAudit> DataCutRuleFieldAudit { get; set; }

        DbSet<DecisionTypeAudit> DecisionTypeAudit { get; set; }

        DbSet<EventDataCutRuleAudit> EventDataCutRuleAudit { get; set; }

        DbSet<EventEntityAudit> EventEntityAudit { get; set; }

        DbSet<EventTypeAudit> EventTypeAudit { get; set; }

        DbSet<FinalPaymentTypeAudit> FinalPaymentTypeAudit { get; set; }

        DbSet<GeneralLandUseCodeAudit> GeneralLandUseCodeAudit { get; set; }

        DbSet<InternalLandUseCodeAudit> InternalLandUseCodeAudit { get; set; }

        DbSet<LoanTypeAudit> LoanTypeAudit { get; set; }

        DbSet<OpportunityContactAudit> OpportunityContactAudit { get; set; }

        DbSet<OpportunityPropertyAudit> OpportunityPropertyAudit { get; set; }

        DbSet<OpportunityStageAudit> OpportunityStageAudit { get; set; }

        DbSet<OpportunityBorrowerBaseAudit> OpportunityBorrowerBaseAudit { get; set; }

        DbSet<PropertyDisplayStrategyAudit> PropertyDisplayStrategyAudit { get; set; }

        DbSet<SaleDateStatusAudit> SaleDateStatusAudit { get; set; }

        DbSet<StateAudit> StateAudit { get; set; }

        DbSet<CountyAudit> CountyAudit { get; set; }

        DbSet<StateTaxeAudit> StateTaxeAudit { get; set; }

        // Roles and permissions
        DbSet<PermissionAudit> PermissionAudit { get; set; }

        DbSet<RoleAudit> RoleAudit { get; set; }

        DbSet<RolePermissionAudit> RolePermissionAudit { get; set; }

        DbSet<UserPermissionAudit> UserPermissionAudit { get; set; }

        DbSet<UserRoleAudit> UserRoleAudit { get; set; }

        DbSet<DepartmentRoleAudit> DepartmentRoleAudit { get; set; }

        // Property profile
        DbSet<PropertyProfileRuleFieldAudit> PropertyProfileRuleFieldAudit { get; set; }

        DbSet<PropertyProfileLogicTypeAudit> PropertyProfileLogicTypeAudit { get; set; }

        DbSet<PropertyProfileFieldTypeAudit> PropertyProfileFieldTypeAudit { get; set; }

        DbSet<PropertyProfileRuleAudit> PropertyProfileRuleAudit { get; set; }

        DbSet<PropertyProfileRuleItemAudit> PropertyProfileRuleItemAudit { get; set; }

        DbSet<PropertyProfileRuleItemValueAudit> PropertyProfileRuleItemValueAudit { get; set; }

        DbSet<PropertyProfileAudit> PropertyProfileAudit { get; set; }

        DbSet<PropertyProfileStateAudit> PropertyProfileStateAudit { get; set; }

        DbSet<PropertyProfileRulePropertyProfileAudit> PropertyProfileRulePropertyProfileAudit { get; set; }

        DbSet<PropertyProfileDelinquencyAudit> PropertyProfileDelinquencyAudit { get; set; }

        DbSet<ReminderAudit> ReminderAudit { get; set; }

        DbSet<PropertyNotesAudit> PropertyNotesAudit { get; set; }

        DbSet<PropertyChatAudit> PropertyChat { get; set; }

        DbSet<ChatTaggingAudit> ChatTagging { get; set; }

        DbSet<PropertyChatAttachmentAudit> PropertyChatAttachment { get; set; }
    }
}
