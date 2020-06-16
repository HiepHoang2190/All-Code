using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
 public   class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, PhoneNumber: {PhoneNumber}";
        }
    }
}
