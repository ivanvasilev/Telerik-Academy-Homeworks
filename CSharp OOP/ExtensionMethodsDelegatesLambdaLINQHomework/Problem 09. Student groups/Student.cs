namespace Student
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        // Fields
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;
        // Constructor
        public Student(string firstName, string lastName, string fn, string tel, 
                       string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }
        // Properties
        public string FirstName
        {
            get
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new ArgumentNullException("Fisrt name must be at least 1 character long!");
                }
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Fisrt name must be at least 1 character long!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentNullException("Fisrt name must be at least 1 character long!");
                }
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Fisrt name must be at least 1 character long!");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                if (this.fn.Length < 6 || this.fn.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must be from 6 to 10 characters long!");
                }
                return this.fn;
            }
            private set
            {
                if (value.Length < 6 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number must be from 6 to 10 characters long!");
                }
                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                if (string.IsNullOrEmpty(this.tel))
                {
                    throw new ArgumentNullException("Phone number is empty!");
                }
                if (this.tel.Length != 10 && this.tel.Length != 13 && this.tel.Length != 9)
                {
                    throw new ArgumentException("Invalid phone number!");
                }
                return this.tel;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone number is empty!");
                }
                if (value.Length != 10 && value.Length != 13 && value.Length != 9)
                {
                    throw new ArgumentException("Invalid phone number!");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(this.email))
                {
                    throw new ArgumentNullException("Email must not be empty!");
                }
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email must not be empty!");
                }
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                if (this.marks.Count == 0)
                {
                    throw new ArgumentNullException("The list of marks is empty!");
                }
                return this.marks;
            }
            private set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("The list of marks is empty!");
                }
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Students group number can not be null or empty");
                }
                this.groupNumber = value;
            }
        }

        public Group Group { get; private set; }
        // Override ToString() to take the full name of every student
        public override string ToString()
        {
            string fullName = this.FirstName + " " + this.LastName;
            return fullName;
        }
    }
}
