using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.IsActive).HasDefaultValue(true).ValueGeneratedNever();

            builder.HasData(
                new Role { Id = new Guid("0648e7b1-f99e-415d-8055-3978690cbc48"), Name = "Data", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f"), Name = "Acquisition", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8"), Name = "Acquisition Manager", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("046fe758-8915-4697-8d97-26024d0357ed"), Name = "Loan Officer", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd"), Name = "Loan Officer Manager", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a"), Name = "Underwriting", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2"), Name = "Underwriting Manager", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a"), Name = "Data Manager", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("8913025b-bd62-42f7-964d-a9904ff0d8e9"), Name = "Audit", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-02-18"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-02-18") },
                new Role { Id = new Guid("20027277-8151-4ef3-85be-897d55299fd0"), Name = "Accounting", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new Role { Id = new Guid("df712225-1e14-472e-b9b9-bef411113663"), Name = "Accounting Manager", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new Role { Id = new Guid("eb9745bd-1285-440d-b5d8-c35370b38906"), Name = "Asset Management", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new Role { Id = new Guid("2fbbc95e-576c-4acb-b811-e1e1eca5c76a"), Name = "Asset Management Manager", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new Role { Id = new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649"), Name = "Management", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new Role { Id = new Guid("12a97928-3f1c-4980-887e-678ed0f7f46b"), Name = "Administrator", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-05-10"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-05-10") },
                new Role { Id = new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d"), Name = "Processing", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-07-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-07-22") },
                new Role { Id = new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3"), Name = "Processing Manager", IsActive = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-07-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-07-22") });
        }
    }
}
