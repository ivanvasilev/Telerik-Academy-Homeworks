using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School
    {
        // Fields
        private string name;
        private List<Class> classes;
        // Constructor
        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }
        // Properties
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentNullException("The school name must not be empty!");
                }
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The school name must not be empty!");
                }
                this.name = value;
            }
        }

        public List<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }
            private set
            {
                this.classes = value;
            }
        }
        // Methods
        public List<Class> GetClasses()
        {
            return new List<Class>(this.classes);
        }

        public void AddClass(Class group)
        {
            this.classes.Add(group);
        }
        // ToString() override
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("School: " + Name);
            foreach (var group in Classes)
            {
                result.AppendLine(group.ToString());
            }
            return result.ToString();
        }
    }
}
