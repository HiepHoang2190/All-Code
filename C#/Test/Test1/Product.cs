using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get;set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
