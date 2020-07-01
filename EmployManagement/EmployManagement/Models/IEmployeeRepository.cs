using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagement.Models
{
    public interface IEmployeeRepository
    {   
        //Employee Get (Guid key);
        IEnumerable<Employee> Gets();
        Employee Get(int id);
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        bool Delete(int id);
      
    }
}
