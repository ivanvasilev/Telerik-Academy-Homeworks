using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Discipline : IComment
    {
        // Fields
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;
        // Constructor
        public  Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        // Properties
        public string Name 
        { 
            get
            {
                if (string.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentNullException("Name of discipline must not be empty!");
                }
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name of discipline must not be empty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                if (this.numberOfLectures > 60 || this.numberOfLectures < 1)
                {
                    throw new IndexOutOfRangeException("Number of lectures must be between 1 and 60!");
                }
                return this.numberOfLectures;
            }
            private set
            {
                if (value > 60 || value < 1)
                {
                    throw new IndexOutOfRangeException("Number os lectures must be between 1 and 60!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                if (this.numberOfExercises < 1)
                {
                    throw new IndexOutOfRangeException("Number of exercises must be over 1!");
                }
                return this.numberOfExercises;
            }
            private set
            {
                if (value < 1)
                {
                    throw new IndexOutOfRangeException("Number of exercises must be over 1!");
                }
                this.numberOfExercises = value;
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
        // ToString() override
        public override string ToString()
        {
            return string.Format("Discipline: {0}\nLectures: {1}\nExercises: {2}", Name, NumberOfLectures, NumberOfExercises);
        } 
    }
}
