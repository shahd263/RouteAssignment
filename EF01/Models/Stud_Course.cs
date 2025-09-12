using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Stud_Course //By Fluent API
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public double Grade { get; set; }

    }
}
