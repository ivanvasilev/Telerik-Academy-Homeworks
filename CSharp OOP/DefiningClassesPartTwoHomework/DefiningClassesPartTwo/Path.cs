using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    public class Path
    {
        // Field
        private List<Point3D> points;
        // Constructor
        public Path()
        {
            points = new List<Point3D>();
        }
        // Property
        public List<Point3D> PointsPath
        {
            get 
            {
                return this.points;
            }
        }
        // Method
        public void AddPoint(double x, double y, double z)
        {
            this.points.Add(new Point3D(x, y, z));
        }
    }
}
