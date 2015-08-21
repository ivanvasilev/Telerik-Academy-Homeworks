using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        // Field
        private int grade;
        // Constructor
        public Student(string firstName, string lastName, int grade) 
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        // Property
        public int Grade 
        { 
            get
            {
                if (this.grade < 1 || this.grade > 12)
                {
                    throw new ArgumentOutOfRangeException("Grades must be in the range[1, 12]!");
                }
                return this.grade;
            }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Grades must be in the range[1, 12]!");
                }
                this.grade = value;
            }
        }
    }
}
