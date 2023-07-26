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

      double myDouble = 9.78;
      int myInt = (int) myDouble;    // Manual casting: double to int

      
    }
  }
}