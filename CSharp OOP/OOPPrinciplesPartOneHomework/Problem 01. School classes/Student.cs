using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Student : Person, IComment
    {
        // Field
        private int classNumber;
        // Constructor
        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }
        // Property
        public int ClassNumber 
        { 
            get
            {
                if (this.classNumber > 35 || this.classNumber < 1)
                {
                    throw new IndexOutOfRangeException("Class number must be between 1 and 35!");
                }
                return this.classNumber;
            }
            private set
            {
                if (value > 35 || value < 1)
                {
                    throw new IndexOutOfRangeException("Class number must be between 1 and 35!");
                }
                this.classNumber = value;
            }
        }
        // ToString() override
        public override string ToString()
        {
            return string.Format("Student: {0}\nNumber in class: {1}", FirstName + " " + LastName, ClassNumber);
        }
    }
}
