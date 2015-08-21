using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public struct Point3D
    {
        // Static field 
        private static readonly Point3D DefaultPoint = new Point3D(0, 0, 0);
        // Fields
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
        // Constructor
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        // Property
        public static Point3D StartPoint 
        { 
            get
            {
                return DefaultPoint;
            }
        }
        // String override
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("x = " + this.X + " ");
            result.Append("y = " + this.Y + " ");
            result.Append("z = " + this.Z);
            return result.ToString();
        }
    }
}
