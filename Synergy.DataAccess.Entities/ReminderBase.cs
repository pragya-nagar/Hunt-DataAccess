using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class ReminderBase : BaseAudit<Guid>
    {
        public Guid? UserId { get; set; }

        public Guid? LeadId { get; set; }

        public Guid? OpportunityId { get; set; }

        public Guid? ContactId { get; set; }

        public string Description { get; set; }

        public DateTime SheduledDate { get; set; }

        public TimeSpan SheduledTime { get; set; }

        public bool? IsPushNotification { get; set; }

        public bool? IsEmailNotification { get; set; }

        public int? Status { get; set; }

        public bool? IsRead { get; set; }

        public DateTime? InstantPushNotificationSentDateTime { get; set; }

        public DateTime? PushNotificationSentDateTime { get; set; }

        public DateTime? EmailNotificationSentDateTime { get; set; }
    }
}
