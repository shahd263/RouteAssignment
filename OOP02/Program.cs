using FirstProject;
using System.Drawing;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstProject

            #region Q3
            ////Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Console.WriteLine("Enter the First Point (x,y,z)");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double z1 = double.Parse(Console.ReadLine());

            //Point3D p1 = new Point3D(x1, y1, z1);

            //Console.WriteLine("Enter the Second Point (x,y,z)");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //double z2 = double.Parse(Console.ReadLine());

            //Point3D p2 = new Point3D(x2, y2, z2);
            #endregion

            #region Q4
            //if (p1 == p2) // it doesn't work 
            //    Console.WriteLine(" They are Equal");
            //else
            //    Console.WriteLine("Not Equal");


            #endregion

            #region Q5

            // //Define an array of points and sort this array based on X & Y coordinates.

            // Point3D[] points =
            // {
            //     new Point3D(3, 2,1),
            //     new Point3D(1, 5,6),
            //     new Point3D(2, 1,3),
            //     new Point3D(3, 1,2),
            //     new Point3D(1, 2,3)
            // };

            // var sorted = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();

            //foreach(var p in sorted)
            // {
            //     Console.WriteLine(p);
            // }


            #endregion

            #region Q6
            //???
            #endregion

            #endregion

            #region SecondProject
            //Console.WriteLine($"Sum :{Maths.Sum(6, 2)} ");
            //Console.WriteLine($"Subtract :{Maths.Subtract(6, 2)} ");
            //Console.WriteLine($"Multiply :{Maths.Multiply(6, 2)} ");
            //Console.WriteLine($"Division :{Maths.Division(6, 2)}");

            #endregion

            #region ThirdProject

            #region Q3
            //Define All Required Constructors to Produce this output:

            //Duration D1 = new Duration(1,10,15);
            //Console.WriteLine(D1.ToString());
            //D1 = new Duration(666);
            //Console.WriteLine(D1.ToString());



            #endregion

            #region Q4
            //Implement All required Operators overloading to enable this Code:

            Duration D1 = new Duration(1,50,35);
            Duration D2 = new Duration(5, 20, 25);

            Duration D3 = D1 + D2;
            Console.WriteLine(D3.ToString());

            D3 = D1 + 7800;
            Console.WriteLine(D3.ToString());

            //D2 = new Duration(666);
            //Console.WriteLine(D2.ToString());
            D3 = 666 + D3;
            Console.WriteLine(D3.ToString());

            D3 = ++D1;
            Console.WriteLine(D3.ToString());

            D3 = --D1;
            Console.WriteLine(D3.ToString());

            if (D1 > D2)
                Console.WriteLine("D1 is Greater");
            else 
                Console.WriteLine("D1 is Smaller");


            if (D1)
                Console.WriteLine("Not Empty");

            DateTime obj = (DateTime)D1;
            Console.WriteLine(obj.ToString());

            #endregion

            #endregion


        }
    }
}
