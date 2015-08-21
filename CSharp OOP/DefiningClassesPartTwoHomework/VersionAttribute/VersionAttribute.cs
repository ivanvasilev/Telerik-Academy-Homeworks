using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
AttributeTargets.Method | AttributeTargets.Enum, AllowMultiple = true)] 

    public class VersionAttribute : Attribute
    {
        // Constructor
        public VersionAttribute(string input)
        {
            string[] result = input.Split('.');
            this.Major = int.Parse(result[0]);
            this.Minor = int.Parse(result[1]);
        }
        // Properties
        public int Major { get; set; }
        public int Minor { get; set; }
    }
}
