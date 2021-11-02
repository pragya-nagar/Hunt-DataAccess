using System;

namespace Synergy.DataAccess.Entities
{
    public class LeadCommentBase : BaseAudit<Guid>
    {
        public Guid LeadId { get; set; }

        public Guid AuthorId { get; set; }

        public string Comment { get; set; }

        public DateTime CommentDate { get; set; }
    }

    public class LeadComment : LeadCommentBase, IAuditEntity<Guid>, IEntity
    {
        public Lead Lead { get; set; }

        public User Author { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
