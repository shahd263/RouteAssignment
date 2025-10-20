using Demo.BLL.DTOs;

namespace Demo.BLL.Services
{
    public interface IDepartmentService
    {
        int AddDepartment(DepartmentDto departmentDto);
        int DeleteDepartment(int Id);
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetailsDto? GetDepartmentById(int Id);
        int UpdateDepartment(UpdateDepartmentDto department);
    }
}