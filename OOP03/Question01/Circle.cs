using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Question01
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Circle( double radius)
        {
            Radius = radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius} , Area of Circle= {Area:F2}");

        }
    }
}
