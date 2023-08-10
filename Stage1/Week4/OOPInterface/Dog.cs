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
    class Dog : Animal, IAnimalSound, IBellyRubs
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
        // override methods() for Polymorphism.
        public string animalSound()
        {
            return($"\"The {Species} {Name} says: BARK BARK!\".");
        }

        // this will be a inherited method from the interface
        public string wantsBellyRubs()
        {
            return ($"\"Yes, {Name} the {Species} would like belly rubs\".");
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()} |  IsGoodDog: {IsGoodDog} | AnimalSound: {animalSound()} | wantsBellyRubs: {wantsBellyRubs()}");
        }


    }// end class
}// end namespace

