using System;

namespace Synergy.DataAccess.Entities.MailMerge
{
    public abstract class TemplateFileCountyBase : BaseAudit<Guid>
    {
        public Guid TemplateFileId { get; set; }

        public int CountyId { get; set; }
    }

    public class TemplateFileCounty : TemplateFileCountyBase, IAuditEntity<Guid>, IEntity
    {
        public TemplateFile TemplateFile { get; set; }

        public County County { get; set; }

        #region IAuditEntity<Guid> implementation

        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }

        #endregion
    }
}
