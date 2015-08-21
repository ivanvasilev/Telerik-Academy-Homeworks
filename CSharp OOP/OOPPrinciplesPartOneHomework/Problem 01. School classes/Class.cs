using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Class : IComment
    {
        // Fields
        private List<Teacher> teachers;
        private string textIdentifier;
        private string comment;
        //Constructors
        public Class( string classIdentifier)
        {
            this.ClassIdentifier = classIdentifier;
            this.teachers = new List<Teacher>();
        }
        // Properties
        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
            private set
            {
                this.teachers = value;
            }
        }

        public string ClassIdentifier
        {
            get
            {
                if (this.textIdentifier.Length != 2 && this.textIdentifier.Length != 3)
                {
                    throw new ArgumentException("Class identifiers must be in format: Number of class + letter!\nExample: \"11B\"");
                }
                return this.textIdentifier;
            }
            private set
            {
                if (value.Length != 2 && value.Length != 3)
                {
                    throw new ArgumentException("Class identifiers must be in format: Number of class + letter!\nExample: \"11B\"");
                }
                this.textIdentifier = value;
            }
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "Comment field is empty!";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        // Methods
        public List<Teacher> GetTeachers()
        {
            return new List<Teacher>(this.teachers);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        // ToString() override
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Class: " + ClassIdentifier);
            foreach (var teacher in teachers)
            {
                result.AppendLine(teacher.ToString());
            }
            return result.ToString();
        }
    }
}
