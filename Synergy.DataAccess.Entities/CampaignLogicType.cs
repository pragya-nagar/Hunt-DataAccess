namespace Synergy.DataAccess.Entities
{
    public abstract class CampaignLogicTypeBase : BaseAudit<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int CampaignFieldTypeId { get; set; }
    }

    public class CampaignLogicType : CampaignLogicTypeBase, IAuditEntity<int>, IEntity
    {
        public CampaignFieldType CampaignFieldType { get; set; }

        #region IAuditEntity<int> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
