using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignCountyBase : BaseAudit<Guid>
    {
        public Guid CampaignId { get; set; }

        public int CountyId { get; set; }
    }

    public class CampaignCounty : CampaignCountyBase, IAuditEntity<Guid>, IEntity
    {
        public Campaign Campaign { get; set; }

        public County County { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
