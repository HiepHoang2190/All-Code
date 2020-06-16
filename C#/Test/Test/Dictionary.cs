using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Dictionary
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        Dictionary<int, Employee> emps;

        public Dictionary()
        {
            emps = new Dictionary<int, Employee>();
            emps.Add(1, new Employee() 
            {
                Email="Hiephoang@.com",
                Id=1,
                Name="HoangHiep"
                
            });
            emps.Add(2,new Employee()
            {
                Email = "HiepHoang1@gmail.com",
                Id = 2,
                Name = "HoangHiep2"

            });
        }
        public void Show()
        {
            foreach (var key in emps.Keys)
            {
                Console.WriteLine(emps[key]);
            }
            //foreach(var emp in emps.Values)
            //{
            //    Console.WriteLine(emp.Email);
            //}
            //foreach(KeyValuePair<int,Employee> item in emps)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
        }
    }
}
