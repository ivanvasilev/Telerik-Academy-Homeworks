using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        // Fields
        private int age;
        private string color;
        // Constructor
        public Frog(string name, int age, string gender, string color)
            : base(name, age, gender)
        {
            this.Color = color;
        }

        public string Color
        {
            get
            {
                if (string.IsNullOrEmpty(this.color))
                {
                    throw new ArgumentNullException("Color of the frog must not be empty!");
                }
                return this.color;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Color of the frog must not be empty!");
                }
                this.color = value;
            }
        }

        public override int Age
        {
            get
            {
                if (this.age < 0 || this.age > 10)
                {
                    throw new ArgumentOutOfRangeException("Age of the frog must be in the range [1, 10]!");
                }
                return this.age;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Age of the frog must be in the range [1, 10]!");
                }
                this.age = value;
            }
        }
        // Methods
        public override string MakeSound()
        {
            return "Ribbit";
        }

        public string Hop()
        {
            return string.Format("{0} hopped from one lotus leaf to another!", this.Name);
        }
    }
}
