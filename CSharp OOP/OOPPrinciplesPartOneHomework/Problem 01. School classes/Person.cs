using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public abstract class Person : IComment
    {
        // Fields
        private string firstName;
        private string lastName;
        private string comment;
        // Constructor
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        // Properties
        public string FirstName 
        { 
            get
            {
                if (string.IsNullOrEmpty(this.firstName))
                {
                    throw new ArgumentNullException("First name must not be empty!");
                }
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name must not be empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(this.lastName))
                {
                    throw new ArgumentNullException("First name must not be empty!");
                }
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name must not be empty!");
                }
                this.lastName = value;
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
    }
}
