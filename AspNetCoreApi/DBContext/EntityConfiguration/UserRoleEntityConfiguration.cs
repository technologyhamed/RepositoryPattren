using AspNetCoreApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AspNetCoreApi.DBContext.EntityConfiguration
{
    public class UserRoleEntityConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder
                .HasKey(u => new { u.UserId, u.RoleId });
            builder
                .HasOne(u => u.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.UserId);

            builder
               .HasOne(u => u.Role)
               .WithMany(u => u.UserRoles)
               .HasForeignKey(u => u.RoleId);

        }
    }
}
