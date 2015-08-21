using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Dog : Animal, ISound, IBreed
    {
        // Fields
        private int age;
        private string breed;
        // Constructor
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public string Breed
        {
            get
            {
                if (string.IsNullOrEmpty(this.breed))
                {
                    throw new ArgumentNullException("Breed of the dog is empty!");
                }
                return this.breed;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Breed of the dog is empty!");
                }
                this.breed = value;

            }
        }

        public override int Age
        {
            get
            {
                if (this.age < 0 || this.age > 20)
                {
                    throw new ArgumentOutOfRangeException("Age of the dog must be in the range [1, 20]!");
                }
                return this.age;
            }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Age of the dog must be in the range [1, 20]!");
                }
                this.age = value;
            }
        }
        // Methods
        public override string MakeSound()
        {
            return "Wuff";
        }

        public string Fetch()
        {
            return string.Format("{0} just brought a stick!", this.Name);
        }
    }
}
