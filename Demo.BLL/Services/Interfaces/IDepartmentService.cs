using Demo.BLL.DTOs.DepartmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        public IEnumerable<DepartmentDto> GetAllDepartments();
        public DepartmentDto? GetDepartmentById(int id);
        public bool AddDepartment(CreateDepartmentDto departmentDto);
        public bool UpdateDepartment(int id, UpdateDepartmentDto departmentDto);
        public bool DeleteDepartment(int id);

    }
}
