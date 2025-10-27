using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.DTOs.DepartmentDtos
{
    public class UpdateDepartmentDto : CreateDepartmentDto
    {
        public int Id { get; set; }
    }
}
