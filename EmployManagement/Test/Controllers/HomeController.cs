using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
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

            //ViewData["employees"] = employeeRepository.Gets();
            ViewBag.employees = employeeRepository.Gets();
            return View();
        }
    }
}
