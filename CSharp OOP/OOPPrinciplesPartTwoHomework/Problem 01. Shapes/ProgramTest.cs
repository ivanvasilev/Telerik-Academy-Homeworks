// Problem 1. Shapes
  // Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
  // Define two new classes Triangle and Rectangle that implement the virtual method and return 
  // the surface of the figure (height * width for rectangle and height * width/2 for triangle).
  // Define class Square and suitable constructor so that at initialization height must be kept equal 
  // to width and implement the CalculateSurface() method.
  // Write a program that tests the behaviour of the CalculateSurface() method for different shapes 
  // Square, Rectangle, Triangle) stored in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ProgramTest
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] { new Triangle(4.5m, 2.1m),
                                           new Rectangle(6.5m, 2.4m),
                                           new Square(7) };
            foreach (var shape in shapes)
            {
                string nameOfShape = shape.GetType().Name;
                Console.WriteLine("The surface of a {0} with sides {1} and {2} is: {3:F2}", nameOfShape, shape.Height, shape.Width, shape.CalculateSurface());
            }
        }
    }
}
