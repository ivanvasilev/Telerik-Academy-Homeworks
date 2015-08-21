using System;

class AgeAfterTenYears
{
    static void Main()
    {
        string inputBirthday;
        DateTime birthday;
        Console.WriteLine("Enter Your Birthday in this Format(YYYY-MM-DD): ");
        inputBirthday = Console.ReadLine();
        birthday = Convert.ToDateTime(inputBirthday);
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;
        if (birthday > today.AddYears(-age)) age--;
        Console.WriteLine("Now, you are {0} years old.", age);
        age = age + 10;
        Console.WriteLine("After 10 years you will be {0} years old", age);
    }
}
