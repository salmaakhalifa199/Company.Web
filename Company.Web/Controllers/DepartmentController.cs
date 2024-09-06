﻿using Company.Data.Entities;
using Company.Repository.Interfaces;
using Company.Repository.Repositories;
using Company.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var departments = _departmentService.GetAll();
            return View(departments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Department());
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _departmentService.Add(department);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("DepartmentError", "ValidationError");
                return View(department);
            }
            catch (Exception ex) 
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(department);
            }
        }
        public IActionResult Details(int? id , string viewName="Details") 
        {
             var department = _departmentService.GetById(id);
             if (department is null)
               return RedirectToAction("NotFoundPage",null,"Home");

               return View(viewName,department);
            
        }
        public IActionResult Update(int? id)
        {
            if (id is null)
                return BadRequest();

            return Details(id,"Update");
        }
        [HttpPost]
        public IActionResult Update(int? id,Department department)
        {
            if (department.Id != id.Value)
                return RedirectToAction("NotFoundPage", null , "Home");

            _departmentService.Update(department);
   
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id) 
        {
            if (id is null)
                return BadRequest();

            var department = _departmentService.GetById(id);
            if (department is null)
                return RedirectToAction("NotFoundPage", null, "Home");

            _departmentService.Delete(department);

            return RedirectToAction(nameof(Index));
        }

        // bahwl 3la ad m'dar ani el controller bykonsh maktob feh haga
    }
}
