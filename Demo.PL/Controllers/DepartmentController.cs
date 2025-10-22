using Demo.BLL.DTOs;
using Demo.BLL.DTOs.DepartmentDtos;
using Demo.BLL.Services.Interfaces;
using Demo.PL.Models.DepartmentViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics.Contracts;

namespace Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _environment;

        public DepartmentController(IDepartmentService departmentService 
                    , ILogger<HomeController>logger ,IWebHostEnvironment environment)
        {
            _departmentService = departmentService;
            _logger = logger;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddDepartmentDto Department)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = _departmentService.AddDepartment(Department);
                    if (result > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department Can't Be Added");
                        return View(Department);
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);
                        return View(Department);
                    }
                    else
                    {
                        //_logger.LogError(ex.Message);
                        return View(Department);
                    }

                }

            }
            else return View(Department);
            
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            if(!id.HasValue) return BadRequest();   
            var department = _departmentService.GetDepartmentById(id.Value);
            if (department is null) return NotFound();
            return View(department);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var department = _departmentService.GetDepartmentById(id.Value);
            if (department is null) return NotFound();

            var DeptViewModel = new DepartmentEditViewModel()
            {
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = DateTime.Parse(department.CreatedAt)
                
            };
            return View(DeptViewModel);

        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id, DepartmentEditViewModel deptViewModel)
        {
            if (!ModelState.IsValid) return View(deptViewModel);
            try
            {
                var UpdateDeptDto = new UpdateDepartmentDto()
                {
                    Id = id,
                    Name = deptViewModel.Name,
                    Description = deptViewModel.Description,
                    Code = deptViewModel.Code,
                    DateOfCreation = deptViewModel.DateOfCreation
                };

                var result = _departmentService.UpdateDepartment(UpdateDeptDto);
                if (result > 0) return RedirectToAction(nameof(Index));
                return View(deptViewModel);
            }
            catch(Exception ex)
            {
                return View(deptViewModel);
            }
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _departmentService.DeleteDepartment(id);
                if (result > 0) return RedirectToAction(nameof(Index));
                return View(id);
            }
            catch(Exception ex)
            {
                return View(id);
            }
        }

    }
}
