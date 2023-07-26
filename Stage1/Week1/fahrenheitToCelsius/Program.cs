/*
Program Description: This program reads the temperature degree in fahrenheit from the user, checks if the entry is a number & < 500, converts to celsius, and provides the number back to the user. Programmer: Ryan James
Date: July 19, 2023

Requirements:
(1) the temp of fahrenheit will be an string, from user.
(2) use TryParse() to check if user entry can convert to a float.  Repeat prompt if entry is not a float.
(3) the temp will be converterd to celsius by - 32.0 /(1.8), which will be a float.

Algorithm:
(1) set global variables
(2) do-while loop to check entry is float & < 500;
(2a) prompt the user for the temp in fahrenheit.
(2b) obtain the temp in fahrenheit, read in as string.
(2c) check data type of tempInFAsString.
(2d) check if tempInF is < 500
(3) convert temp from fahrenheit to celsius.
(4) output the temp in celsius to user.
*/


using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        // myFahrenheitToCelsiusMeth() Method. Convert F to C.
        static void myFahrenheitToCelsiusMeth()
        {
            // (1) set global variables
            string ?tempInFAsString;
            float tempInF;

            // (2) do-while loop to check entry is float & < 500;
            do
            {
                // (2a) prompt the user for the temp in fahrenheit.
                Console.WriteLine("Enter in a temperature in fahrenheit (must be number & < 500):");

                // (2b) obtain the temp in fahrenheit, read in as string.
                tempInFAsString = Console.ReadLine();

                // (2c) check data type of tempInFAsString, convert to float and output tempInF.
                while (!float.TryParse(tempInFAsString, out tempInF))
                {
                    Console.WriteLine("ERROR: This is not a number, try again. Enter in a temperature in fahrenheit (must be number & < 500):");
                    tempInFAsString = Console.ReadLine();
                }

                // (2d) check if tempInF is < 500
                if (tempInF > 500)
                {
                    Console.WriteLine("ERROR: Entry too large, please enter in a value < 500:");
                }

            } while (tempInF > 500); //end do-while
            Console.WriteLine("Your entered '" + tempInFAsString + "'F");

            // (3) convert temp from fahrenheit to celsius.
            float tempInC = (float)((tempInF - 32.0) / (1.8));

            // (4) output the temp in celsius to user.
            Console.WriteLine("Temperature of '" + tempInF + "'F converts to '" + tempInC + "'C.");

        } // end myFahrenheitToCelsiusMeth()


        // myCelsiusToFahrenheitMeth() Method. Convert C to F.
        static void myCelsiusToFahrenheitMeth()
        {
            // (1) set global variables
            string ?tempInCAsString;
            float tempInC;

            // (2) do-while loop to check entry is float & < 200;
            do
            {
                // (2a) prompt the user for the temp in celsius.
                Console.WriteLine("Enter in a temperature in celsius (must be number & < 200):");

                // (2b) obtain the temp in celsius, read in as string.
                tempInCAsString = Console.ReadLine();

                // (2c) check data type of tempInCAsString, convert to float and output tempInC.
                while (!float.TryParse(tempInCAsString, out tempInC))
                {
                    Console.WriteLine("ERROR: This is not a number, try again. Enter in a temperature in celsius (must be number & < 200):");
                    tempInCAsString = Console.ReadLine();
                }

                // (2d) check if tempInF is < 200
                if (tempInC > 200)
                {
                    Console.WriteLine("ERROR: Entry too large, please enter in a value < 200:");
                }

            } while (tempInC > 200); //end do
            Console.WriteLine("Your entered '" + tempInCAsString + "'C");

            // (3) convert temp from fahrenheit to celsius.
            float tempInF = (float)((tempInC * 1.8) + 32);

            // (4) output the temp in celsius to user.
            Console.WriteLine("Temperature of '" + tempInC + "'C converts to '" + tempInF + "'F.");

        } // end myFahrenheitToCelsiusMeth()


        // Main() Method
        static void Main(string[] args)
        {
            // global varibles
            string ?ConvertPromptString;

            // do-while loop to check user reponse
            do
            {
                // prompt user
                Console.WriteLine("Convert fahrenheit-to-celsius (F), or celsius-to-fahrenheit (C)?");

                // read in user response
                ConvertPromptString = Console.ReadLine();

                // check user prompt for either "F" or "C"
                if ((ConvertPromptString != "F") && (ConvertPromptString != "C"))
                {
                    Console.WriteLine("ERROR: Wrong Entry.  Please Enter in eitehr a \"F\" or \"C\":");
                }

            } while ((ConvertPromptString != "F") && (ConvertPromptString != "C")); // end do-while

            // check user response for "F"
            if (ConvertPromptString == "F")
            {
                // Call myFahrenheitToCelsiusMeth() method
                Console.WriteLine("----Fahrenheit To Celsius Converter----");
                myFahrenheitToCelsiusMeth();
            } // end if

            // check user responsse for "C""
            if (ConvertPromptString == "C")
            {
                // Call myCelsiusToFahrenheitMeth() method
                Console.WriteLine("----Celsius To Fahrenheit Converter----");
                myCelsiusToFahrenheitMeth();
            } // end if

        } // end Main()

    } // end class Program
} // end namespace FahrenheitToCelsius
