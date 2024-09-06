using Company.Data.Entities;
using Company.Services.Interfaces;
using Company.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            //IEnumerable<Employee> employees = new List<Employee>();
            var employees = _employeeService.GetAll();  
            return View(employees);

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);
                    return RedirectToAction(nameof(Index));        }
                return View(employee);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("EmployeeError", ex.Message);
                return View(employee);
            }
        }


        public IActionResult Details(int? id, string viewName = "Details")
        {
            var employee = _employeeService.GetById(id);
            if (employee is null)
                return RedirectToAction("NotFoundPage", null, "Home");

            return View(viewName, employee);

        }
        public IActionResult Update(int? id)
        {
            if (id is null)
                return BadRequest();

            return Details(id, "Update");
        }
        [HttpPost]
        public IActionResult Update(int? id, Employee employee)
        {
            if (employee.Id != id)
                return RedirectToAction("NotFoundPage", null, "Home");

            _employeeService.Update(employee);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id is null)
                return BadRequest();

            var employee = _employeeService.GetById(id);
            if (employee is null)
                return RedirectToAction("NotFoundPage", null, "Home");

            _employeeService.Delete(employee);

            return RedirectToAction(nameof(Index));
        }
    }
}
