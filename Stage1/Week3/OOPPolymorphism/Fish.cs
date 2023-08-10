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
    class Fish : Animal
    {
        // variables
        // =================================================
        // propertry approach
        public bool CanSwim { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public Fish() : base()
        {
            CanSwim = true;
        }

        // This is the 'parameter' constructor when parameters are passed in
        public Fish(string newSpecies, string newName, string newRaiting, bool newCanSwim) : base(newSpecies, newName, newRaiting)
        {
            CanSwim = newCanSwim;
        }

        // methods
        // =================================================
        // this will be a 'override' method to test Polymorphism.
        public override void animalSound()
        {
            Console.WriteLine($"\"The {Species} {Name} says:... nothings, it's a {Species}\".");
        }
        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"Fish Class (Species: {Species}, Name: {Name}, Rating: {Raiting}, CanSwim: {CanSwim})");
        }

        public void checkCanSwim()
        {
            Console.WriteLine($"Can {Name} the {Species} swim?: {CanSwim}");
            if (CanSwim == true)
            {
                Console.WriteLine($"{Name} is a good {Species}.");
            }
            else
            { Console.WriteLine($"{Name} is a NOT a very good {Species}."); }
        }

    }// end class
}// end namespace