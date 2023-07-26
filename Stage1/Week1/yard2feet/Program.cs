/*
Program Description: this program reads the number of yards from the user, converts to feet, and provides the equivalent number of feet back to the user, or provides an error message if the number of yards is < 0.
Programmer: Ryan James
Last Updated: July 18, 2023

Requirements:
(1) the numb of yards will be an int, from user is greater than 0.
(2) the numb of feet will be calculated by numb of yards x3 if numb of yards is greater than 0.
(3) the numb of feet will be an int.

Algorithm:
(1) prompt the user for the numb of yards.
(2) obtain the numb in yards.
(3) return error message if invalid entry
(4) if numb of yards > 0…
  (4a) convert numb from yards to feet.
  (4b) output the numb in feet to user.
(5) Else...
  (5a) provide error message
*/


using System;

namespace Yard2Feet
{
  class Program
  {
    static void Main(string[] args)
    {
      // (1) global variables for Main()
      int numOfYards= 0;

        // (2) loop to check user input is > 0.
        do {
          // (2a) prompt the user for the numb of yards.
          Console.WriteLine("Enter in a number in yards:");

          // (2b) obtain the numb.  Convert from string to int. Save as int.
          numOfYards = Convert.ToInt32(Console.ReadLine());

          // (2c) error message if wjhile condition is invalid.
          if (numOfYards <= 0) {
            Console.WriteLine("Invalid entry. Please enter a value greater than 0.)");
          } // end if

        } while (numOfYards <=0);

        // (3) create new var. convert numb from yards to feet.
        int numOfFeet = numOfYards * 3;

        // (4) output the numb in feet to user.
        Console.WriteLine("Number of feet in '" + numOfYards + "' yards is '" + numOfFeet +"'");

    } // end Main
  } // end Class
} //end Yard2Feet