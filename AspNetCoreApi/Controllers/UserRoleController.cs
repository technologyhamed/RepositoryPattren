using AspNetCoreApi.Models;
using AspNetCoreApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : BaseDataBaseController<UserRole, EfCoreRepositoryUserRole>
    {
        public UserRoleController(EfCoreRepositoryUserRole repositoryUserRole) : base(repositoryUserRole)
        {
           
        }
    }
}
