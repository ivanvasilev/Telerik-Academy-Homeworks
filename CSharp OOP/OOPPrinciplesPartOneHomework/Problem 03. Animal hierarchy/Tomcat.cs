using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Tomcat : Cat, ISound, IBreed
    {
        // Constructor
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {

        }
        // Methods
        public override string MakeSound()
        {
            return "Hsss";
        }

        public string Hunt()
        {
            return string.Format("{0} hunts a mouse!", this.Name);
        }
    }
}
