namespace Synergy.DataAccess.Entities
{
    public abstract class LeadSourceTypeBase : BaseAudit<int>
    {
        public string LeadSource { get; set; }
    }
}
