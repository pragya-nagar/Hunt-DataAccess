using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synergy.DataAccess.Entities.Processing;

namespace Synergy.DataAccess.Context.Mapping
{
    internal class LoanPropertyTypeMap : IEntityTypeConfiguration<LoanPropertyType>
    {
        public void Configure(EntityTypeBuilder<LoanPropertyType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(
                new LoanPropertyType { Id = 1, Name = "ResidentialOwnerOccupied", Description = "Residential – Owner Occupied", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-20") },
                new LoanPropertyType { Id = 2, Name = "ResidentialNonOwnerOccupied", Description = "Residential – Non-Owner Occupied", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-20") },
                new LoanPropertyType { Id = 3, Name = "CommercialIndividuallyOwned", Description = "Commercial – Individually Owned", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-20") },
                new LoanPropertyType { Id = 4, Name = "CommercialEntityOwned", Description = "Commercial – Entity Owned", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-20") },
                new LoanPropertyType { Id = 5, Name = "CommercialLand", Description = "Commercial - Land", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2019-06-20"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2019-06-20") });
        }
    }
}
