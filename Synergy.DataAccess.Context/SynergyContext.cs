using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;

using Npgsql;
using Synergy.Common.Abstracts;
using Synergy.DataAccess.Context.Attributes;
using Synergy.DataAccess.Context.DataEncription;
using Synergy.DataAccess.Context.Mapping;
using Synergy.DataAccess.Context.Mapping.MailMerge;
using Synergy.DataAccess.Context.Mapping.Opportunity;
using Synergy.DataAccess.Context.Mapping.Processing;

using Synergy.DataAccess.Entities;
using Synergy.DataAccess.Entities.AuditModels;
using Synergy.DataAccess.Entities.OpportunityEntities;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context
{
    public partial class SynergyContext : DbContext, ISynergyContext, ISynergyAuditContext
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly bool _isMigration = false;
        private readonly IOperationContextAccessor _operationContextAccessor;
        private readonly IEncryptedConverter _encriptedConverter;
        private readonly string _connectionString;
        private readonly string _schema = "main";

        private DbConnection _connection = null;

        public SynergyContext()
            : base()
        {
            this._isMigration = true;
            this._connectionString = Environment.GetEnvironmentVariable("SYNERGY_CONSTR") ?? "migrations";
        }

        public SynergyContext(ILoggerFactory loggerFactory, IOperationContextAccessor operationContextAccessor, string connectionString, IEncryptedConverter encriptedConverter)
            : base()
        {
            this._connectionString = connectionString;
            this._loggerFactory = loggerFactory;
            this._operationContextAccessor = operationContextAccessor;
            this._encriptedConverter = encriptedConverter;
        }

        public DbSet<Bid> Bid { get; set; }

        public DbSet<Result> Result { get; set; }

        public DbSet<OperationStatus> OperationStatus { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<State> State { get; set; }

        public DbSet<StateTaxe> StateTaxe { get; set; }

        public DbSet<County> County { get; set; }

        // Loan
        public DbSet<Loan> Loan { get; set; }

        public DbSet<LoanProperty> LoanProperty { get; set; }

        public DbSet<LoanPropertyType> LoanPropertyType { get; set; }

        public DbSet<LoanStage> LoanStage { get; set; }

        public DbSet<Borrower> Borrower { get; set; }

        public DbSet<EntityBorrower> EntityBorrower { get; set; }

        // Event
        public DbSet<Event> Event { get; set; }

        public DbSet<EventType> EventType { get; set; }

        public DbSet<AuctionType> AuctionType { get; set; }

        public DbSet<EventEntity> EventEntity { get; set; }

        public DbSet<FinalPaymentType> FinalPaymentType { get; set; }

        public DbSet<SaleDateStatus> SaleDateStatus { get; set; }

        public DbSet<EventAttachment> EventAttachment { get; set; }

        public DbSet<EventDataCutRule> EventDataCutRule { get; set; }

        public DbSet<EventDataCutStrategy> EventDataCutStrategy { get; set; }

        public DbSet<EventDataCutDecision> EventDataCutDecision { get; set; }

        public DbSet<EventDecisionLevelPropertyProfile> EventDecisionLevelPropertyProfile { get; set; }

        public DbSet<EventUser> EventUser { get; set; }

        // Lead
        public DbSet<Lead> Lead { get; set; }

        public DbSet<LeadComment> LeadComment { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<ContactType> ContactType { get; set; }

        // Property
        public DbSet<Property> Property { get; set; }

        public DbSet<PropertyAttachment> PropertyAttachment { get; set; }

        public DbSet<PropertyAttachmentType> PropertyAttachmentType { get; set; }

        public DbSet<GeneralLandUseCode> GeneralLandUseCode { get; set; }

        public DbSet<InternalLandUseCode> InternalLandUseCode { get; set; }

        public DbSet<Opportunity> Opportunity { get; set; }

        public DbSet<OpportunityStage> OpportunityStage { get; set; }

        public DbSet<OpportunityContact> OpportunityContact { get; set; }

        public DbSet<OpportunityProperty> OpportunityProperty { get; set; }

        public DbSet<OpportunityPropertyType> OpportunityPropertyType { get; set; }

        public DbSet<OpportunityMonthlyPrepay> OpportunityMonthlyPrepay { get; set; }

        public DbSet<OpportunityPercentagePrepay> OpportunityPercentagePrepay { get; set; }

        public DbSet<OpportunityBorrower> OpportunityBorrower { get; set; }

        public DbSet<OpportunityCommercialBorrower> OpportunityCommercialBorrower { get; set; }

        public DbSet<LoanType> LoanType { get; set; }

        public DbSet<Campaign> Campaign { get; set; }

        public DbSet<CampaignComment> CampaignComment { get; set; }

        public DbSet<CampaignType> CampaignType { get; set; }

        public DbSet<CampaignLead> CampaignLead { get; set; }

        public DbSet<Delinquency> Delinquency { get; set; }

        public DbSet<DelinquencyComment> DelinquencyComment { get; set; }

        public DbSet<CollectingEntity> CollectingEntity { get; set; }

        public DbSet<CollectingEntityType> CollectingEntityType { get; set; }

        public DbSet<EventDecisionLevel> EventDecisionLevel { get; set; }

        public DbSet<EventDecisionLevelUser> EventDecisionLevelUser { get; set; }

        public DbSet<Decision> Decision { get; set; }

        public DbSet<DecisionType> DecisionType { get; set; }

        public DbSet<PropertySupplementalEventData> PropertySupplementalEventData { get; set; }

        public DbSet<PropertyValuation> PropertyValuation { get; set; }

        public DbSet<PropertyDisplayStrategy> PropertyDisplayStrategy { get; set; }

        public DbSet<DelinquencyPropertyDisplayStrategy> DelinquencyPropertyDisplayStrategy { get; set; }

        public DbSet<DelinquencyPropertyScoring> DelinquencyPropertyScoring { get; set; }

        public DbSet<PropertyChat> PropertyChats { get; set; }

        public DbSet<ChatTagging> ChatTaggings { get; set; }

        public DbSet<PropertyChatAttachment> PropertyChatAttachments { get; set; }

        // Data cut
        public DbSet<DataCutRuleField> DataCutRuleField { get; set; }

        public DbSet<DataCutLogicType> DataCutLogicType { get; set; }

        public DbSet<DataCutFieldType> DataCutFieldType { get; set; }

        public DbSet<DataCutResultType> DataCutResultType { get; set; }

        public DbSet<DataCutRule> DataCutRule { get; set; }

        public DbSet<DataCutRuleItem> DataCutRuleItem { get; set; }

        // Campaign
        public DbSet<CampaignRule> CampaignRule { get; set; }

        public DbSet<CampaignRuleCampaign> CampaignRuleCampaign { get; set; }

        public DbSet<CampaignRuleItem> CampaignRuleItem { get; set; }

        public DbSet<CampaignRuleField> CampaignRuleField { get; set; }

        public DbSet<CampaignFieldType> CampaignFieldType { get; set; }

        public DbSet<CampaignLogicType> CampaignLogicType { get; set; }

        // Roles and permissions
        public DbSet<Permission> Permission { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<RolePermission> RolePermission { get; set; }

        public DbSet<UserPermission> UserPermission { get; set; }

        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<DepartmentRole> DepartmentRole { get; set; }

        // Property profiles
        public DbSet<PropertyProfileRuleField> PropertyProfileRuleField { get; set; }

        public DbSet<PropertyProfileLogicType> PropertyProfileLogicType { get; set; }

        public DbSet<PropertyProfileFieldType> PropertyProfileFieldType { get; set; }

        public DbSet<PropertyProfileRule> PropertyProfileRule { get; set; }

        public DbSet<PropertyProfileRuleItem> PropertyProfileRuleItem { get; set; }

        public DbSet<PropertyProfileRuleItemValue> PropertyProfileRuleItemValue { get; set; }

        public DbSet<PropertyProfile> PropertyProfile { get; set; }

        public DbSet<PropertyProfileState> PropertyProfileState { get; set; }

        public DbSet<PropertyProfileRulePropertyProfile> PropertyProfileRulePropertyProfile { get; set; }

        public DbSet<PropertyProfileDelinquency> PropertyProfileDelinquency { get; set; }

        // Notifications
        public DbSet<NotificationMessage> NotificationMessages { get; set; }

        public DbSet<EtlDelinquency> EtlDelinquency { get; set; }

        public DbSet<LeadSourceType> LeadSourceType { get; set; }

        public DbSet<Reminder> Reminder { get; set; }

        public DbSet<PropertyNotes> PropertyNotes { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (InvalidOperationException ex) when (ex.InnerException?.InnerException is PostgresException postgresException)
            {
                if (postgresException.SqlState == "40001")
                {
                    throw new ApplicationException("An operation conflict. The data has been modified already.");
                }

                throw;
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (InvalidOperationException ex) when (ex.InnerException?.InnerException is PostgresException postgresException)
            {
                if (postgresException.SqlState == "40001")
                {
                    throw new ApplicationException("An operation conflict. The data has been modified already.");
                }

                throw;
            }
        }

        public void CreateOrUpdateDb()
        {
            this.Database.Migrate();
        }

        public IQueryable<T> GetQueryable<T>()
            where T : class, IEntity
            => this.Set<T>().AsNoTracking();

#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
        public override void Dispose()
#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize
        {
            this._connection?.Dispose();

            base.Dispose();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (this._isMigration == false)
                {
                    this._connection = new NpgsqlConnection(this._connectionString);

                    this._connection.StateChange += (sender, args) =>
                    {
                        if (args.CurrentState != args.OriginalState && args.CurrentState == ConnectionState.Open)
                        {
                            var senderConnection = (DbConnection)sender;

                            Guid? userId = this._operationContextAccessor.Current?.UserId;
                            Guid? correlationId = this._operationContextAccessor.Current?.CorrelationId;
                            if (correlationId.HasValue == false)
                            {
                                correlationId = Guid.NewGuid();
                                this._loggerFactory.CreateLogger<SynergyContext>().LogWarning("Operation context does not provide a value for CorrelationId. New id will be generated.");
                            }

                            if (userId.HasValue)
                            {
                                using (var command = senderConnection.CreateCommand())
                                {
                                    command.Connection = senderConnection;
#pragma warning disable CA2100 // Review SQL queries for security vulnerabilities
                                    command.CommandText = $@"SET SESSION Synergy.UID = '{userId}'; SET SESSION Synergy.OperationID = '{correlationId}';";
#pragma warning restore CA2100 // Review SQL queries for security vulnerabilities

                                    this._loggerFactory.CreateLogger<SynergyContext>().LogInformation($"Executing [{command.CommandText}]");

                                    command.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                this._loggerFactory.CreateLogger<SynergyContext>().LogWarning("Operation context does not provide a value for current UserId. Session variables was not set");
                            }
                        }
                    };

                    optionsBuilder.UseNpgsql(this._connection, x => x.MigrationsHistoryTable("__EFMigrationsHistory", this._schema));
                }
                else
                {
                    optionsBuilder.UseNpgsql(this._connectionString, x =>
                    {
                        x.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalMilliseconds);
                        x.MigrationsHistoryTable("__EFMigrationsHistory", this._schema);
                    });
                }

                if (this._loggerFactory != null)
                {
                    optionsBuilder.UseLoggerFactory(this._loggerFactory);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(this._schema);

            // Configure audit tables
            this.OnAuditModelCreated(modelBuilder);

            #region Workflow

            modelBuilder.ApplyConfiguration(new ProcessingTaskDefinitionMap());
            modelBuilder.ApplyConfiguration(new ProcessingTaskMap());
            modelBuilder.ApplyConfiguration(new ProcessingWorkflowDefinitionMap());
            modelBuilder.ApplyConfiguration(new ProcessingWorkflowMap());
            modelBuilder.ApplyConfiguration(new ProcessingWorkflowTaskDefinitionMap());
            modelBuilder.ApplyConfiguration(new ProcessingWorkflowDefinitionStateMap());

            modelBuilder.ApplyConfiguration(new ServicingTaskDefinitionMap());
            modelBuilder.ApplyConfiguration(new ServicingTaskMap());
            modelBuilder.ApplyConfiguration(new ServicingWorkflowDefinitionMap());
            modelBuilder.ApplyConfiguration(new ServicingWorkflowMap());
            modelBuilder.ApplyConfiguration(new ServicingWorkflowTaskDefinitionMap());

            modelBuilder.ApplyConfiguration(new UnderwritingTaskDefinitionMap());
            modelBuilder.ApplyConfiguration(new UnderwritingTaskMap());
            modelBuilder.ApplyConfiguration(new UnderwritingWorkflowDefinitionMap());
            modelBuilder.ApplyConfiguration(new UnderwritingWorkflowMap());
            modelBuilder.ApplyConfiguration(new UnderwritingWorkflowTaskDefinitionMap());
            modelBuilder.ApplyConfiguration(new UnderwritingWorkflowDefinitionStateMap());

            modelBuilder.ApplyConfiguration(new TaskDefinitionDepartmentMap());
            modelBuilder.ApplyConfiguration(new TaskDefinitionMap());
            modelBuilder.ApplyConfiguration(new TaskMap());
            modelBuilder.ApplyConfiguration(new WorkflowDefinitionStateMap());
            modelBuilder.ApplyConfiguration(new WorkflowDefinitionMap());
            modelBuilder.ApplyConfiguration(new WorkflowContextMap());
            modelBuilder.ApplyConfiguration(new WorkflowMap());
            modelBuilder.ApplyConfiguration(new WorkflowTaskUserMap());

            #endregion

            modelBuilder.ApplyConfiguration(new BidMap());
            modelBuilder.ApplyConfiguration(new ResultMap());
            modelBuilder.ApplyConfiguration(new OperationStatusMap());

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new StateMap());
            modelBuilder.ApplyConfiguration(new StateTaxMap());
            modelBuilder.ApplyConfiguration(new CountyMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());

            modelBuilder.ApplyConfiguration(new LoanMap());
            modelBuilder.ApplyConfiguration(new LoanPropertyMap());
            modelBuilder.ApplyConfiguration(new LoanStageMap());
            modelBuilder.ApplyConfiguration(new LoanPropertyTypeMap());
            modelBuilder.ApplyConfiguration(new LoanTypeMap());
            modelBuilder.ApplyConfiguration(new LoanAssigneeMap());

            modelBuilder.ApplyConfiguration(new EventMap());
            modelBuilder.ApplyConfiguration(new EventTypeMap());
            modelBuilder.ApplyConfiguration(new AuctionTypeMap());
            modelBuilder.ApplyConfiguration(new SaleDateStatusMap());
            modelBuilder.ApplyConfiguration(new EventEntityMap());
            modelBuilder.ApplyConfiguration(new FinalPaymentTypeMap());
            modelBuilder.ApplyConfiguration(new EventAttachmentMap());
            modelBuilder.ApplyConfiguration(new EventDataCutRuleMap());

            modelBuilder.ApplyConfiguration(new LeadMap());
            modelBuilder.ApplyConfiguration(new LeadSourceMap());
            modelBuilder.ApplyConfiguration(new LeadCommentMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new ContactTypeMap());

            modelBuilder.ApplyConfiguration(new PropertyMap());
            modelBuilder.ApplyConfiguration(new PropertyAttachmentMap());
            modelBuilder.ApplyConfiguration(new PropertyAttachmentTypeMap());
            modelBuilder.ApplyConfiguration(new GeneralLandUseCodeMap());
            modelBuilder.ApplyConfiguration(new InternalLandUseCodeMap());

            modelBuilder.ApplyConfiguration(new CampaignMap());
            modelBuilder.ApplyConfiguration(new CampaignCommentMap());
            modelBuilder.ApplyConfiguration(new CampaignTypeMap());
            modelBuilder.ApplyConfiguration(new CampaignLeadMap());

            modelBuilder.ApplyConfiguration(new OpportunityMap());
            modelBuilder.ApplyConfiguration(new OpportunityPropertyTypeMap());
            modelBuilder.ApplyConfiguration(new OpportunityMonthlyPrepayMap());
            modelBuilder.ApplyConfiguration(new OpportunityPercentagePrepayMap());
            modelBuilder.ApplyConfiguration(new OpportunityStageMap());
            modelBuilder.ApplyConfiguration(new OpportunityContactMap());
            modelBuilder.ApplyConfiguration(new OpportunityBorrowerBaseMap());

            modelBuilder.ApplyConfiguration(new DelinquencyMap());
            modelBuilder.ApplyConfiguration(new DelinquencyCommentMap());
            modelBuilder.ApplyConfiguration(new CollectingEntityMap());
            modelBuilder.ApplyConfiguration(new CollectingEntityTypeMap());
            modelBuilder.ApplyConfiguration(new OpportunityPropertyMap());

            modelBuilder.ApplyConfiguration(new DecisionMap());
            modelBuilder.ApplyConfiguration(new DecisionTypeMap());
            modelBuilder.ApplyConfiguration(new EventDecisionLevelMap());
            modelBuilder.ApplyConfiguration(new EventDecisionLevelUserMap());
            modelBuilder.ApplyConfiguration(new EventDecisionLevelPropertyProfileMap());
            modelBuilder.ApplyConfiguration(new EventDataCutDecisionMap());
            modelBuilder.ApplyConfiguration(new EventDataCutStrategyMap());
            modelBuilder.ApplyConfiguration(new EventUserMap());

            modelBuilder.ApplyConfiguration(new PropertySupplementalEventDataMap());
            modelBuilder.ApplyConfiguration(new PropertyValuationMap());
            modelBuilder.ApplyConfiguration(new PropertyDisplayStrategyMap());
            modelBuilder.ApplyConfiguration(new DelinquencyPropertyDisplayStrategyMap());
            modelBuilder.ApplyConfiguration(new DelinquencyPropertyScoringMap());

            modelBuilder.ApplyConfiguration(new DataCutRuleFieldMap());
            modelBuilder.ApplyConfiguration(new DataCutLogicTypeMap());
            modelBuilder.ApplyConfiguration(new DataCutFieldTypeMap());
            modelBuilder.ApplyConfiguration(new DataCutResultTypeMap());
            modelBuilder.ApplyConfiguration(new DataCutRuleMap());
            modelBuilder.ApplyConfiguration(new DataCutRuleItemMap());

            modelBuilder.ApplyConfiguration(new CampaignRuleMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleCampaignMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleItemMap());
            modelBuilder.ApplyConfiguration(new CampaignFieldTypeMap());
            modelBuilder.ApplyConfiguration(new CampaignLogicTypeMap());
            modelBuilder.ApplyConfiguration(new CampaignRuleFieldMap());

            modelBuilder.ApplyConfiguration(new PermissionMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new RolePermissionMap());
            modelBuilder.ApplyConfiguration(new UserPermissionMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new DepartmentRoleMap());

            modelBuilder.ApplyConfiguration(new PropertyProfileRuleFieldMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileLogicTypeMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileFieldTypeMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRuleMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRuleItemMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRuleItemValueMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileStateMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileRulePropertyProfileMap());
            modelBuilder.ApplyConfiguration(new PropertyProfileDelinquencyMap());

            modelBuilder.ApplyConfiguration(new NotificationMessageMap());

            modelBuilder.ApplyConfiguration(new EtlDelinquencyMap());

            modelBuilder.ApplyConfiguration(new ModuleMap());
            modelBuilder.ApplyConfiguration(new TemplateTypeMap());
            modelBuilder.ApplyConfiguration(new TemplateFileMap());
            modelBuilder.ApplyConfiguration(new TemplateFileCountyMap());

            modelBuilder.ApplyConfiguration(new ReminderMap());

            modelBuilder.ApplyConfiguration(new PropertyNotesMap());
            modelBuilder.ApplyConfiguration(new PropertyChatMap());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    object[] attributes = property.PropertyInfo?.GetCustomAttributes(typeof(EncryptedAttribute), false);
                    if (attributes != null && attributes.Any())
                    {
                        property.SetValueConverter(this._encriptedConverter as ValueConverter<string, string>);
                    }
                }
            }
        }
    }
}