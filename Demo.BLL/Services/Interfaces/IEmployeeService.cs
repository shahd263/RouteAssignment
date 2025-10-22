using Demo.BLL.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        int AddEmployee(AddEmployeeDto employeeDto);
        int DeleteEmployee(int Id);
        IEnumerable<EmployeeDto> GetAllEmployees();
        EmployeeDetailsDto? GetEmployeeById(int Id);
        int UpdateEmployee(UpdateEmployeeDto employee);
    }
}
