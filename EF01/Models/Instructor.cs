using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int? WorkForId { get; set; }
        public Department? WorkFor { get; set; }

        public List<Course_Inst> courses { get; set; }
    }
}
