using AspNetCoreApi.Models;
using AspNetCoreApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseDataBaseController<User, EfCoreRepositoryUser>
    {
        private readonly EfCoreRepositoryUser repositoryUser;
        public UserController(EfCoreRepositoryUser repositoryUser) : base(repositoryUser)
        {
            this.repositoryUser = repositoryUser;
        }


        [Route("api/User/UpdateBlogUserId/{id}")]
        [HttpPut("UpdateBlogUserId/{id}", Name = "UpdateBlogUserId")]
        public async Task<ActionResult<User>> UpdateBlogUserId(int Id, UpdateUserDto UpdateUserDto)
        {
            if (string.IsNullOrEmpty(Id.ToString()))
                return Content("UserId is not Find");
            var User = await repositoryUser.GetId(Id);
            if (User is null)
                return Content("User is not Found");
            var ListUser = await repositoryUser.UpdateUserBlog(User, UpdateUserDto);
            return ListUser;


        }
    }
}
