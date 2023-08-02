/*
Program Name: oop1
Last Updated: 07/31/2023
Program Description:
    experiment using OOP.
    calling the created 'Car' class to create new objects
    passing in parameters per object, & calling specific methods of that 'Car' class.
*/

using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a object 'myCar1', pass in paramters for the Car class variables, and return values assinged to variables by the constructors themselves
            Console.WriteLine("ex 1 -----------------");
            Car myCar1 = new Car("red", "Mustang");
            Console.WriteLine(myCar1.color);
            Console.WriteLine(myCar1.model);

            // create an object 'myCar2', use the default values for the declared variables within the Car class, return using the Car class getColor() & getModel() methods
            Console.WriteLine("ex 2 -----------------");
            Car myCar2 = new Car();
            Console.WriteLine(myCar2.getColor());
            Console.WriteLine(myCar2.getModel());

            // create an object 'myCar3', pass in paramters for the declared Car class variables, return using the Car class getColor() & getModel() methods
            Console.WriteLine("ex 3 -----------------");
            Car myCar3 = new Car("green", "CRV");
            Console.WriteLine(myCar3.getColor());
            Console.WriteLine(myCar3.getModel());

            // using 'myCar2' again but update it's values
            // this time pass in parameters using the Car class setcolor() & setModel() methods, then return the values using the Car class getColor() & getModel() methods
            Console.WriteLine("ex 4 -----------------");
            myCar2.setColor("blue");
            myCar2.setModel("Ford");
            Console.WriteLine(myCar2.getColor());
            Console.WriteLine(myCar2.getModel());

        } // end Main()
    } // end class Program
} // end namespace

