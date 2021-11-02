namespace Synergy.DataAccess.Entities.Processing
{
    public class LoanPropertyTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
