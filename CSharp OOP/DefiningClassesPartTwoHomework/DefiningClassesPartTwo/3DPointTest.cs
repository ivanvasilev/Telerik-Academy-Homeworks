using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class Point3DTest
    {
        static void Main()
        {
            // Printing the starting point
            Console.WriteLine("The start point is with coordinates: {0}", Point3D.StartPoint);
            // Adding and printing points
            Point3D firstPoint = new Point3D(3, 4.4, 5);
            Console.WriteLine("Coordinates of the first point: " + firstPoint.ToString());
            Point3D secondPoint = new Point3D(1, 2, 3);
            Console.WriteLine("Coordinates of the second point: " + secondPoint.ToString());
            // Printing the distance between the two points
            double distance = CalculateDistance.DistanceBetweenPoints(firstPoint, secondPoint);
            Console.WriteLine("The distance between the two points is: {0:F2}", distance);
            // Making a path and adding points in it
            Path firstPath = new Path();
            firstPath.AddPoint(3, 4, 5);
            firstPath.AddPoint(6, 7, 8);
            // Saving and loading the path. You can see it in the file "FirstPath.exe" in the folder of the project
            PathStorage.SavePath(firstPath, "FirstPath");
            PathStorage.SavePath(PathStorage.LoadPath("FirstPath"), "ResultAfterLoadingTheFirstPath");
        }
    }
}
