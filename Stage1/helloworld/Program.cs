using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment
            Console.WriteLine("Hello Ryan from Pathways!");
            // This is a second line of code
            Console.WriteLine("Greetings Pathways!");
            string name = "John";
            Console.WriteLine(name);

            //   const int myNum = 15;
            //   Console.WriteLine(myNum); 

            // make temp change here
            // change here again



            //   int x, y, z;
            //   x = y = z = 50;
            //   Console.WriteLine(x, y, z); 

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String


            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double



        }
    }
}


// create a Car class with a constructor method.
class Car
{
    public string model;
    // Create a class constructor that accepts a parameter 'modelName'
    public Car(string modelName)
    {
        model = modelName;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Create an object of the Car Class, and pass in a parameter
        Car Ford = new Car("Mustang");
        Console.WriteLine(Ford.model);  // Print the value of model, which is “Mustang”
    }
}
