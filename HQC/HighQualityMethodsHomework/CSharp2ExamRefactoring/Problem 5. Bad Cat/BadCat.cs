namespace CSharp2ExamRefactoring
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class BadCat
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<string> cypher = new List<string>();
            for (int i = 0; i < number; i++)
            {
                cypher.Add(Console.ReadLine());
            }
            StringBuilder result = new StringBuilder();

            foreach (var item in cypher)
            {
                result.Append(item[0]);
                result.Append(item[item.Length - 1]);
            }

            StringBuilder allDifferentDigits = new StringBuilder();
            // Adding all the different digits in one StringBuilder
            if (result.ToString().IndexOf('1') != -1)
            {
                allDifferentDigits.Append("1");
            }
            if (result.ToString().IndexOf('2') != -1)
            {
                allDifferentDigits.Append("2");
            }
            if (result.ToString().IndexOf('3') != -1)
            {
                allDifferentDigits.Append("3");
            }
            if (result.ToString().IndexOf('4') != -1)
            {
                allDifferentDigits.Append("4");
            }
            if (result.ToString().IndexOf('5') != -1)
            {
                allDifferentDigits.Append("5");
            }
            if (result.ToString().IndexOf('6') != -1)
            {
                allDifferentDigits.Append("6");
            }
            if (result.ToString().IndexOf('7') != -1)
            {
                allDifferentDigits.Append("7");
            }
            if (result.ToString().IndexOf('8') != -1)
            {
                allDifferentDigits.Append("8");
            }
            if (result.ToString().IndexOf('9') != -1)
            {
                allDifferentDigits.Append("9");
            }
            if (result.ToString().IndexOf('0') != -1)
            {
                allDifferentDigits.Append("0");
            }

            char firstDigit = '0';
            char secondDigit = '0';
            int index = 0;

            string finalResult = allDifferentDigits.ToString();

            // Arranging the digits in the StringBuilder using the given commands
            foreach (var item in cypher)
            {
                if (item.IndexOf("before") != -1)
                {
                    firstDigit = char.Parse(item.Substring(0, 1));
                    secondDigit = char.Parse(item.Substring(item.Length - 1, 1));
                    index = finalResult.IndexOf(secondDigit);
                    finalResult = finalResult.Insert(index, (firstDigit - '0').ToString());
                    finalResult = finalResult.Remove(finalResult.IndexOf(firstDigit), 1);
                }
                if (item.IndexOf("after") != -1)
                {
                    firstDigit = char.Parse(item.Substring(0, 1));
                    secondDigit = char.Parse(item.Substring(item.Length - 1, 1));
                    index = finalResult.IndexOf(secondDigit.ToString());
                    finalResult = finalResult.Insert(index + 1, firstDigit.ToString());
                    finalResult = finalResult.Remove(finalResult.IndexOf(firstDigit), 1);
                }
            }
            Console.WriteLine(finalResult);
        }
    }
}
