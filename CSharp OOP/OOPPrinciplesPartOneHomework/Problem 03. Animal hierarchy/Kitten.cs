using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound, IBreed
    {
        // Constructor
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {

        }
        // Methods
        public override string MakeSound()
        {
            return "Murrr";
        }

        public string Sleep()
        {
            return string.Format("{0} fell asleep!", this.Name);
        }
    }
}
