using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound, IBreed
    {
        // Field
        private int age;
        private string breed;
        // Constructor
        public Cat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        
        }
        // Property
        public override int Age
        {
            get 
            {
                if (this.age < 0 || this.age > 30)
                {
                    throw new ArgumentOutOfRangeException("Age of the cat must be in the range [1, 30]!");
                }
                return this.age;
            }
            set
            {
                if (value < 0 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Age of the cat must be in the range [1, 30]!");
                }
                this.age = value;
            }
        }

        public string Breed
        {
            get
            {
                if (string.IsNullOrEmpty(this.breed))
                {
                    throw new ArgumentNullException("Breed of the cat is empty!");
                }
                return this.breed;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Breed of the cat is empty!");
                }
                this.breed = value;
            }
        }
        // Methods
        public override string MakeSound()
        {
            return "Myauuu";
        }

        public string Eat()
        {
            return string.Format("{0} ate a fish!", this.Name);
        }
    }
}
