using EmployManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace EmployManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        //public HomeController()
        //{
        //    employeeRepository = new EmployeeRepository();
        //}
        public HomeController(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.employeeRepository = employeeRepository;
            this.webHostEnvironment = webHostEnvironment;
        }
        [AllowAnonymous]
        public ViewResult Index()
        {
            //ViewData["employees"] = employeeRepository.Gets();
            //ViewBag.employess = employeeRepository.Gets();
            var employees = employeeRepository.Gets();
            return View(employees);


        }
        public ViewResult Details(int? id)
        {
            //ViewBag.employess = employeeRepository.Get(id);
            //var employee= employeeRepository.Get(id);
            //ViewBag.TitleName = "Employee Detail";
            var employee = employeeRepository.Get(id.Value);
            if (employee == null)
            {
                //ViewBag.Id = id.Value;
                return View("~/Views/Error/EmployeeNotFound.cshtml", id.Value);
            }


            var detaiViewModel = new HomeDetailViewModel()
            {
                Employee = employeeRepository.Get(id ?? 1),
                TitleName = "Employee Detail"
            };
            return View(detaiViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department
                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                }
                employee.AvatarPatch = fileName;
                var newEmp = employeeRepository.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
        }
        public ViewResult Edit(int id)
        {
            var employee = employeeRepository.Get(id);
            var empEdit = new HomeEditViewModel()
            {
                AvatarPath = employee.AvatarPatch,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department,
                Id = employee.Id,
                City = employee.City,
                Address = employee.Address

            };
            return View(empEdit);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            //if (employeeRepository.Edit(model) != null)
            //{
            //    return RedirectToAction("Details", new { id = model.Id });
            //}
            //return View();
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    Id=model.Id,
                    AvatarPatch=model.AvatarPath,
                    City=model.City,
                    Address=model.Address
                };
                var fileName = string.Empty;
                if (model.Avatar != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Avatar.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Avatar.CopyTo(fs);
                    }
                    employee.AvatarPatch = fileName;
                    if (!string.IsNullOrEmpty(model.AvatarPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath, "images",model.AvatarPath);
                        System.IO.File.Delete(delFile);
                    }
                }
              
                var editEmp = employeeRepository.Edit(employee);
                if (employee != null)
                {
                    return RedirectToAction("Details", new { id = model.Id });
                }

            }

            return View();
        }
        public IActionResult Delete(int id)
        {
            if (employeeRepository.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        //public string Index()
        //{

        //    //var employee = new Employee()
        //    //{
        //    //    AvatarPatch = "images/lion.jpg",
        //    //    Department = "It",
        //    //    Email = "hoangbachhiep2190@gmail.com",
        //    //    Name = "hoangbachhiep",
        //    //    Id = 1
        //    //};
        //    //return employee.ToString();
        //    //return "Xin chào các bạn C0200";
        //}
    }
}
