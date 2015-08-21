namespace Student
{
    using System;

    public class Group
    {
        // Fields
        private int groupNumber;
        private string departmentName;
        // Constructor
        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
        // Properties
        public int GroupNumber 
        { 
            get
            {
                if (this.groupNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Group number must be a non-negative number!");
                }
                return this.groupNumber;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Group number must be a non-negative number!");
                }
                this.groupNumber = value;
            }
        }

        public string DepartmentName 
        { 
            get
            {
                if (string.IsNullOrEmpty(this.departmentName))
                {
                    throw new ArgumentException("Department name must not be empty!");
                }
                return this.departmentName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Department name must not be empty!");
                }
                this.departmentName = value;
            }
        }      
    }
}
