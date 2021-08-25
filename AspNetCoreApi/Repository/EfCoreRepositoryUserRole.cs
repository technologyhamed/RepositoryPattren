using AspNetCoreApi.DBContext;
using AspNetCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApi.Repository
{
    public class EfCoreRepositoryUserRole : EfCoreRepository<UserRole, WebApiContext>
    {
        public EfCoreRepositoryUserRole(WebApiContext Context) : base(Context)
        {
        }
        public IAsyncResult Test()
        {
            return null;
        }
    }
}
