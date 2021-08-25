using AspNetCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
