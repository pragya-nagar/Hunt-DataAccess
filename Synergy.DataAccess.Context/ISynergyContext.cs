using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Synergy.DataAccess.Entities;
using Synergy.DataAccess.Entities.OpportunityEntities;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context
{
    public interface ISynergyContext
    {
        DbSet<Bid> Bid { get; set; }

        DbSet<Result> Result { get; set; }

        DbSet<OperationStatus> OperationStatus { get; set; }

        DbSet<State> State { get; set; }

        DbSet<StateTaxe> StateTaxe { get; set; }

        DbSet<County> County { get; set; }

        DbSet<User> User { get; set; }

        // Loan
        DbSet<Loan> Loan { get; set; }

        DbSet<LoanProperty> LoanProperty { get; set; }

        DbSet<LoanPropertyType> LoanPropertyType { get; set; }

        DbSet<LoanStage> LoanStage { get; set; }

        DbSet<Borrower> Borrower { get; set; }

        DbSet<EntityBorrower> EntityBorrower { get; set; }

        // Event
        DbSet<Event> Event { get; set; }

        DbSet<EventType> EventType { get; set; }

        DbSet<AuctionType> AuctionType { get; set; }

        DbSet<EventEntity> EventEntity { get; set; }

        DbSet<FinalPaymentType> FinalPaymentType { get; set; }

        DbSet<SaleDateStatus> SaleDateStatus { get; set; }

        DbSet<EventAttachment> EventAttachment { get; set; }

        DbSet<EventDecisionLevelPropertyProfile> EventDecisionLevelPropertyProfile { get; set; }

        DbSet<EventUser> EventUser { get; set; }

        DbSet<Lead> Lead { get; set; }

        DbSet<LeadComment> LeadComment { get; set; }

        DbSet<Property> Property { get; set; }

        DbSet<PropertyAttachment> PropertyAttachment { get; set; }

        DbSet<PropertyAttachmentType> PropertyAttachmentType { get; set; }

        DbSet<Campaign> Campaign { get; set; }

        DbSet<CampaignComment> CampaignComment { get; set; }

        DbSet<CampaignType> CampaignType { get; set; }

        DbSet<CampaignLead> CampaignLead { get; set; }

        DbSet<Opportunity> Opportunity { get; set; }

        DbSet<OpportunityStage> OpportunityStage { get; set; }

        DbSet<OpportunityProperty> OpportunityProperty { get; set; }

        DbSet<OpportunityPropertyType> OpportunityPropertyType { get; set; }

        DbSet<OpportunityMonthlyPrepay> OpportunityMonthlyPrepay { get; set; }

        DbSet<OpportunityPercentagePrepay> OpportunityPercentagePrepay { get; set; }

        DbSet<OpportunityBorrower> OpportunityBorrower { get; set; }

        DbSet<OpportunityCommercialBorrower> OpportunityCommercialBorrower { get; set; }

        DbSet<LoanType> LoanType { get; set; }

        DbSet<Delinquency> Delinquency { get; set; }

        DbSet<DelinquencyComment> DelinquencyComment { get; set; }

        DbSet<CollectingEntity> CollectingEntity { get; set; }

        DbSet<CollectingEntityType> CollectingEntityType { get; set; }

        DbSet<EventDecisionLevel> EventDecisionLevel { get; set; }

        DbSet<EventDecisionLevelUser> EventDecisionLevelUser { get; set; }

        DbSet<EventDataCutStrategy> EventDataCutStrategy { get; set; }

        DbSet<EventDataCutRule> EventDataCutRule { get; set; }

        DbSet<EventDataCutDecision> EventDataCutDecision { get; set; }

        DbSet<Decision> Decision { get; set; }

        DbSet<DecisionType> DecisionType { get; set; }

        DbSet<PropertySupplementalEventData> PropertySupplementalEventData { get; set; }

        DbSet<PropertyValuation> PropertyValuation { get; set; }

        DbSet<PropertyDisplayStrategy> PropertyDisplayStrategy { get; set; }

        DbSet<DelinquencyPropertyDisplayStrategy> DelinquencyPropertyDisplayStrategy { get; set; }

        DbSet<DelinquencyPropertyScoring> DelinquencyPropertyScoring { get; set; }

        DbSet<InternalLandUseCode> InternalLandUseCode { get; set; }

        DbSet<GeneralLandUseCode> GeneralLandUseCode { get; set; }

        DbSet<Contact> Contact { get; set; }

        DbSet<ContactType> ContactType { get; set; }

        DbSet<OpportunityContact> OpportunityContact { get; set; }

        DbSet<DataCutRuleField> DataCutRuleField { get; set; }

        DbSet<DataCutLogicType> DataCutLogicType { get; set; }

        DbSet<DataCutFieldType> DataCutFieldType { get; set; }

        DbSet<DataCutResultType> DataCutResultType { get; set; }

        DbSet<DataCutRule> DataCutRule { get; set; }

        DbSet<DataCutRuleItem> DataCutRuleItem { get; set; }

        DbSet<CampaignRule> CampaignRule { get; set; }

        DbSet<CampaignRuleCampaign> CampaignRuleCampaign { get; set; }

        DbSet<CampaignRuleItem> CampaignRuleItem { get; set; }

        DbSet<CampaignRuleField> CampaignRuleField { get; set; }

        DbSet<CampaignFieldType> CampaignFieldType { get; set; }

        DbSet<CampaignLogicType> CampaignLogicType { get; set; }

        // Roles and permissions
        DbSet<Permission> Permission { get; set; }

        DbSet<Role> Role { get; set; }

        DbSet<RolePermission> RolePermission { get; set; }

        DbSet<UserPermission> UserPermission { get; set; }

        DbSet<UserRole> UserRole { get; set; }

        DbSet<DepartmentRole> DepartmentRole { get; set; }

        DbSet<Department> Department { get; set; }

        // Property profiles
        DbSet<PropertyProfileRuleField> PropertyProfileRuleField { get; set; }

        DbSet<PropertyProfileLogicType> PropertyProfileLogicType { get; set; }

        DbSet<PropertyProfileFieldType> PropertyProfileFieldType { get; set; }

        DbSet<PropertyProfileRule> PropertyProfileRule { get; set; }

        DbSet<PropertyProfileRuleItem> PropertyProfileRuleItem { get; set; }

        DbSet<PropertyProfileRuleItemValue> PropertyProfileRuleItemValue { get; set; }

        DbSet<PropertyProfile> PropertyProfile { get; set; }

        DbSet<PropertyProfileState> PropertyProfileState { get; set; }

        DbSet<PropertyProfileRulePropertyProfile> PropertyProfileRulePropertyProfile { get; set; }

        DbSet<PropertyProfileDelinquency> PropertyProfileDelinquency { get; set; }

        DbSet<PropertyChat> PropertyChats { get; set; }

        DbSet<ChatTagging> ChatTaggings { get; set; }

        DbSet<PropertyChatAttachment> PropertyChatAttachments { get; set; }

        // Notifications
        DbSet<NotificationMessage> NotificationMessages { get; set; }

        DbSet<EtlDelinquency> EtlDelinquency { get; set; }

        DbSet<LeadSourceType> LeadSourceType { get; set; }

        DbSet<Reminder> Reminder { get; set; }

        DbSet<PropertyNotes> PropertyNotes { get; set; }

        void CreateOrUpdateDb();

        void EnsureSeedData();

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        DbSet<T> Set<T>()
            where T : class;

        IQueryable<T> GetQueryable<T>()
            where T : class, IEntity;
    }
}
