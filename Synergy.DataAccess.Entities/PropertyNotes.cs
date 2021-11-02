using System;

namespace Synergy.DataAccess.Entities
{
    public class PropertyNotes : PropertyNotesBase, IAuditEntity<Guid>, IEntity
    {
        public Property Property { get; set; }

        public User Author { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
