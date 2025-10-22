using AutoMapper;
using Demo.BLL.DTOs.EmployeeDtos;
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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmplyeeRepository _emplyeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmplyeeRepository emplyeeRepository , IMapper mapper)
        {
           _emplyeeRepository = emplyeeRepository;
            _mapper = mapper;
        }


        public int AddEmployee(AddEmployeeDto employeeDto)
        {
            if (employeeDto is null) return 0;
            var MappedEmployee = _mapper.Map<Employee>(employeeDto);
            return _emplyeeRepository.Add(MappedEmployee);


        }

        public int DeleteEmployee(int Id)
        {
            var Employee = _emplyeeRepository.GetById(Id);
            if(Employee is null) return 0;

            Employee.IsDeleted = true;
            return _emplyeeRepository.Update(Employee);
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var Employees = _emplyeeRepository.GetAll();
            if (Employees is null) return [];
            return _mapper.Map<IEnumerable<Employee>,IEnumerable<EmployeeDto>>(Employees);
            
        }

        public EmployeeDetailsDto? GetEmployeeById(int Id)
        {
            var employee = _emplyeeRepository.GetById(Id);
            if (employee is null) return null;
            return _mapper.Map<EmployeeDetailsDto>(employee);
            
        }

        public int UpdateEmployee(UpdateEmployeeDto employee)
        {

            if(employee is null) return 0;
            var EmployeeExist = _emplyeeRepository.GetById(employee.Id);
            if(EmployeeExist is null) return 0;
            var MappedEmployee = _mapper.Map(employee,EmployeeExist);
            return _emplyeeRepository.Update(MappedEmployee);
        }
    }
}
