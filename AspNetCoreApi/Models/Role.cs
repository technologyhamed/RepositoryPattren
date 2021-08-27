using AspNetCoreApi.Repository;
using System.Collections.Generic;

namespace AspNetCoreApi.Models
{
    public class Role:BaseModels,IEntity
    {
        public string RoleName { get; set; }

       

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public Role() { }
        public Role(int Id):base(Id)
        {
            this.Id = Id;
            this.RoleName = RoleName;
        }

    }
}
