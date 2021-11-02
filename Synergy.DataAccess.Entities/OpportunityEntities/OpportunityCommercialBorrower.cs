using Synergy.DataAccess.Context.Attributes;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class OpportunityCommercialBorrower : OpportunityBorrowerBase
    {
        public string EntityName { get; set; }

        [Encrypted]
        public string TaxIdNumber { get; set; }

        public string Title { get; set; }

        public Opportunity Opportunity { get; set; }
    }
}
