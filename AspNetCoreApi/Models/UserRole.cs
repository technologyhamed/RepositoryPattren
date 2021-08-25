using AspNetCoreApi.Repository;
using System.Collections.Generic;

namespace AspNetCoreApi.Models
{
    public class UserRole:BaseModels,IEntity
    {
        public string UserRoleName { get; set; }
        public UserRole() { }
       
        public UserRole(int Id,string UserRoleName):base(Id)
        {
            this.Id = Id;
            this.UserRoleName = UserRoleName;
        }
        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
