/*
Program Name: OOPInterface
Last Updated: 08/08/2023
Program Description: Pratice interface in C#

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace OOPInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Aniaml (parent) objects
            List<Animal> animalList = new List<Animal>();

            // Add a couple of Animal (parent) objects to the list to test
            animalList.Add(new Animal("DogA", "NamaA", "0/10"));
            animalList.Add(new Animal("FishB", "NameB", "0/10"));

            // Add a couple of Dog (child) objects to the list to test
            animalList.Add(new Dog("Husky", "Colin", "12/10", true));
            animalList.Add(new Dog("Bulldog", "Elle", "11/10", true));

            // Add a couple of Fish (child) objects to the list to test
            animalList.Add(new Fish("Shark", "Bruce", "5/10", true));
            animalList.Add(new Fish("Goldfish", "Molly", "6/10", true));

            // Print the list
            foreach (Animal index in animalList)
            {
                Console.WriteLine(index); // return the ToString()
                Console.WriteLine("-----");
            }  // end foreach  

        } // end Main()
    } // end class
}  // end namespace