using Demo.BLL.DTOs.DepartmentDtos;
using Demo.BLL.DTOs.EmployeeDtos;
using Demo.BLL.Services.Classes;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Models;
using Demo.DAL.Models.Enums;
using Demo.PL.Models.DepartmentViewModels;
using Demo.PL.Models.EmployeeViewModels;
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
        public IActionResult Create(EmployeeViewModel Employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var dto = new AddEmployeeDto()
                    {
                        Name = Employee.Name,
                        DepartmentId = Employee.DepartmentId,
                        Address = Employee.Address,
                        Age = Employee.Age,
                        Email = Employee.Email,
                        EmployeeType = Employee.EmployeeType,
                        Gender = Employee.Gender,
                        HiringDate = Employee.HiringDate,
                        IsActive = Employee.IsActive,
                        PhoneNumber = Employee.PhoneNumber,
                        Salary = Employee.Salary
                    };
                    var result = _employeeService.AddEmployee(dto);
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

            var mappedEmp = new EmployeeViewModel()
            {
                Email = employee.Email,
                Name = employee.Name,
                Address = employee.Address,
                Age = employee.Age,
                DepartmentId = employee.DepartmentId,
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType),
                Gender = Enum.Parse<Gender>(employee.Gender),
                IsActive = employee.IsActive,
                PhoneNumber = employee.PhoneNumber,
                Salary = employee.Salary,
                HiringDate = employee.HiringDate,


            };

            return View(mappedEmp);

        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id, EmployeeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var dto = new UpdateEmployeeDto()
            {
                Id = id,
                Name = model.Name,
                DepartmentId = model.DepartmentId,
                Address = model.Address,
                Age = model.Age,
                Email = model.Email,
                EmployeeType = model.EmployeeType,
                Gender = model.Gender,
                HiringDate = model.HiringDate,
                IsActive = model.IsActive,
                PhoneNumber = model.PhoneNumber,
                Salary = model.Salary
            };

             var result = _employeeService.UpdateEmployee(dto);
             if (result > 0) return RedirectToAction(nameof(Index));
             return View(model);
            
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
