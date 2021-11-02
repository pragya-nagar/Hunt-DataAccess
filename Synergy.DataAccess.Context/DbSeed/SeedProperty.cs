using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedProperty
    {
        public static List<Property> GetProperties(ISynergyContext synergyContext)
        {
            var list = new List<Property>();
            var user = synergyContext.User.First();
            foreach (Lead lead in synergyContext.Lead)
            {
                for (int i = 0; i < 2; i++)
                {
                    bool isDoubt = i % 2 > 0;
                    var property = new Property()
                    {
                        LeadId = lead.Id,
                        StateId = 1,
                        GeneralLandUseCodeId = 1,
                        PropertyBK = $"",
                        ParcelId = $"00000270723{i}",
                        CADId = $"R1061500A0010{i}",
                        TAXId = $"270723{i}",
                        FolioId = $"",
                        Address = $"7255 MEADOW HILL DR {i}",
                        City = $"FRISCO {i}",
                        ZipCode = $"75033{i}",
                        CountyId = 1,
                        LegalDescription = $"FRISCO SOCCER (CFR), BLK A, LOT 1, 6.929 ACRES {i}",
                        LandStateCode = "F6",
                        ImprovementStateCode = "F6",
                        LandUseCode = "Real Estate Commercial",
                        Over65SurvivingSpouse = i % 2 > 0,
                        DisabilityExemption = isDoubt,
                        Mortgage = !isDoubt,
                        PaymentPlan = isDoubt,
                        Veteran = !isDoubt,
                        Bankruptcy = isDoubt,
                        ThirdPartyForeclosure = !isDoubt,
                        LandAcres = i,
                        BuildingSqFt = i * 44,
                        YearBuilt = 1995 + i,
                        Latitude = 34,
                        Longitude = 100,
                        Homestead = isDoubt,
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                    };
                    list.Add(property);
                }
            }

            return list;
        }
    }
}
