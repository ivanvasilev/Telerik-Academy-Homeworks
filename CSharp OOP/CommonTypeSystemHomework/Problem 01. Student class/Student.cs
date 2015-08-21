namespace StudentClass
{
    using System;
    using StudentClass.Enumerations;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        // Fields
        private string firstName;

        private string middleName;

        private string lastName;

        private string ssn;

        private string permanentAddress;

        private string mobilePhone;

        private string email;

        private int course;
        // Constructor
        public Student(string firstName, string middleName, string lastName, string ssn,
                       string permanentAddress, string mobilePhone, string email, int course,
                       Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }
        // Properties
        public string FirstName
        {
            get
            {
                if (string.IsNullOrEmpty(this.firstName))
                {
                    throw new ArgumentNullException("First name can not be empty!");
                }
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be empty!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                if (string.IsNullOrEmpty(this.middleName))
                {
                    throw new ArgumentNullException("Middle name can not be empty!");
                }
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can not be empty!");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (string.IsNullOrEmpty(this.lastName))
                {
                    throw new ArgumentNullException("Last name can not be empty!");
                }
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be empty!");
                }
                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                if (this.ssn.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid SSN number!");
                }
                return this.ssn;
            }
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid SSN number!");
                }
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                if (string.IsNullOrEmpty(this.permanentAddress))
                {
                    throw new ArgumentNullException("Permanent address can not be empty!");
                }
                return this.permanentAddress;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Permanent address can not be empty!");
                }
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                if (this.mobilePhone.Length != 10 && this.mobilePhone.Length != 13 &&
                    this.mobilePhone.Length != 12 && this.mobilePhone.Length != 9)
                {
                    throw new ArgumentOutOfRangeException("Invalid phone number!");
                }
                return this.mobilePhone;
            }
            private set
            {
                if (value.Length != 10 && value.Length != 13 && value.Length != 12 && value.Length != 9)
                {
                    throw new ArgumentOutOfRangeException("Invalid phone number!");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(this.email))
                {
                    throw new ArgumentNullException("Permanent address can not be empty!");
                }
                if (!this.email.Contains("@"))
                {
                    throw new ArgumentException("Invalid email address!");
                }
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Permanent address can not be empty!");
                }
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email address!");
                }
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                if (this.course <= 0 || this.course > 6)
                {
                    throw new ArgumentOutOfRangeException("Course must in the range [1; 6]!");
                }
                return this.course;
            }
            set
            {
                if (value <= 0 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Course must in the range [1; 6]!");
                }
                this.course = value;
            }
        }

        public Specialty Specialty { get; private set; }

        public Faculty Faculty { get; private set; }

        public University University { get; private set; }
        // Override methods
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (!this.FirstName.Equals(student.FirstName) || !this.MiddleName.Equals(student.MiddleName) ||
                !this.LastName.Equals(student.LastName) || !this.SSN.Equals(student.SSN) ||
                !this.PermanentAddress.Equals(student.PermanentAddress) || !this.MobilePhone.Equals(student.MobilePhone) ||
                !this.Email.Equals(student.Email) || !this.Course.Equals(student.Course) ||
                !this.Specialty.Equals(student.Specialty) || !this.Faculty.Equals(student.Faculty) ||
                !this.University.Equals(student.University))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Full name         : " + this.FirstName + " " + this.MiddleName + " " + this.LastName);
            result.AppendLine("SSN               : " + this.SSN);
            result.AppendLine("Permanent address : " + this.PermanentAddress);
            result.AppendLine("Mobile phone      : " + this.MobilePhone);
            result.AppendLine("E-mail            : " + this.Email);
            result.AppendLine("Course            : " + this.Course);
            result.AppendLine("Specialty         : " + this.Specialty);
            result.AppendLine("Faculty           : " + this.Faculty);
            result.AppendLine("University        : " + this.University);
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.MiddleName.GetHashCode() ^ this.SSN.GetHashCode() ^ this.Faculty.GetHashCode();
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(first.Equals(second));
        }
        
        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, 
                               this.PermanentAddress, this.MobilePhone, this.Email, 
                               this.Course, this.Specialty, this.Faculty, this.University);
            //Variant 2
            //Making the clone method, using the MemberwiseClone method, because all properties are value types
            //var result = this.MemberwiseClone();
            //return result;
        }
        
        public int CompareTo(object obj)
        {
            var student = obj as Student;
            string firstStudentFullName = this.FirstName + this.MiddleName + this.LastName;
            string secondStudentFullName = student.FirstName + student.MiddleName + student.LastName;

            if (firstStudentFullName == secondStudentFullName)
            {
                return this.SSN.CompareTo(student.SSN);
            }
            return firstStudentFullName.CompareTo(secondStudentFullName);
        }
    }
}
