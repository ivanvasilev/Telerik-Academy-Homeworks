using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Display
    {
        private double? size;
        private int? colors;
        
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value > 6 || value < 1)
                {
                    throw new IndexOutOfRangeException("Invalid display size. Size must be between 1 and 6 inches!");
                }
                this.size = value;
            }
        }

        public int? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value > 16 || value < 1)
                {
                    throw new IndexOutOfRangeException("Invalid display colors. Size must be between 1 and 16!");
                }
                this.colors = value;
            }
        }

        public Display()
        {
            this.Size = null;
            this.Colors = null;
        }

        public Display(double size, int colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
