using EmployManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagement.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Must enter full name")]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@"
            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Avatar { get; set; }
    }
}
