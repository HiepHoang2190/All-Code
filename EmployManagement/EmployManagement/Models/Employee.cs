using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagement.Models
{
    public class Employee
    {  
        //public Guid Key { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Must enter full name")]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [Display(Name="Office Email")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@"
            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",ErrorMessage ="Invalid email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string AvatarPatch { get; set; }
        public string City { get; set; }
        public string  Address { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name},Email:{Email}, Department:{Department}, AvartarPatch:{AvatarPatch}";
        }


    }
}
