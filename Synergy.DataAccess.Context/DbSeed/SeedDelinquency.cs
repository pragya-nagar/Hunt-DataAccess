using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedDelinquency
    {
        public static List<Delinquency> GetDelinquencies(ISynergyContext synergyContext)
        {
            var delinquencyList = new List<Delinquency>();

            var propertyIds = synergyContext.Property.Select(l => l.Id).ToList();
            var opportunityIds = synergyContext.Opportunity.Select(e => e.Id).ToList();
            var eventIds = synergyContext.Event.Select(x => x.Id).ToList();
            var user = synergyContext.User.First();

            foreach (Guid propertyId in propertyIds)
            {
                var delinquencyId2019 = Guid.NewGuid();
                delinquencyList.Add(new Delinquency()
                {
                    Id = delinquencyId2019,
                    PropertyId = propertyId,
                    DelinquencyTaxYear = 2019,
                    CreatedBy = user,
                    CreatedOn = DateTime.Now,
                    ModifiedBy = user,
                    ModifiedOn = DateTime.Now,
                    EventId = eventIds[Random.Next(0, eventIds.Count())],
                });
            }

            return delinquencyList;
        }
    }
}
