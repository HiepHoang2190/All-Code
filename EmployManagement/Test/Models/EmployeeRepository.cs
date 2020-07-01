using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                 new Employee()
                {
                AvatarPatch = "images/img_avatar1.png",
                Department = "It",
                Email = "hoangbachhiep2190@gmail.com",
                Name = "hoangbachhiep",
                Id = 1
                },
                new Employee()
                {
                 AvatarPatch = "images/img_avatar5.png",
                 Department = "It",
                 Email = "lequangvu11@gmail.com",
                 Name = "lequangvu23",
                 Id = 2
                },
                 new Employee()
                {
                 AvatarPatch = "images/img_avatar5.png",
                 Department = "It",
                 Email = "lequangvu11@gmail.com",
                 Name = "lequangvu23",
                 Id = 2
                },
                  new Employee()
                {
                 AvatarPatch = "images/img_avatar5.png",
                 Department = "It",
                 Email = "lequangvu11@gmail.com",
                 Name = "lequangvu23",
                 Id = 2
                }
            }; 
        }
        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
