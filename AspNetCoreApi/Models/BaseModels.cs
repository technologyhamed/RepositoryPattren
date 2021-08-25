using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreApi.Models
{
    public abstract class BaseModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public BaseModels() { }
        public BaseModels(int Id)
        {
            this.Id = Id;
        }
    }

}
