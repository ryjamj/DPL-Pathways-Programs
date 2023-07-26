/*
Program Description: 
    This program reads in a base, beggining exponent, and ending exponnent numbers from the user,
    checks that all numbers are integers greater than 1, 
    calculates and prints the base number to the beggining exponent power to the ending exponnen using a custom method, 
    then prompts the user to repeat the entire exercise.
Last Updated: July 20, 2023

Requirements:
(1) base and exponent number must be integers > 1.
(2) create a custom Power() method to calculate. Use Math.Pow() for exponential calculations.
(3) the ending exponnent number must be > beggining exponent number.
(4) user must be prompted to either repeat the entire exercise or end it.

Algorithm:
(1) create custom Power() method.
(2) create do-while loop to check if the user wants to repeat the entire process
    (2a) do-while to prompt user for baese number and check if > 1 & int
    (2b) do-while loop to ensure the ending exponnent number is > beggining exponent number.
        (2b1) do-while to prompt user for exponnent number and check if > 1 & int
        (2b2) check if ending exponnent number is > beggining exponent number.
(3) For-loop call Power() method & print reuslt from baseVal to endExpVal val.
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
            string? begExpString;
            string? endExpString;
            int baseVal;
            int begExpVal;
            int endExpVal;
            string? repeatVal;

            // (2) create do-while loop to check if the user wants to repeat the entire process.
            do
            {
                //  (2a) do-while to prompt user for baese number and check if > 1 & int
                // base number
                do
                {
                    Console.WriteLine("---> PLease enter in base number (int, > 1).");
                    baseString = Console.ReadLine();

                    if (!int.TryParse(baseString, out baseVal))
                    {
                        Console.WriteLine("ERROR: base number must be int.  Try again.");
                    }

                    if (baseVal < 1)
                    {
                        Console.WriteLine("ERROR: base number cannot be < 1.  Try again.");
                    }

                } while (baseVal < 1); // end do-while


                // (2b) do-while loop to ensure the ending exponnent number is > beggining exponent number.
                do
                {
                    // (2b1) do-while to prompt user for exponnent number and check if > 1 & int
                    // beginning exponent number
                    do
                    {
                        Console.WriteLine("---> PLease enter in beginning exponent number (int, > 1).");
                        begExpString = Console.ReadLine();

                        if (!int.TryParse(begExpString, out begExpVal))
                        {
                            Console.WriteLine("ERROR: number must be int.  Try again.");
                        }

                        if (begExpVal < 1)
                        {
                            Console.WriteLine("ERROR: number cannot be < 1.  Try again.");
                        }
                    } while (begExpVal < 1); // end do-while


                    // (2b1) do-while to prompt user for exponnent number and check if > 1 & int
                    // ending exponent number
                    do
                    {
                        Console.WriteLine("---> PLease enter in ending exponent number (int, > 1).");
                        endExpString = Console.ReadLine();

                        if (!int.TryParse(endExpString, out endExpVal))
                        {
                            Console.WriteLine("ERROR: exponent must be int.  Try again.");
                        }

                        if (endExpVal < 1)
                        {
                            Console.WriteLine("ERROR: number cannot be < 1.  Try again.");
                        }

                    } while (endExpVal < 1); // end do-while


                    // (2b2) check if ending exponnent number is > beggining exponent numbe
                    if (begExpVal > endExpVal)
                    {
                        Console.WriteLine("ERROR: The ending exponent number cannot be < than the beggining exponent number.  Try again.");
                    }

                } while (begExpVal > endExpVal); // end do-while



                // (3) For-loop call Power() method & print reuslt from baseVal to endExpVal val.
                for (int i = begExpVal; i <= endExpVal; ++i)
                {
                    Console.WriteLine($"The base '{baseVal}' taken to the power of '{i}' exponent = '{Power(baseVal, i)}'.");
                }

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