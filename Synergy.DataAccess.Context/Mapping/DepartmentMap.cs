using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Department { Id = 1, Name = "Data", Description = "Data", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-26") },
                new Department { Id = 2, Name = "Accounting", Description = "Accounting", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-26") },
                new Department { Id = 3, Name = "Management", Description = "Management", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-26") },
                new Department { Id = 4, Name = "Acquisition", Description = "Acquisition", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-26") },
                new Department { Id = 5, Name = "Asset Management", Description = "Asset Management", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-26"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-26") },
                new Department { Id = 6, Name = "Underwriters", Description = "Underwriters", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-31") },
                new Department { Id = 7, Name = "Loan Officers", Description = "Loan Officers", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-11") },
                new Department { Id = 8, Name = "Processing", Description = "Processing", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-25") });
        }
    }
}
