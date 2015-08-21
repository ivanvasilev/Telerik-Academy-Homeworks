using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(decimal side, decimal height)
            : base(side, height)
        { 

        }

        public override decimal CalculateSurface()
        {
            decimal result = (this.Width * this.Height) / 2m;
            return result;
        }
    }
}
