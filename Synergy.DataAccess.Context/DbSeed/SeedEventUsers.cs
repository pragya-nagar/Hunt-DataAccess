using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedEventUsers
    {
        public static List<EventUser> GeEventUsers(ISynergyContext synergyContext)
        {
            var eventUserList = new List<EventUser>();
            var user = synergyContext.User.Last();

            foreach (Event eventItem in synergyContext.Event)
            {
                for (int index = 1; index < 6; index++)
                {
                    eventUserList.Add(new EventUser
                    {
                        Id = Guid.NewGuid(),
                        UserId = user.Id,
                        EventId = eventItem.Id,
                        DepartmentId = index,
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                    });
                }
            }

            return eventUserList;
        }
    }
}