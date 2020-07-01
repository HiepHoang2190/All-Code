using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
    }
}
