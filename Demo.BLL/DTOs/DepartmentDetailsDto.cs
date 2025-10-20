using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs
{
    public class DepartmentDetailsDto
    {

        public DepartmentDetailsDto(Department department)
        {
            Id = department.Id;
            Name = department.Name;
            Description = department.Description;
            Code = department.Code;
            CreatedAt = department.CreatedAt.ToString();
            CreatedBy = department.CreatedBy;
            LastModifiedBy = department.LastModifiedBy;
            IsDeleted = department.IsDeleted;
        }
        public int Id { get; set; }
        public string  Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public string CreatedAt { get; set; } = null!;
        public int CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
