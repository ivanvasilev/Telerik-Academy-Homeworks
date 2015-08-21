namespace HumanCreator
{
    using System;

    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var person = new Person(22);
            var anotherPerson = new Person(23);
            Console.WriteLine(person);
            Console.WriteLine(anotherPerson);
        }
    }
}
