using System;

namespace Synergy.DataAccess.Entities
{
    public abstract class PropertySupplementalEventDataBase : BaseAudit<Guid>
    {
        public Guid PropertyId { get; set; }

        public Guid DelinquencyId { get; set; }

        public DateTime? LastSaleDate { get; set; }

        public decimal? LastSaleAmount { get; set; }

        public string MortgageLender1 { get; set; }

        public decimal? MortgageLoanAmount1 { get; set; }

        public DateTime? MortgageOriginationDate1 { get; set; }

        public DateTime? MortgageMaturityDate1 { get; set; }

        public string MortgageLender2 { get; set; }

        public decimal? MortgageLoanAmount2 { get; set; }

        public DateTime? MortgageOriginationDate2 { get; set; }

        public DateTime? MortgageMaturityDate2 { get; set; }

        public string InspectorComment { get; set; }

        public decimal? InspectorPropertyRating { get; set; }

        public decimal? InspectorAreaRating { get; set; }

        public bool? InspectorOccupied { get; set; }

        public string InspectorRoofCondition { get; set; }

        public string InspectorLawnMaintained { get; set; }

        public int? OpenLiens { get; set; }

        public int? ClosedLiens { get; set; }

        public string RecentBuyerName { get; set; }

        public decimal? RecentBuyerRate { get; set; }

        public string AdvertisementBatch { get; set; }

        public string AdvertisementNumber { get; set; }

        public string AssessorURL { get; set; }

        public string TreasurerURL { get; set; }

        public string GisURL { get; set; }
    }

    public class PropertySupplementalEventData : PropertySupplementalEventDataBase, IAuditEntity<Guid>, IEntity
    {
        public Property Property { get; set; }

        public Delinquency Delinquency { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
