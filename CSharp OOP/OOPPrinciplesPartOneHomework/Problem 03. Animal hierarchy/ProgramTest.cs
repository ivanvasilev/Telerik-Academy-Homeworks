using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class ProgramTest
    {
        static void Main()
        {
            // Testing all classes and printing the average age of each group of animals
            Console.WriteLine("TESTING ALL CLASSES AND THE AVERAGE AGE METHOD ON THEM:");
            Cat[] cats = new Cat[] { new Cat("Pissy", 3, "Female"), 
                                     new Cat("Missy", 7, "Female"), 
                                     new Cat("Tommy", 11, "Male") };
            Console.WriteLine("The average age of the cats is: {0:F2} years.", AverageAge(cats));
            Dog[] dogs = new Dog[] { new Dog("Timmy", 8, "Male"),
                                     new Dog("Gabby", 4, "Female"),
                                     new Dog("Jake", 13, "Male") };
            Console.WriteLine("The average age of the dogs is: {0:F2} years.", AverageAge(dogs));
            Frog[] frogs = new Frog[] { new Frog("Josh", 1, "Male", "Blue"),
                                        new Frog("Patricia", 7, "Female", "Green"),
                                        new Frog("Helen", 6, "Female", "Black") };
            Console.WriteLine("The average age of the frogs is: {0:F2} years.", AverageAge(frogs));
            Tomcat[] tomcats = new Tomcat[] { new Tomcat("Billy", 5),
                                              new Tomcat("Oliver", 3),
                                              new Tomcat("Sully", 2),
                                              new Tomcat("Lefty", 1) };
            Console.WriteLine("The average age of the tomcats is: {0:F2} years.", AverageAge(tomcats));
            Kitten[] kittens = new Kitten[] { new Kitten("Mandy", 3),
                                              new Kitten("Suzy", 6),
                                              new Kitten("Mary", 2),
                                              new Kitten("Dolly", 5) };
            Console.WriteLine("The average age of the kittens is: {0:F2} years.", AverageAge(kittens));
            Console.WriteLine();
            // Testing the Breed property and the Gender property
            Console.WriteLine("TESTING THE BREED PROPERTY AND THE GENDER PROPERTY:");
            dogs[2].Breed = "Golden retriever";
            Console.WriteLine("{0} is a dog. It's breed is {1} and it's gender is {2}.", dogs[2].Name, dogs[2].Breed, dogs[2].Gender);
            cats[1].Breed = "Persian";
            Console.WriteLine("{0} is a cat. It's breed is {1} and it's gender is {2}.", cats[1].Name, cats[1].Breed, cats[1].Gender);
            tomcats[1].Breed = "Siberian";
            Console.WriteLine("{0} is a tomcat. It's breed is {1} and it's gender is {2}.", tomcats[1].Name, tomcats[1].Breed, tomcats[1].Gender);
            kittens[0].Breed = "Siamese";
            Console.WriteLine("{0} is a kitten. It's breed is {1} and it's gender is {2}.", kittens[0].Name, kittens[0].Breed, kittens[0].Gender);
            Console.WriteLine();
            // Testing the optional methods, that I added
            Console.WriteLine("TESTING THE OPTIONAL METHODS:");
            Console.WriteLine(cats[0].Eat());
            Console.WriteLine(dogs[0].Fetch());
            Console.WriteLine(frogs[0].Hop());
            Console.WriteLine(tomcats[0].Hunt());
            Console.WriteLine(kittens[0].Sleep());
            Console.WriteLine();
            // Testing class Animal and calculating the average age of the different animals in the array
            Animal[] animals = new Animal[5];
            animals[0] = cats[0];
            animals[1] = dogs[1];
            animals[2] = frogs[2];
            animals[3] = tomcats[3];
            animals[4] = kittens[3];
            Console.WriteLine("TESTING THE AVERAGE AGE METHOD ON AN ARRAY OF DIFFERENT ANIMALS:");
            Console.WriteLine("The average age of the animals is: {0:F2} years.", AverageAge(animals));
            Console.WriteLine();
            // Testing the MakeSound method for every animal
            Console.WriteLine("TESTING THE MAKESOUND METHOD ON EVERY CLASS:");
            foreach (var animal in animals)
            {
                Console.WriteLine("The {0} makes that sound \"{1}\"", animal.ToString().Substring(16).ToLower(), animal.MakeSound());
            }
            Console.WriteLine();
        }

        static double AverageAge(Animal[] animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}
