using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Stud_Course //By Fluent API
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }

        public double Grade { get; set; }

    }
}
