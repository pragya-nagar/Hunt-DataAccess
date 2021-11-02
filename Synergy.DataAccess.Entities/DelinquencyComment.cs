using System;

namespace Synergy.DataAccess.Entities
{
    public class DelinquencyCommentBase : BaseAudit<Guid>
    {
        public Guid DelinquencyId { get; set; }

        public Guid AuthorId { get; set; }

        public string Comment { get; set; }

        public DateTime CommentDate { get; set; }
    }

    public class DelinquencyComment : DelinquencyCommentBase, IAuditEntity<Guid>, IEntity
    {
        public Delinquency Delinquency { get; set; }

        public User Author { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
