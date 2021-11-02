using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedPropertyValuation
    {
        public static IEnumerable<PropertyValuation> GetPropertyValuation(ISynergyContext synergyContext)
        {
            var list = new List<PropertyValuation>();
            var propertyIds = synergyContext.Property.Select(l => l.Id).ToList();
            var user = synergyContext.User.First();

            foreach (var id in propertyIds)
            {
                for (int i = 0; i < 5; i++)
                {
                    var propertyValuationId = Guid.NewGuid();
                    list.Add(new PropertyValuation
                    {
                        Id = propertyValuationId,
                        PropertyId = id,
                        AppraisedValue = 10324767 + i,
                        AppraisedYear = 2018,
                        ImprovementValue = 8515894 + i,
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                    });
                }
            }

            return list;
        }
    }
}
