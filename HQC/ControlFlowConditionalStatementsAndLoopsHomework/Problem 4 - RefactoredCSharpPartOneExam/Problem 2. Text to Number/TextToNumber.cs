namespace CSharpPartOneExam
{
    using System;

    class TextToNumber
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();

            long result = 0;

            foreach (char symbol in inputText)
            {
                if (symbol >= '0' && symbol <= '9')
                {
                    result *= symbol - '0';
                }
                else if (symbol >= 'a' && symbol <= 'z')
                {
                    result += symbol - 'a';
                }
                else if (symbol >= 'A' && symbol <= 'Z')
                {
                    result += symbol - 'A';
                }
                else if (symbol == '@')
                {
                    Console.WriteLine(result);
                    return;
                }
                else
                {
                    result %= inputNumber;
                }
            }

            Console.WriteLine(result);
        }
    }
}
