namespace HumanCreator
{
    public class Person 
    {
        public Person(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "Beast";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Beauty";
                this.Gender = Gender.Female;
            }
        }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender;
        }
    }
}