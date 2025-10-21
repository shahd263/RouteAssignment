using Demo.BLL.DTOs;

namespace Demo.BLL.Services
{
    public interface IDepartmentService
    {
        int AddDepartment(AddDepartmentDto departmentDto);
        int DeleteDepartment(int Id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetailsDto? GetDepartmentById(int Id);
        int UpdateDepartment(UpdateDepartmentDto department);
    }
}