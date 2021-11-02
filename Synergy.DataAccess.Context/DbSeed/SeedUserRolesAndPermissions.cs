using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedUserRolesAndPermissions
    {
        public static List<UserRole> GetUserRoles(ISynergyContext synergyContext, Guid systemUser)
        {
            var list = new List<UserRole>();
            foreach (User user in synergyContext.User.Where(u => u.Id != systemUser))
            {
                foreach (Role role in synergyContext.Role)
                {
                    list.Add(new UserRole
                    {
                        Id = Guid.NewGuid(), RoleId = role.Id, UserId = user.Id,
                        CreatedById = systemUser, ModifiedById = systemUser,
                        CreatedOn = DateTime.UtcNow, ModifiedOn = DateTime.UtcNow,
                    });
                }
            }

            return list;
        }
    }
}
