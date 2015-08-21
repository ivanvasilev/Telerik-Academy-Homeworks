using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version("2.14")]

    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            // testing the version attribute
            Type type = typeof(VersionAttributeTest);
            var attribute = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine("Type of the attribute: " + item.GetType().Name);
                Console.WriteLine("Result: " + "Version[{0}.{1}]", item.Major, item.Minor);
            }
        }
    }
}
