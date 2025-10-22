using Demo.BLL.DTOs.DepartmentDtos;
using Demo.BLL.DTOs.EmployeeDtos;
using Demo.BLL.Services.Classes;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Models;
using Demo.DAL.Models.Enums;
using Demo.PL.Models.DepartmentViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger _logger;
        private readonly IWebHostEnvironment _environment;

        public EmployeeController(IEmployeeService employeeService , ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _employeeService = employeeService;
            _logger = logger;
            _environment = environment;
        }
        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(AddEmployeeDto Employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _employeeService.AddEmployee(Employee);
                    if (result > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "employee Can't Be Added");
                        return View(Employee);
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);
                        return View(Employee);
                    }
                    else
                    {
                        //_logger.LogError(ex.Message);
                        return View(Employee);
                    }

                }

            }
            else return View(Employee);

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var employee = _employeeService.GetEmployeeById(id.Value);
            if (employee is null) return NotFound();
            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var employee = _employeeService.GetEmployeeById(id.Value);
            if (employee is null) return NotFound();

            var dto = new UpdateEmployeeDto()
            {
                Id = id.Value,
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                IsActive = employee.IsActive,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType),
                Gender = Enum.Parse<Gender>(employee.Gender)
            };
            
            return View(dto);

        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id, UpdateEmployeeDto employee)
        {
            if (!ModelState.IsValid) return View(employee);
            try
            {
                var result = _employeeService.UpdateEmployee(employee);
                if (result > 0) return RedirectToAction(nameof(Index));
                return View(employee);
            }
            catch (Exception ex)
            {
                return View(employee);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _employeeService.DeleteEmployee(id);
                if (result > 0) return RedirectToAction(nameof(Index), new {id});
                return View(id);
            }
            catch (Exception ex)
            {
                return View(id);
            }
        }

    }
}
