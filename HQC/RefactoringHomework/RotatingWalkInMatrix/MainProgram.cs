namespace RotatingWalkInMatrix
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Console.Write("Enter a positive number between 1 and 100: ");

            string input = Console.ReadLine();
            int number = 0;
            while (!int.TryParse(input, out number) || number <= 0 || number > 100)
            {
                Console.Write("Invalid number! Try again: ");
                input = Console.ReadLine();
            }

            Matrix matrix = new Matrix(number);
            Console.WriteLine(matrix);
        }
    }
}
