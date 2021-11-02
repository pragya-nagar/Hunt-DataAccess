using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class AuctionTypeMap : IEntityTypeConfiguration<AuctionType>
    {
        public void Configure(EntityTypeBuilder<AuctionType> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(
               new AuctionType { Id = 1, Name = "RFP", Description = "RFP", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new AuctionType { Id = 2, Name = "AuctionLive", Description = "Auction - Live", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new AuctionType { Id = 3, Name = "AuctionOnline", Description = "Auction - Online", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") },
               new AuctionType { Id = 4, Name = "NegotiatedContract", Description = "Negotiated Contract", CreatedById = Common.Constants.User.SystemUserId, CreatedOn = DateTime.Parse("2018-12-11"), ModifiedById = Common.Constants.User.SystemUserId, ModifiedOn = DateTime.Parse("2018-12-11") });
        }
    }
}
