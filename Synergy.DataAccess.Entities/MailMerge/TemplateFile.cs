using System;
using System.Collections.Generic;

using Synergy.DataAccess.Entities.MailMerge;

namespace Synergy.DataAccess.Entities
{
    public abstract class TemplateFileBase : BaseAudit<Guid>
    {
        public string FileId { get; set; }

        public string Name { get; set; }

        public int TemplateTypeId { get; set; }

        public int StateId { get; set; }
    }

    public class TemplateFile : TemplateFileBase, IAuditEntity<Guid>, IEntity
    {
        public TemplateType TemplateType { get; set; }

        public State State { get; set; }

        public ICollection<TemplateFileCounty> Counties { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        #endregion
    }
}
