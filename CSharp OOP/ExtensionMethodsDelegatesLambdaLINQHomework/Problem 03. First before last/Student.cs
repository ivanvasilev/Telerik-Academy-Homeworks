namespace StudentExtensions
{
    using System;

    public class Student
    {
        // Fileds
        private string firstName;
        private string lastName;
        private int age;
        // Constructor
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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
            set
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
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Fisrt name must be at least 1 character long!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                if (this.age < 7 || this.age > 100)
                {
                    throw new ArgumentException("Age mhust be between 7 and 100 years!");
                }
                return this.age;
            }
            set
            {
                if (value < 7 || value > 100)
                {
                    throw new ArgumentException("Age mhust be between 7 and 100 years!");
                }
                this.age = value;
            }
        }
    }
}
