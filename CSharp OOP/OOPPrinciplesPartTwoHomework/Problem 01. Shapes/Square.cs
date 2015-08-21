using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(decimal side)
            : base (side, side)
        {
           
        }

        public override decimal CalculateSurface()
        {
            decimal result = this.Height * this.Width;
            return result;
        }
    }
}
