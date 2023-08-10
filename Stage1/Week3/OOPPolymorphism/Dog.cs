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
    class Dog : Animal
    {
        // variables
        // =================================================
        // propertry approach
        public bool IsGoodDog { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public Dog() : base()
        {
            IsGoodDog = true;
        }

        // This is the 'parameter' constructor when parameters are passed in
        public Dog(string newSpecies, string newName, string newRaiting, bool newIsGoodDog) : base(newSpecies, newName, newRaiting)
        {
            IsGoodDog = newIsGoodDog;
        }

        // methods
        // =================================================
        // this will be a 'override' method to test Polymorphism.
        public override void animalSound()
        {
            Console.WriteLine($"\"The {Species} {Name} says: BARK BARK!\".");
        }
        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            //return ($"Dog Class (Species: {Species}, Name: {Name}, Rating: {Raiting}, IsGoodDog: {IsGoodDog})");
            return (base.ToString() + "IsGoodDog: " + IsGoodDog);
        }

        public void checkGoodDog()
        {
            Console.WriteLine($"Is {Name} a good {Species}?: {IsGoodDog}");
        }

    }// end class
}// end namespace