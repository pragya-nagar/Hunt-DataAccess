using System;

namespace Synergy.DataAccess.Entities
{
    public class PropertyNotesBase : BaseAudit<Guid>
    {
        public Guid PropertyId { get; set; }

        public Guid AuthorId { get; set; }

        public string Note { get; set; }

        public DateTime NoteAddedDate { get; set; }
    }
}
