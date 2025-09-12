using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    internal class Department //By Convension
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ManagerId { get; set; }

        public Instructor Manager { get; set; }

        public DateTime HiringDate { get; set; }

        public List<Instructor> Instructors { get; set; }



    }
}
