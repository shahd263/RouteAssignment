using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Question01
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length*Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length = {Length} , Width = {Width} , Area of Rectangle = {Area:F2}");
        }
    }
}
