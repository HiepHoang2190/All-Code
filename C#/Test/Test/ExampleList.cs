using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class ExampleList
    {
        public List<Employee> employees;
        public ExampleList()
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Name="Hiephoang1",
                    Email="Hiephoang@gmail.com"
                },
                new Employee()
                {
                    Id=2,
                    Name="MinhHoang",
                    Email="Minhhoang@gmail.com"
                }
            };
        }

        public void Add(Employee emp)
        {
            employees.Add(emp);
        }
        public Employee Search(string name, out int index)
        {
            index = -1;
            foreach(var emp in employees)
            {
               
                if (emp.Name.Equals(name))
                {
                    index = employees.IndexOf(emp);
                    return emp;
                }
            }
            return new Employee();
        }
        public bool Remove(Employee emp)
        {
            return employees.Remove(emp);
         
        }
        public void RemoveAt(int index)
        {
            employees.RemoveAt(index);
        }
        public void Display()
        {
            foreach(var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
