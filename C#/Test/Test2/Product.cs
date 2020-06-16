using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}\t Name:{Name}";
        }
    }
}
