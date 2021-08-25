using AspNetCoreApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCoreApi.DBContext.FluantApi
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder
                .HasMany(u => u.Blogs)
                .WithOne(u=>u.User)
                .HasForeignKey(u => u);

           
        }
    }
}
