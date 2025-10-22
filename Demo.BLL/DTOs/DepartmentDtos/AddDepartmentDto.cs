using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs.DepartmentDtos
{
    public class AddDepartmentDto
    {

        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [MaxLength(10)]
        public string Code { get; set; } = null!;
        public string? Description { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime DateofCreation { get; set; }

    }
}
