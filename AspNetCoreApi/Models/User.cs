using AspNetCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace AspNetCoreApi.Models
{
    public class User : BaseModels, IEntity
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string LastName { get; set; }
        [StringLength(20, MinimumLength = 8)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [StringLength(20, MinimumLength = 5)]
        public string Email { get; set; }

      
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }


        public User() { }
       
        public User(int Id) : base(Id)
        {
            this.Id = Id;
        }

        public User(int Id, string FirstName, string LastName, DateTime DateOfBirth, string PhoneNumber, string Email) : base(Id)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;

        }
        
    }
}
