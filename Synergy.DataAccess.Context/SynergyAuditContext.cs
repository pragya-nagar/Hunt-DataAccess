using Microsoft.EntityFrameworkCore;
using Synergy.DataAccess.Context.MappingAudit;
using Synergy.DataAccess.Context.MappingAudit.Processing;
using Synergy.DataAccess.Entities.AuditModels;
using Synergy.DataAccess.Entities.AuditModels.OpportunityEntities;
using Synergy.DataAccess.Entities.AuditModels.Processing;

namespace Synergy.DataAccess.Context
{
    public partial class SynergyContext : ISynergyAuditContext
    {
        // Loan
        public DbSet<LoanAudit> LoanAudit { get; set; }

        public DbSet<LoanPropertyAudit> LoanPropertyAudit { get; set; }

        public DbSet<LoanPropertyTypeAudit> LoanPropertyTypeAudit { get; set; }

        public DbSet<BorrowerAudit> BorrowerAudit { get; set; }

        public DbSet<EntityBorrowerAudit> EntityBorrowerAudit { get; set; }

        public DbSet<LoanStageAudit> LoanStageAudit { get; set; }

        public DbSet<BidAudit> BidAudit { get; set; }

        public DbSet<ResultAudit> ResultAudit { get; set; }

        public DbSet<DepartmentAudit> DepartmentAudit { get; set; }

        public DbSet<UserAudit> UserAudit { get; set; }

        public DbSet<EventAudit> EventAudit { get; set; }

        public DbSet<EventDecisionLevelPropertyProfileAudit> EventDecisionLevelPropertyProfileAudit { get; set; }

        public DbSet<EventDataCutStrategyAudit> EventDataCutStrategyAudit { get; set; }

        public DbSet<EventDataCutDecisionAudit> EventDataCutDecisionAudit { get; set; }

        public DbSet<EventUserAudit> EventUserAudit { get; set; }

        public DbSet<LeadCommentAudit> LeadCommentAudit { get; set; }

        public DbSet<AuctionTypeAudit> AuctionTypeAudit { get; set; }

        public DbSet<ContactAudit> ContactAudit { get; set; }

        public DbSet<ContactTypeAudit> ContactTypeAudit { get; set; }

        public DbSet<LeadAudit> LeadAudit { get; set; }

        public DbSet<PropertyAudit> PropertyAudit { get; set; }

        public DbSet<PropertyAttachmentAudit> PropertyAttachmentAudit { get; set; }

        public DbSet<PropertyAttachmentTypeAudit> PropertyAttachmentTypeAudit { get; set; }

        public DbSet<PropertyDisplayStrategyAudit> PropertyDisplayStrategyAudit { get; set; }

        public DbSet<CampaignRuleAudit> CampaignRuleAudit { get; set; }

        public DbSet<CampaignRuleItemAudit> CampaignRuleItemAudit { get; set; }

        public DbSet<CampaignLeadAudit> CampaignLeadAudit { get; set; }

        public DbSet<CampaignTypeAudit> CampaignTypeAudit { get; set; }

        public DbSet<CampaignAudit> CampaignAudit { get; set; }

        public DbSet<CampaignCommentAudit> CampaignCommentAudit { get; set; }

        public DbSet<CampaignCountyAudit> CampaignCountyAudit { get; set; }

        public DbSet<EventDecisionLevelUserAudit> EventDecisionLevelUserAudit { get; set; }

        public DbSet<EventDecisionLevelAudit> EventDecisionLevelAudit { get; set; }

        public DbSet<CollectingEntityTypeAudit> CollectingEntityTypeAudit { get; set; }

        public DbSet<CollectingEntityAudit> CollectingEntityAudit { get; set; }

        public DbSet<DelinquencyAudit> DelinquencyAudit { get; set; }

        public DbSet<DelinquencyCommentAudit> DelinquencyCommentAudit { get; set; }

        public DbSet<DelinquencyPropertyScoringAudit> DelinquencyPropertyScoringAudit { get; set; }

        public DbSet<DelinquencyPropertyDisplayStrategyAudit> DelinquencyPropertyDisplayStrategyAudit { get; set; }

        public DbSet<PropertySupplementalEventDataAudit> PropertySupplementalEventDataAudit { get; set; }

        public DbSet<PropertyValuationAudit> PropertyValuationAudit { get; set; }

        public DbSet<DataCutRuleItemAudit> DataCutRuleItemAudit { get; set; }

        public DbSet<DataCutResultTypeAudit> DataCutResultTypeAudit { get; set; }

        public DbSet<DataCutFieldTypeAudit> DataCutFieldTypeAudit { get; set; }

        public DbSet<DataCutLogicTypeAudit> DataCutLogicTypeAudit { get; set; }

        public DbSet<DataCutRuleFieldAudit> DataCutRuleFieldAudit { get; set; }

        public DbSet<EventDataCutRuleAudit> EventDataCutRuleAudit { get; set; }

        public DbSet<EventEntityAudit> EventEntityAudit { get; set; }

        public DbSet<EventTypeAudit> EventTypeAudit { get; set; }

        public DbSet<EventAttachmentAudit> EventAttachmentAudit { get; set; }

        public DbSet<DecisionTypeAudit> DecisionTypeAudit { get; set; }

        public DbSet<DecisionAudit> DecisionAudit { get; set; }

        public DbSet<CampaignLogicTypeAudit> CampaignLogicTypeAudit { get; set; }

        public DbSet<CampaignFieldTypeAudit> CampaignFieldTypeAudit { get; set; }

        public DbSet<CampaignRuleFieldAudit> CampaignRuleFieldAudit { get; set; }

        public DbSet<CampaignRuleCampaignAudit> CampaignRuleCampaignAudit { get; set; }

        public DbSet<FinalPaymentTypeAudit> FinalPaymentTypeAudit { get; set; }

        public DbSet<GeneralLandUseCodeAudit> GeneralLandUseCodeAudit { get; set; }

        public DbSet<InternalLandUseCodeAudit> InternalLandUseCodeAudit { get; set; }

        public DbSet<LoanTypeAudit> LoanTypeAudit { get; set; }

        public DbSet<SaleDateStatusAudit> SaleDateStatusAudit { get; set; }

        public DbSet<StateAudit> StateAudit { get; set; }

        public DbSet<StateTaxeAudit> StateTaxeAudit { get; set; }

        public DbSet<CountyAudit> CountyAudit { get; set; }

        public DbSet<OpportunityAudit> OpportunityAudit { get; set; }

        public DbSet<OpportunityContactAudit> OpportunityContactAudit { get; set; }

        public DbSet<OpportunityPropertyAudit> OpportunityPropertyAudit { get; set; }

        public DbSet<OpportunityStageAudit> OpportunityStageAudit { get; set; }

        public DbSet<OpportunityBorrowerBaseAudit> OpportunityBorrowerBaseAudit { get; set; }

        public DbSet<DataCutRuleAudit> DataCutRuleAudit { get; set; }

        // Roles and permissions
        public DbSet<PermissionAudit> PermissionAudit { get; set; }

        public DbSet<RoleAudit> RoleAudit { get; set; }

        public DbSet<RolePermissionAudit> RolePermissionAudit { get; set; }

        public DbSet<UserPermissionAudit> UserPermissionAudit { get; set; }

        public DbSet<UserRoleAudit> UserRoleAudit { get; set; }

        public DbSet<DepartmentRoleAudit> DepartmentRoleAudit { get; set; }

        // Property profiles
        public DbSet<PropertyProfileRuleFieldAudit> PropertyProfileRuleFieldAudit { get; set; }

        public DbSet<PropertyProfileLogicTypeAudit> PropertyProfileLogicTypeAudit { get; set; }

        public DbSet<PropertyProfileFieldTypeAudit> PropertyProfileFieldTypeAudit { get; set; }

        public DbSet<PropertyProfileRuleAudit> PropertyProfileRuleAudit { get; set; }

        public DbSet<PropertyProfileRuleItemAudit> PropertyProfileRuleItemAudit { get; set; }

        public DbSet<PropertyProfileRuleItemValueAudit> PropertyProfileRuleItemValueAudit { get; set; }

        public DbSet<PropertyProfileAudit> PropertyProfileAudit { get; set; }

        public DbSet<PropertyProfileStateAudit> PropertyProfileStateAudit { get; set; }

        public DbSet<PropertyProfileRulePropertyProfileAudit> PropertyProfileRulePropertyProfileAudit { get; set; }

        public DbSet<PropertyProfileDelinquencyAudit> PropertyProfileDelinquencyAudit { get; set; }

        public DbSet<ReminderAudit> ReminderAudit { get; set; }

        public DbSet<PropertyNotesAudit> PropertyNotesAudit { get; set; }

        public DbSet<PropertyChatAudit> PropertyChat { get; set; }

        public DbSet<ChatTaggingAudit> ChatTagging { get; set; }

        public DbSet<PropertyChatAttachmentAudit> PropertyChatAttachment { get; set; }

#pragma warning disable CA1822 // Mark members as static
        protected void OnAuditModelCreated(ModelBuilder modelBuilder)
#pragma warning restore CA1822 // Mark members as static
        {
            modelBuilder.ApplyConfiguration(new LoanAuditMap());
            modelBuilder.ApplyConfiguration(new LoanPropertyAuditMap());
            modelBuilder.ApplyConfiguration(new LoanPropertyTypeAuditMap());
            modelBuilder.ApplyConfiguration(new BorrowerAuditMap());
            modelBuilder.ApplyConfiguration(new EntityBorrowerAuditMap());
            modelBuilder.ApplyConfiguration(new LoanStageAuditMap());
            modelBuilder.ApplyConfiguration(new LoanAssigneeAuditMap());

            modelBuilder.ApplyConfiguration(new BidAuditMap());
            modelBuilder.ApplyConfiguration(new ResultAuditMap());
            modelBuilder.ApplyConfiguration(new EventAuditMap());
            modelBuilder.ApplyConfiguration(new EventDecisionLevelPropertyProfileAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignCommentAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignCountyAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleItemAuditMap());
            modelBuilder.ApplyConfiguration(new CollectingEntityAuditMap());
            modelBuilder.ApplyConfiguration(new ContactAuditMap());
            modelBuilder.ApplyConfiguration(new DataCutRuleAuditMap());
            modelBuilder.ApplyConfiguration(new DataCutRuleItemAuditMap());
            modelBuilder.ApplyConfiguration(new DecisionAuditMap());
            modelBuilder.ApplyConfiguration(new DelinquencyAuditMap());
            modelBuilder.ApplyConfiguration(new DelinquencyCommentAuditMap());
            modelBuilder.ApplyConfiguration(new EventAttachmentAuditMap());
            modelBuilder.ApplyConfiguration(new EventDecisionLevelAuditMap());
            modelBuilder.ApplyConfiguration(new EventDecisionLevelUserAuditMap());
            modelBuilder.ApplyConfiguration(new EventUserAuditMap());
            modelBuilder.ApplyConfiguration(new LeadAuditMap());
            modelBuilder.ApplyConfiguration(new LeadCommentAuditMap());
            modelBuilder.ApplyConfiguration(new OpportunityAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyAttachmentAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyAttachmentTypeAuditMap());

            modelBuilder.ApplyConfiguration(new PropertySupplementalEventDataAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyValuationAuditMap());
            modelBuilder.ApplyConfiguration(new UserAuditMap());
            modelBuilder.ApplyConfiguration(new EventDataCutStrategyAuditMap());
            modelBuilder.ApplyConfiguration(new EventDataCutDecisionAuditMap());
            modelBuilder.ApplyConfiguration(new DelinquencyPropertyDisplayStrategyAuditMap());
            modelBuilder.ApplyConfiguration(new DelinquencyPropertyScoringAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignLeadAuditMap());
            modelBuilder.ApplyConfiguration(new AuctionTypeAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignFieldTypeAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignLogicTypeAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleCampaignAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleFieldAuditMap());
            modelBuilder.ApplyConfiguration(new CampaignTypeAuditMap());
            modelBuilder.ApplyConfiguration(new CollectingEntityTypeAuditMap());
            modelBuilder.ApplyConfiguration(new ContactTypeAuditMap());
            modelBuilder.ApplyConfiguration(new DataCutFieldTypeAuditMap());
            modelBuilder.ApplyConfiguration(new DataCutLogicTypeAuditMap());
            modelBuilder.ApplyConfiguration(new DataCutResultTypeAuditMap());
            modelBuilder.ApplyConfiguration(new DataCutRuleFieldAuditMap());
            modelBuilder.ApplyConfiguration(new DecisionTypeAuditMap());
            modelBuilder.ApplyConfiguration(new EventDataCutRuleAuditMap());
            modelBuilder.ApplyConfiguration(new EventEntityAuditMap());
            modelBuilder.ApplyConfiguration(new EventTypeAuditMap());
            modelBuilder.ApplyConfiguration(new FinalPaymentTypeAuditMap());
            modelBuilder.ApplyConfiguration(new GeneralLandUseCodeAuditMap());
            modelBuilder.ApplyConfiguration(new InternalLandUseCodeAuditMap());
            modelBuilder.ApplyConfiguration(new LoanTypeAuditMap());
            modelBuilder.ApplyConfiguration(new OpportunityContactAuditMap());
            modelBuilder.ApplyConfiguration(new OpportunityPropertyAuditMap());
            modelBuilder.ApplyConfiguration(new OpportunityStageAuditMap());
            modelBuilder.ApplyConfiguration(new OpportunityBorrowerBaseAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyDisplayStrategyAuditMap());
            modelBuilder.ApplyConfiguration(new SaleDateStatusAuditMap());
            modelBuilder.ApplyConfiguration(new StateAuditMap());
            modelBuilder.ApplyConfiguration(new StateTaxeAuditMap());
            modelBuilder.ApplyConfiguration(new CountyAuditMap());

            modelBuilder.ApplyConfiguration(new PermissionAuditMap());
            modelBuilder.ApplyConfiguration(new RoleAuditMap());
            modelBuilder.ApplyConfiguration(new RolePermissionAuditMap());
            modelBuilder.ApplyConfiguration(new UserPermissionAuditMap());
            modelBuilder.ApplyConfiguration(new UserRoleAuditMap());
            modelBuilder.ApplyConfiguration(new DepartmentRoleAuditMap());

            modelBuilder.ApplyConfiguration(new PropertyProfileRuleFieldAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileLogicTypeAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileFieldTypeAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRuleAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRuleItemAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRuleItemValueAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileStateAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRulePropertyProfileAuditMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileDelinquencyAuditMap());

            modelBuilder.ApplyConfiguration(new ModuleAuditMap());
            modelBuilder.ApplyConfiguration(new TemplateTypeAuditMap());
            modelBuilder.ApplyConfiguration(new TemplateFileAuditMap());
            modelBuilder.ApplyConfiguration(new TemplateFileCountyAuditMap());

            modelBuilder.ApplyConfiguration(new ReminderAuditMap());

            modelBuilder.ApplyConfiguration(new PropertyNotesAuditMap());
        }
    }
}
