using Demo.BLL.DTOs.DepartmentDtos;
using Demo.BLL.Services.Interfaces;
using Demo.DAL.Models;
using Demo.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Classes
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {

            var Departments = _departmentRepository.GetAll();
            if (Departments is null) return [];
            return Departments.Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                Code = d.Code,
                CreatedAt = d.CreatedAt.ToString()
            });
        }
        public DepartmentDetailsDto? GetDepartmentById(int Id)
        {
            var Department = _departmentRepository.GetById(Id);
            if (Department is null) return null;
            return new DepartmentDetailsDto(Department); //ConstructorMapping


        }

        public int AddDepartment(AddDepartmentDto departmentDto)
        {
            try
            {
                if (departmentDto is null) return 0;
                var department = new Department()
                {
                    Name = departmentDto.Name,
                    Code = departmentDto.Code,
                    Description = departmentDto.Description,
                    CreatedAt = DateTime.Now
                };
                return _departmentRepository.Add(department);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Adding Deparment Failed {ex}");
                return 0;
            }
        }

        public int UpdateDepartment(UpdateDepartmentDto department)
        {
            if (department is null) return 0;
            var existingDepartment = _departmentRepository.GetById(department.Id);
            if (existingDepartment is null) return 0;
            existingDepartment.Name = department.Name;
            existingDepartment.Code = department.Code;
            existingDepartment.Description = department.Description;
            existingDepartment.CreatedAt = department.DateOfCreation;
            return _departmentRepository.Update(existingDepartment);


        }

        public int DeleteDepartment(int Id)
        {
            var existingDepartment = _departmentRepository.GetById(Id);
            if (existingDepartment is null) return 0;
            return _departmentRepository.Delete(existingDepartment);
        }

    }
}
