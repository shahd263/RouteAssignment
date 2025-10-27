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
        public IEnumerable<EmployeeDto> GetAllEmployees();
        public EmployeeDto? GetEmployeeById(int id);
        public bool AddEmployee(CreateEmployeeDto employeeDto);
        public bool UpdateEmployee(int id, UpdateEmployeeDto employeeDto);
        public bool DeleteEmployee(int id);
    }
}
