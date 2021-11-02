using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(x => x.IsActive).HasDefaultValue(true).ValueGeneratedNever();

            builder
                .HasOne(p => p.CreatedBy)
                .WithMany()
                .HasForeignKey(p => p.Id)
                .HasConstraintName("FK_User_User_CreatedById");

            builder
                .HasOne(p => p.ModifiedBy)
                .WithMany()
                .HasForeignKey(p => p.Id)
                .HasConstraintName("FK_User_User_ModifiedById");

            builder.HasData(
                new User
                {
                    Id = Common.Constants.User.SystemUserId,
                    Email = "system@user",
                    FirstName = "system",
                    LastName = "user",
                    CreatedById = Common.Constants.User.SystemUserId,
                    CreatedOn = DateTime.Parse("2018-12-11"),
                    ModifiedById = Common.Constants.User.SystemUserId,
                    ModifiedOn = DateTime.Parse("2018-12-11"),
                });
        }
    }
}
