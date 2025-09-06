
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Course_Inst //By Fluent API
    {
        public int Course_Id { get; set; }
        public int Inst_Id { get; set; }

        public string? Evaluate { get; set; }
    }
}
