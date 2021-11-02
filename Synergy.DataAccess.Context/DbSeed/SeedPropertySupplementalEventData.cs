using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedPropertySupplementalEventData
    {
        public static IEnumerable<PropertySupplementalEventData> GetPropertySupplementalEventData(ISynergyContext synergyContext)
        {
            var list = new List<PropertySupplementalEventData>();
            var eventDelinqyencies = synergyContext.Delinquency.Where(d => d.EventId != null).ToList();
            var user = synergyContext.User.First();

            foreach (var delinqyency in eventDelinqyencies)
            {
                var propertyValuationId = Guid.NewGuid();
                list.Add(new PropertySupplementalEventData
                {
                    Id = propertyValuationId,
                    PropertyId = delinqyency.PropertyId,
                    DelinquencyId = delinqyency.Id,
                    LastSaleDate = DateTime.Now,
                    LastSaleAmount = 223500,
                    MortgageLender1 = "Bank of America",
                    MortgageLoanAmount1 = 180000,
                    MortgageOriginationDate1 = DateTime.Now,
                    MortgageMaturityDate1 = DateTime.Now,
                    MortgageLender2 = "US Bank",
                    MortgageLoanAmount2 = 10000,
                    MortgageOriginationDate2 = DateTime.Now,
                    MortgageMaturityDate2 = DateTime.Now,
                    InspectorComment = "Roof:  Needs Maintenance;  Comment:  Small single-family brick ranch located on a very quiet small street.",
                    InspectorAreaRating = 3,
                    InspectorPropertyRating = 3,
                    InspectorOccupied = true,
                    OpenLiens = 2,
                    ClosedLiens = 1,
                    RecentBuyerName = "Caz Creek",
                    RecentBuyerRate = 0.25m,
                    AdvertisementBatch = "5",
                    AdvertisementNumber = "15631",
                    InspectorLawnMaintained = $"{Random.Next(0, 20000)}",
                    InspectorRoofCondition = " Needs Maintenance",
                    CreatedBy = user,
                    CreatedOn = DateTime.Now,
                    ModifiedBy = user,
                    ModifiedOn = DateTime.Now,
                });
            }

            return list;
        }
    }
}
