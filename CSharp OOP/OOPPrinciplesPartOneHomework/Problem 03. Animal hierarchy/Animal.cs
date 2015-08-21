using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        // Fields
        private string name;
        private int age;
        private string gender;
        // Constructor
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        // Properties
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentNullException("Animal name must not be empty!");
                }
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Animal name must not be empty!");
                }
                this.name = value;
            }
        }

        public virtual int Age { get; set; }

        public string Gender 
        { 
            get
            {
                if (this.gender != "male" && this.gender != "Male" && this.gender != "m" && this.gender != "M" &&
                    this.gender != "female" && this.gender != "Female" && this.gender != "f" && this.gender != "F")
                {
                    throw new ArgumentException("Invalid gender!");
                }
                return this.gender;
            }
            private set
            {
                if (value != "male" && value != "Male" && value != "m" && value != "M" &&
                    value != "female" && value != "Female" && value != "f" && value != "F")
                {
                    throw new ArgumentException("Invalid gender!");
                }
                this.gender = value;
            }
        }
        // Method
        public virtual string MakeSound()
        {
            return "Zzz";
        }
    }
}
