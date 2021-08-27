using AspNetCoreApi.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreApi.Models
{
    public class Blog:BaseModels,IEntity
    {
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string BlogName { get; set; }
        public Blog() { }
       
        public Blog(int Id):base(Id)
        {
            this.Id = Id;
            this.BlogName = BlogName;
        }

        public virtual User User { get; set; }



    }
}
