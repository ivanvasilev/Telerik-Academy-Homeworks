using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal length)
            : base(width, length)
        {

        }

        public override decimal CalculateSurface()
        {
            decimal result = this.Width * this.Height;
            return result;
        }
    }
}
