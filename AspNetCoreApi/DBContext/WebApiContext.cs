using AspNetCoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetCoreApi.DBContext
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



    }
}
