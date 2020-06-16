using System;
using System.Collections;
using System.Collections.Generic;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListDemo ld = new ListDemo();

            //ld.Result();

            //Dictionary di = new Dictionary();
            //di.Show();
            ExampleList ex = new ExampleList();
            ex.Display();
            Console.WriteLine("enter Name:");
            var name = Console.ReadLine();
            var index = -1;
            var emp = ex.Search(name, out index);
            if (emp != null)
            {
                ex.Remove(emp);
                ex.Display();
            }
            if (index != -1)
            {
                ex.RemoveAt(index);
                ex.Display();
            }
            ex.Search(name, out index);
        }
    }
    class ListDemo
    {
        public List<int> ints = new List<int>();
        public List<Employee> employees = new List<Employee>();

        public List<Employee> emp;
        public ListDemo()
        {
            emp = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Name="HoangHiep",
                    Email="hoanghiep@gmail.com"
                }
            };
        }
        public void Show()
        {
           
            emp[0].Email = "b";
        }
        public void Result()
        {
            Console.WriteLine(emp[0].Email);
           
        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}, Name: {Name}, Email:{Email}";
        }
    }
}
