using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedCampaign
    {
        public static IEnumerable<Campaign> GetCampaign(ISynergyContext synergyContext)
        {
            var list = new List<Campaign>();

            var users = synergyContext.User;
            var leadsIds = synergyContext.Lead.Select(l => l.Id).ToList();
            List<int> campaignTypeIds = synergyContext.CampaignType.Select(e => e.Id).ToList();

            foreach (User user in users)
            {
                for (int i = 0; i < 500; i++)
                {
                    var campaignId = Guid.NewGuid();
                    list.Add(new Campaign
                    {
                        Id = campaignId,
                        TargetDate = DateTime.Now.AddDays(+(i - 1)),
                        AssignedUserId = user.Id,
                        CampaignTypeId = campaignTypeIds[Random.Next(0, campaignTypeIds.Count())],
                        CampaignName = $"#{i}",
                        StateId = 1,
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                        CampaignLeads = new List<CampaignLead>()
                        {
                            new CampaignLead()
                            {
                                CampaignId = campaignId,
                                LeadId = leadsIds[Random.Next(0, leadsIds.Count())],
                                CreatedBy = user,
                                CreatedOn = DateTime.Now,
                                ModifiedBy = user,
                                ModifiedOn = DateTime.Now,
                            },
                        },
                    });
                }
            }

            return list;
        }
    }
}
