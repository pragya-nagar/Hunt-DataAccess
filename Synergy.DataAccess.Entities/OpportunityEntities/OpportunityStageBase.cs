namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public abstract class OpportunityStageBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
