using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        static void Main()
        {
            // Making a generic list and adding values to its elements
            GenericList<string> newList = new GenericList<string>(5);
            newList.Add("one");
            newList.Add("two");
            newList.Add("three");
            newList.Add("four");
            newList.Add("five");
            // Printing all alament from the generic list
            Console.WriteLine("The values of the elements in the generic list are:");
            for (int i = 0; i < newList.Length; i++)
            {
                Console.WriteLine("Element[{0}]: {1}",i , newList[i]);
            }
            // Testing the indexer. Changing the value of the first element
            Console.WriteLine("The value of element[0] is: " + newList[0]);
            newList[0] = "zero";
            Console.WriteLine("The value of element[0] after the change is: " + newList[0]);
            // Removing an element
            newList.Remove(3);
            Console.WriteLine("The value of element[3] is: " + newList[3]);
            // Testing the length property
            Console.WriteLine("The length of the list is: " + newList.Length);
            // Testing the insert method
            Console.WriteLine("The value of element[2] is: " + newList[2]);
            newList.Insert(2, "zero");
            Console.WriteLine("The value of element[2] after the insert is: " + newList[2]);
            // Testing the find method
            int result = newList.Find("two");
            Console.WriteLine("\"two\" is at index: {0}", result);
            int secondResult = newList.Find("three");
            Console.WriteLine("\"three\" is at index: {0}", secondResult);
            // Testing the ToString() override
            Console.WriteLine("The values of the elements in the generic list after all changes are:");
            Console.WriteLine(newList.ToString());
            // Testing the clear method
            newList.Clear();
            Console.WriteLine("The values of the elements in the generic list after clearing it are:");
            for (int i = 0; i < newList.Length; i++)
            {
                Console.WriteLine("Element[{0}]: {1}", i, newList[i]);
            }
            // Testing the auto-grow method
            newList.Add("six");
            Console.WriteLine("The length of the generic list after the auto-grow is: " + newList.Length);
            // Adding values and testing the min and max methods
            newList.Insert(0, "one");
            newList.Insert(1, "two");
            newList.Insert(2, "three");
            newList.Insert(3, "four");
            newList.Insert(4, "five");
            newList.Insert(5, "six");
            newList.Insert(6, "seven");
            newList.Insert(7, "eight");
            newList.Insert(8, "nine");
            newList.Insert(9, "ten");
            string maxResult = newList.Max();
            Console.WriteLine("The longest element in the generic list is: " + maxResult);
            string minResult = newList.Min();
            Console.WriteLine("The shortest element in the generic list is: " + minResult);
        }
    }
}
