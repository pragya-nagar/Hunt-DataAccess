namespace Synergy.DataAccess.Entities
{
    public abstract class LoanStageBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
