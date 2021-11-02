using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class DepartmentRoleMap : IEntityTypeConfiguration<DepartmentRole>
    {
        public void Configure(EntityTypeBuilder<DepartmentRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(

                // Data departmentId == 1
                new DepartmentRole { Id = new Guid("0e29d810-1756-4c6a-ba5a-7e53368b7d76"), RoleId = new Guid("0648e7b1-f99e-415d-8055-3978690cbc48"), DepartmentId = 1, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-20") },
                new DepartmentRole { Id = new Guid("4652ba7a-dfef-405d-b0f5-c5e1d7597e04"), RoleId = new Guid("b5aa4adb-dae2-4d98-b790-d699ae6d598a"), DepartmentId = 1, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-20") },

                // Acquisition departmentId == 4
                new DepartmentRole { Id = new Guid("5eea7407-38cb-4653-acc8-cc751ea079c2"), RoleId = new Guid("6bb98555-2725-48fd-bc41-6fdde5ef369f"), DepartmentId = 4, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-20") },
                new DepartmentRole { Id = new Guid("cc75b207-c5be-459e-a005-8a805c9604af"), RoleId = new Guid("6fd53327-8211-4f26-a292-b7c3bb9bb1e8"), DepartmentId = 4, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-20") },

                // Accounting departmentId == 2
                new DepartmentRole { Id = new Guid("8226a4b3-bcf2-481d-94d6-9edd181f3c0a"), RoleId = new Guid("20027277-8151-4ef3-85be-897d55299fd0"), DepartmentId = 2, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new DepartmentRole { Id = new Guid("c08c5ca6-1761-403b-84a3-169118e8d1e9"), RoleId = new Guid("df712225-1e14-472e-b9b9-bef411113663"), DepartmentId = 2, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },

                // Management departmentId == 3
                new DepartmentRole { Id = new Guid("5ec63add-d3ad-452d-bf83-6d09f77a8757"), RoleId = new Guid("99f44ca4-57ed-4310-89cf-4700c29cf649"), DepartmentId = 3, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },

                // Asset Management departmentId == 5
                new DepartmentRole { Id = new Guid("35dbcc54-a127-4e23-a1ac-4a8b8492cb9f"), RoleId = new Guid("eb9745bd-1285-440d-b5d8-c35370b38906"), DepartmentId = 5, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },
                new DepartmentRole { Id = new Guid("96c64245-62a6-4bf2-8648-7d19aa83afed"), RoleId = new Guid("2fbbc95e-576c-4acb-b811-e1e1eca5c76a"), DepartmentId = 5, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-21"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-21") },

                // Underwriting departmentId == 6
                new DepartmentRole { Id = new Guid("00dbcc54-a127-4e23-a1ac-4a8b8492cb00"), RoleId = new Guid("2fac0431-b3af-41db-a8ad-38b3b3450d5a"), DepartmentId = 6, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-27") },
                new DepartmentRole { Id = new Guid("00c64245-62a6-4bf2-8648-7d19aa83af00"), RoleId = new Guid("5b33ee78-382c-41e2-8c5d-1e8e7a438ff2"), DepartmentId = 6, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-03-27"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-03-27") },

                // Loan Officers departmentId == 7
                new DepartmentRole { Id = new Guid("ab40020d-42cf-45f0-9704-fb28ea83b250"), RoleId = new Guid("046fe758-8915-4697-8d97-26024d0357ed"), DepartmentId = 7, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-11") },
                new DepartmentRole { Id = new Guid("a574d65d-273b-4a1b-9ff4-b59a1dc175b7"), RoleId = new Guid("a4c28fdc-4799-48a5-a2f2-8462a6bc52bd"), DepartmentId = 7, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-11") },

                // Processing departmentId == 8
                new DepartmentRole { Id = new Guid("201adf09-631e-4dfa-a527-737c1f889e13"), RoleId = new Guid("65f7a408-d363-41be-9b34-aa1c5d75225d"), DepartmentId = 8, IsManager = false, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-07-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-07-22") },
                new DepartmentRole { Id = new Guid("201adf09-631e-4dfa-a527-737c1f889e14"), RoleId = new Guid("02a17713-34ed-4a18-9316-e0148d66c5f3"), DepartmentId = 8, IsManager = true, CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-07-22"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-07-22") });
        }
    }
}
