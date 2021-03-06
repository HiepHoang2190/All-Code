﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string  Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string  AvatarPatch { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name},Email:{Email}, Department:{Department}, AvartarPatch:{AvatarPatch}";
        }
    }
}
