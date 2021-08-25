using AspNetCoreApi.DBContext;
using AspNetCoreApi.Models;

namespace AspNetCoreApi.Repository
{
    public class EfCoreRepositoryUser : EfCoreRepository<User, WebApiContext>
    {
        public EfCoreRepositoryUser(WebApiContext Context) : base(Context)
        {
            // Add onther methods
        }
        
    }
}
