using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagement.Models
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
                Department = Dept.IT,
                Email = "hoangbachhiep2190@gmail.com",
                Name = "hoangbachhiep",
                Id = 1,
                //Key=Guid.Parse("09002689-ebdf-4548-ab56-2549f482e12a")
               
                },
                new Employee()
                {
                 AvatarPatch = "images/img_avatar5.png",
                 Department = Dept.HR,
                 Email = "lequangvu11@gmail.com",
                 Name = "lequangvu23",
                 Id = 2,
                 
                },
                 new Employee()
                {
                 AvatarPatch = "images/img_avatar5.png",
                 Department = Dept.Payroll,
                 Email = "lequangvu11@gmail.com",
                 Name = "lequangvu23",
                 Id = 3
                },
                  new Employee()
                {
                 AvatarPatch = "images/img_avatar5.png",
                 Department = Dept.Sale,
                 Email = "lequangvu11@gmail.com",
                 Name = "lequangvu23",
                 Id = 4
                }
            };
        }

        public Employee Create(Employee employee)
        {
            //employee.Key = Guid.NewGuid();
            employee.Id = employees.Max(e => e.Id) + 1;
            employee.AvatarPatch = "images/img_avatar5.png";
            employees.Add(employee);
            return employee;
        }

        public bool Delete(int id)
        {
            var delEmp = Get(id);
            if (delEmp != null)
            {
                employees.Remove(delEmp);
                return true;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var editEmp = Get(employee.Id);
            editEmp.Name = employee.Name;
            editEmp.Email = employee.Email;
            editEmp.Department = employee.Department;
            return editEmp;
        }

        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
