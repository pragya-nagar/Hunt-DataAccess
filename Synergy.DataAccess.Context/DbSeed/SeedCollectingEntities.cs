using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedCollectingEntities
    {
        public static IEnumerable<CollectingEntity> GetCollectingEntities(ISynergyContext synergyContext)
        {
            var collectingEntitiesList = new List<CollectingEntity>();
            var collectingEventTypes = synergyContext.CollectingEntityType.Select(t => t.Id).ToList();
            var user = synergyContext.User.First();
            int i = 1;
            foreach (var delinquencyId in synergyContext.Delinquency.Select(t => t.Id).ToList())
            {
                collectingEntitiesList.Add(
                    new CollectingEntity()
                    {
                        Id = Guid.NewGuid(),
                        DelinquencyId = delinquencyId,
                        CollectingEntityTypeId = collectingEventTypes[Random.Next(0, collectingEventTypes.Count())],
                        AmountDue = (decimal)Random.Next(1000, 10000),
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                    });

                if (i % 2 == 0)
                {
                    continue;
                }

                collectingEntitiesList.Add(
                    new CollectingEntity()
                    {
                        Id = Guid.NewGuid(),
                        DelinquencyId = delinquencyId,
                        CollectingEntityTypeId = collectingEventTypes[Random.Next(0, collectingEventTypes.Count())],
                        AmountDue = (decimal)Random.Next(1000, 10000),
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                    });
                i++;
            }

            return collectingEntitiesList;
        }
    }
}
