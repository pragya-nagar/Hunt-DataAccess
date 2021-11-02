using System;

namespace Synergy.DataAccess.Entities
{
    public class CampaignCommentBase : BaseAudit<Guid>
    {
        public Guid CampaignId { get; set; }

        public Guid AuthorId { get; set; }

        public string Comment { get; set; }

        public DateTime CommentDate { get; set; }
    }

    public class CampaignComment : CampaignCommentBase, IAuditEntity<Guid>, IEntity
    {
        public Campaign Campaign { get; set; }

        public User Author { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
