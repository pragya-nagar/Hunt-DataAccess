using Synergy.DataAccess.Context.Attributes;

namespace Synergy.DataAccess.Entities.OpportunityEntities
{
    public class OpportunityBorrower : OpportunityBorrowerBase
    {
        [Encrypted]
        public string SSN { get; set; }

        public bool? IsMarried { get; set; }

        [Encrypted]
        public string DateOfBirth { get; set; }

        public Opportunity Opportunity { get; set; }
    }
}
