using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedLeadContacts
    {
        public static List<Contact> GetContacts(ISynergyContext synergyContext)
        {
            int i = 1;
            var contacts = new List<Contact>();
            var user = synergyContext.User.First();
            foreach (Lead lead in synergyContext.Lead)
            {
                contacts.AddRange(
                    new List<Contact>
                    {
                        new Contact
                        {
                            LeadId = lead.Id,
                            ContactTypeId = 1,
                            Title = $"Test Title #{i}",
                            CellPhone = $"(000) 000-000-{i}",
                            OfficePhone = $"(000) 000-000-{i}",
                            Email = $"test{i}@test.test",
                            FirstName = $"Name {i}",
                            MiddleName = $"Middle {i}",
                            LastName = $"Last {i}",
                            MailingAddress1 = $"Address1 {i}",
                            MailingAddress2 = $"Address2 {i}",
                            MailingAddress3 = $"Address3 {i}",
                            MailingCity = $"City {i}",
                            MailingStateId = 1,
                            MailingZipCode = $"Zip {i}",
                            CreatedBy = user,
                            CreatedOn = DateTime.Now,
                            ModifiedBy = user,
                            ModifiedOn = DateTime.Now,
                        },
                        new Contact
                        {
                            LeadId = lead.Id,
                            ContactTypeId = 1,
                            Title = $"Second Test Title #{i}",
                            CellPhone = $"(000) 000-000-{i}",
                            OfficePhone = $"(000) 000-000-{i}",
                            Email = $"test{i}@test.test",
                            FirstName = $"Name {i}",
                            MiddleName = $"Middle {i}",
                            LastName = $"Last {i}",
                            MailingAddress1 = $"Address1 {i}",
                            MailingAddress2 = $"Address2 {i}",
                            MailingAddress3 = $"Address3 {i}",
                            MailingCity = $"City {i}",
                            MailingStateId = 1,
                            MailingZipCode = $"Zip {i}",
                            CreatedBy = user,
                            CreatedOn = DateTime.Now,
                            ModifiedBy = user,
                            ModifiedOn = DateTime.Now,
                        },
                    });

                i++;
            }

            return contacts;
        }
    }
}
