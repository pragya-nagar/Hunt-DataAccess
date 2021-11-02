using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class StateTaxMap : IEntityTypeConfiguration<StateTaxe>
    {
        public void Configure(EntityTypeBuilder<StateTaxe> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
              new StateTaxe { Id = 1, StateId = 1, TaxRate = 0.43M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 2, StateId = 3, TaxRate = 0.77M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 3, StateId = 7, TaxRate = 2.02M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 4, StateId = 9, TaxRate = 0.56M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 5, StateId = 16, TaxRate = 1.5M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 6, StateId = 14, TaxRate = 2.32M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 7, StateId = 15, TaxRate = 0.87M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 8, StateId = 18, TaxRate = 0.85M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 9, StateId = 28, TaxRate = 1.83M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 10, StateId = 31, TaxRate = 2.4M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 11, StateId = 33, TaxRate = 1.65M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 12, StateId = 36, TaxRate = 1.56M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 13, StateId = 41, TaxRate = 0.57M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 14, StateId = 43, TaxRate = 0.75M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") },
              new StateTaxe { Id = 15, StateId = 44, TaxRate = 1.86M, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-25"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-25") });
        }
    }
}
