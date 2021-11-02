using System;
using System.Collections.Generic;
using Synergy.DataAccess.Entities.OpportunityEntities;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Entities
{
    public abstract class PropertyBase : BaseAudit<Guid>
    {
        public Guid LeadId { get; set; }

        public int StateId { get; set; }

        public int? GeneralLandUseCodeId { get; set; }

        public int? InternalLandUseCodeId { get; set; }

        public string PropertyBK { get; set; }

        public string ParcelId { get; set; }

        public string CADId { get; set; }

        public string TAXId { get; set; }

        public string FolioId { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public int CountyId { get; set; }

        public string LegalDescription { get; set; }

        public string LandStateCode { get; set; }

        public string ImprovementStateCode { get; set; }

        public string LandUseCode { get; set; }

        public bool Over65SurvivingSpouse { get; set; }

        public bool DisabilityExemption { get; set; }

        public bool Mortgage { get; set; }

        public bool PaymentPlan { get; set; }

        public bool Veteran { get; set; }

        public bool Bankruptcy { get; set; }

        public bool ThirdPartyForeclosure { get; set; }

        public float? LandAcres { get; set; }

        public int? BuildingSqFt { get; set; }

        public int? YearBuilt { get; set; }

        public float? Latitude { get; set; }

        public float? Longitude { get; set; }

        public bool? Homestead { get; set; }

        public decimal? RUAmount { get; set; }

        public decimal? RULTVPercent { get; set; }

        public decimal? LTVPercent { get; set; }

        public decimal TotalAmountDue { get; set; }

        public decimal LastYearDue { get; set; }
    }

    public class Property : PropertyBase, IAuditEntity<Guid>, IEntity
    {
        public Lead Lead { get; set; }

        public State State { get; set; }

        public County County { get; set; }

        public GeneralLandUseCode GeneralLandUseCode { get; set; }

        public InternalLandUseCode InternalLandUseCode { get; set; }

        public IEnumerable<PropertyValuation> PropertyValuations { get; set; }

        public IEnumerable<Delinquency> Delinquencies { get; set; }

        public IEnumerable<LoanProperty> LoanProperties { get; set; }

        public IEnumerable<OpportunityProperty> OpportunityProperties { get; set; }

        public IEnumerable<PropertySupplementalEventData> PropertySupplementalEventData { get; set; }

        public IEnumerable<PropertyAttachment> PropertyAttachments { get; set; }

        #region IAuditEntity<Guid> implementation
        public User CreatedBy { get; set; }

        public User ModifiedBy { get; set; }
        #endregion
    }
}
