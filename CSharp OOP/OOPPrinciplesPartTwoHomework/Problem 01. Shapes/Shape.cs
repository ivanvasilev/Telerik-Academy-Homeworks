using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public Shape(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("");
                }
                this.width = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("");
                }
                this.height = value;
            }
        }

        public abstract decimal CalculateSurface();
    }
}
