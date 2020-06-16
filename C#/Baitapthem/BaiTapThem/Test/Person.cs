using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
   public class Person
    {
        private string name { get; set; }
        private int age { get; set; }
    

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }

        
    }
}
