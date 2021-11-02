using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class EtlDelinquencyBase
    {
        public Guid EventId { get; set; }

        public Guid DelinquencyId { get; set; }
    }

    public class EtlDelinquency : EtlDelinquencyBase, IEntity
    {
        public Event Event { get; set; }

        public Delinquency Delinquency { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
