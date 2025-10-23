using AutoMapper;
using Demo.BLL.DTOs.EmployeeDtos;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                 .ForMember(d => d.Department, op => op.MapFrom(s => s.Department != null ? s.Department.Name: null)).ReverseMap(); 

            CreateMap<AddEmployeeDto, Employee>();
            CreateMap<UpdateEmployeeDto, Employee>().ReverseMap();
            CreateMap<Employee, EmployeeDetailsDto>();
        }
    }
}
