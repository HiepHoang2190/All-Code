using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test1.Models;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;

        public HomeController()
        {
            employeeRepository = new EmployeeRepository();
        }

        public ViewResult Index()
        {
            //ViewBag.employees = employeeRepository.Gets();
            var employees = employeeRepository.Gets();
            return View(employees);
        }
        public ViewResult Details(int id)
        {
            var employee = employeeRepository.Get(id);
             ViewBag.TitleName = "Employee Details";
            return View(employee);
        }

        
      
    }
}
