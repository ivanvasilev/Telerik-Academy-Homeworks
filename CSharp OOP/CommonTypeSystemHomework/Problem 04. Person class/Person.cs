namespace PersonClass
{
    using System;
    using System.Text;

    public class Person
    {
        // Fields
        private string name;

        private int? age;
        // Constructors
        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }
        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty!");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("Invalid age!");
                }
                this.age = value;
            }
        }
        // ToString() override
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Name : " + this.Name);
            if (this.Age == null)
            {
                result.Append("Age  : Undefined");
            }
            else
            {
                result.Append("Age  : " + this.Age);
            }
            return result.ToString();
        }
    }
}
