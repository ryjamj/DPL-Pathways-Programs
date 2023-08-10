/*
Program Name: OOPPolymorphism
Last Updated: 08/02/2023
Program Description: Pratice Polymorphism in C#

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace OOPPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - test default for Animal class
            Console.WriteLine("\nExample 1 ============================");
            Animal TestAnimal = new Animal(); // create class
            Console.WriteLine(TestAnimal); // test ToString() override
            TestAnimal.animalSound(); // test method, class Animal

            // Example 2 - pass parameters into Dog class
            Console.WriteLine("\nExample 2 ============================");
            Dog Husky = new Dog("Dog", "Jet", "12/10", false); // create class
            Console.WriteLine(Husky); // test ToString() override
            Husky.animalSound(); // test Polymorphism method, class Dog
            Husky.checkGoodDog(); // test method method, class Dog

            // Example 3 - pass parameters into Fish class
            Console.WriteLine("\nExample 3 ============================");
            Fish GoldFish = new Fish("Fish", "Bruce", "5/10", false); // create class
            Console.WriteLine(GoldFish); // test ToString() override
            GoldFish.animalSound(); // test Polymorphism method, class Fish
            GoldFish.checkCanSwim(); // test method method, class Fish

        } // end Main()
    } // end class
}  // end namespace