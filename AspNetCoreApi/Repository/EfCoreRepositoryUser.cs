using AspNetCoreApi.DBContext;
using AspNetCoreApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreApi.Repository
{
    public class EfCoreRepositoryUser : EfCoreRepository<User, WebApiContext>
    {
        private readonly WebApiContext Context;
        public EfCoreRepositoryUser(WebApiContext Context) : base(Context)
        {
            this.Context = Context;

        }
        public async Task<User> UpdateUserBlog(User User, UpdateUserDto UpdateUserDto)
        {
            var user = new User();
            var blog = new Blog
            {

                BlogName = "test",
                Id = 2,
                User = Context.Users.SingleOrDefault(e => e.Id == UpdateUserDto.User.Id)

            };

            if (UpdateUserDto.User.Id == 0)
                UpdateUserDto.User.Id = User.Id;

            user = UpdateUserDto.User ?? User;

            var ListUsers = await Context.Users.Include(b => b.Blogs).AsNoTracking()
                .Where(u => u.Id == User.Id)
                .FirstOrDefaultAsync();

            ListUsers.Id = UpdateUserDto.User.Id;
            ListUsers.FirstName = UpdateUserDto.User.FirstName;
            ListUsers.LastName = UpdateUserDto.User.LastName;
            ListUsers.PhoneNumber = UpdateUserDto.User.PhoneNumber;
            ListUsers.Email = UpdateUserDto.User.Email;
            ListUsers.DateOfBirth = UpdateUserDto.User.DateOfBirth;



            ListUsers.Blogs = UpdateUserDto.Blogs;
            //  Context.Entry(ListUsers).CurrentValues.SetValues(ListUsers);

            //Context.Entry(blog).State = EntityState.Modified;
            // Context.Attach<User>(ListUsers);
            // Context.Attach<Blog>(blog);
            // Context.Attach<Blog>(ListUsers.Blogs);
            //Context.Update(ListUsers);
            await Context.SaveChangesAsync();
            UpdateBlog(UpdateUserDto.Blogs);
            return user;

        }

        private bool UpdateBlog(List<Blog> bolgs)
        {
            foreach (var item in bolgs)
            {
                Context.Entry(item).State = EntityState.Modified;
                Context.Update<Blog>(item);
                Context.SaveChanges();
            }
            return true;
        }
    }
}
