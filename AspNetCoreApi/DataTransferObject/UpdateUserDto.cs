using AspNetCoreApi.Models;
using System.Collections.Generic;

namespace AspNetCoreApi
{
    public class UpdateUserDto
    {
        public User User { get; set; }
        public List<Blog>  Blogs { get; set; }
        public List<UserRole> UserRole { get; set; }
    }
}
