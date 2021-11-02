using System.Linq;

using Synergy.DataAccess.Context.DbSeed;

namespace Synergy.DataAccess.Context
{
    public partial class SynergyContext
    {
        /// <summary>
        /// Performs demo data seeding.
        /// </summary>
        public void EnsureSeedData()
        {
            if (User.Count() == 1 || User.Count() == 3)
            {
                User.AddRange(SeedUser.GetUsers(this, Common.Constants.User.SystemUserId));
                SaveChanges();
            }

            if (!Event.Any())
            {
                Event.AddRange(SeedEvent.GetEvents(this));
                SaveChanges();
            }

            if (!Lead.Any())
            {
                Lead.AddRange(SeedLead.GetLeads(this));
                SaveChanges();
            }

            if (!Property.Any())
            {
                Property.AddRange(SeedProperty.GetProperties(this));
                SaveChanges();
            }

            if (!Campaign.Any())
            {
                Campaign.AddRange(SeedCampaign.GetCampaign(this));
                SaveChanges();
            }

            if (!Delinquency.Any())
            {
                Delinquency.AddRange(SeedDelinquency.GetDelinquencies(this));
                SaveChanges();
            }

            // second condition only to support old db`s
            if (!CollectingEntity.Any() || CollectingEntity.Count() == 1)
            {
                CollectingEntity.AddRange(SeedCollectingEntities.GetCollectingEntities(this));
                SaveChanges();
            }

            if (!PropertySupplementalEventData.Any())
            {
                PropertySupplementalEventData.AddRange(SeedPropertySupplementalEventData.GetPropertySupplementalEventData(this));
                SaveChanges();
            }

            if (!PropertyValuation.Any())
            {
                PropertyValuation.AddRange(SeedPropertyValuation.GetPropertyValuation(this));
                SaveChanges();
            }

            if (!Contact.Any())
            {
                Contact.AddRange(SeedLeadContacts.GetContacts(this));
                SaveChanges();
            }

            if (!UserRole.Any())
            {
                UserRole.AddRange(SeedUserRolesAndPermissions.GetUserRoles(this, Common.Constants.User.SystemUserId));
                SaveChanges();
            }

            if (!EventUser.Any())
            {
                EventUser.AddRange(SeedEventUsers.GeEventUsers(this));
                SaveChanges();
            }
        }
    }
}
