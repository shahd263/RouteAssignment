using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //1. Define 3D Point Class and the basic Constructors (use chaining in constructors).

    internal class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D() : this(0, 0, 0)
        {

        }


        #region Q2
        //2. Override the ToString Function to produce this output:

        public override string ToString()
        {
            return $"Point Coordinates ({X},{Y},{Z})";
        }
        #endregion
    }
}
