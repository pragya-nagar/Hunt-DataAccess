using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedLead
    {
        public static List<Lead> GetLeads(ISynergyContext synergyContext)
        {
            var user = synergyContext.User.First();
            var list = new List<Lead>();

            for (var i = 1; i <= 1000; i++)
            {
                var leadGuid = Guid.NewGuid();
                list.Add(new Lead
                {
                    Id = leadGuid,
                    AccountName = $"Test Account Name #{i}",
                    MailingAddress1 = $"Test Address1 #{i}",
                    MailingAddress2 = $"Test Address2 #{i}",
                    MailingAddress3 = $"Test Address3 #{i}",
                    MailingCity = $"Test City #{i}",
                    MailingStateId = 1,
                    MailingZipCode = $"000{i}",
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
