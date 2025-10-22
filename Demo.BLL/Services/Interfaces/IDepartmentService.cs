using Demo.BLL.DTOs.DepartmentDtos;

namespace Demo.BLL.Services.Interfaces
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