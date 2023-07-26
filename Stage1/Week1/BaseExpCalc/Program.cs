/*
Program Description: 
    This program reads in a base and exponent number from the user,
    checks that both numbers are integers greater than 1, 
    calculates the base number to the exponent power using a custom method, 
    then prompts the user to repeat the entire exercise.
Last Updated: July 20, 2023

Requirements:
(1) base and exponent number must be integers > 1.
(2) create a custom Power() method to calculate. Use Math.Pow() for exponential calculations.
(3) user must be prompted to either repeat the entire exercise or end it.

Algorithm:
(1) create custom Power() method.
(2) create do-while loop to check if the user wants to repeat the entire process
    (2a) do-while to prompt user for number and check if > 1 & int
        (2a1) Prompt user for value and read in response
        (2a2) check if value is an int
        (2a3) check if value is < 1
(3) call Power() method & print result
(4) create do-while to prompt user to repeat
    (4a) Prompt user for value and read in response
    (4b) check response is either "y" or "n"
*/

namespace BaseExpCalc
{
    class Program
    {
        // (1) create custom Power() method.
        // Power() Method
        static double Power(double baseVal, double expVal)
        {
            double outputVal = Math.Pow(baseVal, expVal);
            return outputVal;
        } // end Power() method


        // Main() Method
        static void Main(string[] args)
        {
            // set global variables
            string? baseString;
            string? expString;
            int baseVal;
            int expVal;
            string? repeatVal;

            // (2) create do-while loop to check if the user wants to repeat the entire process.
            do
            {
                // (2a) do-while to prompt user for number and check if > 1 & int
                // base number
                do
                {
                    // (2a1) Prompt user for value and read in response
                    Console.WriteLine("---> PLease enter in base number (int, > 1).");
                    baseString = Console.ReadLine();

                    // (2a2) check if response is an int
                    if (!int.TryParse(baseString, out baseVal))
                    {
                        Console.WriteLine("ERROR: base number must be int.  Try again.");
                    }

                    //(2a3) check if response is < 1
                    if (baseVal < 1)
                    {
                        Console.WriteLine("ERROR: base number cannot be < 1.  Try again.");
                    }

                } while (baseVal < 1); // end do-while

                // (2a) do-while to prompt user for number and check if > 1 & int
                // exponent number
                do
                {
                    // (2a1) Prompt user for value and read in response
                    Console.WriteLine("---> PLease enter in exponent number (int, > 1).");
                    expString = Console.ReadLine();

                    // (2a2) check if response is an int
                    if (!int.TryParse(expString, out expVal))
                    {
                        Console.WriteLine("ERROR: base number must be int.  Try again.");
                    }

                    //(2a3) check if response is < 1
                    if (expVal < 1)
                    {
                        Console.WriteLine("ERROR: base number cannot be < 1.  Try again.");
                    }
                } while (expVal < 1); // end do-while

                // (3) call Power() method & print reuslt
                Console.WriteLine($"The base '{baseVal}' taken to the power of '{expVal}' exponent = '{Power(baseVal, expVal)}'.");

                // (4) create do-while to prompt user to repeat
                do
                {
                    // (4a) Prompt user for value and read in response
                    Console.WriteLine("---> Caculate again (y/n)?");
                    repeatVal = Console.ReadLine();

                    // (4b) check response is either "y" or "n"
                    if (repeatVal != "y" && repeatVal != "n")
                    {
                        Console.WriteLine("ERROR: invalid entry.  Please try again.");
                    }
                } while (repeatVal != "y" && repeatVal != "n");

            } while (repeatVal != "n"); // end do-while

        } // end Main()
    } // end class Program
} // namespace BaseExpCalc