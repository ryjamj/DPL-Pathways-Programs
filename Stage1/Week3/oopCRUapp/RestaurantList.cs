/*
Program Name:
Last Updated:
Program Description:


Requirements:


Algorithm:

*/

using System;

namespace oopCRUapp
{
    class RestaurantList
    {
        // =================================================================
        // declare variables for the class


        // =================================================================
        // constructors()


        // =================================================================
        // methods()

        // checkStringMeth() Method, check if string input is valid
        public string checkStringMeth()
        {
            // variables
            string inputString;

            // do while, check if nameString is valid
            do
            {
                // input from user
                inputString = Console.ReadLine();

                // check if input is empty
                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("ERROR: string entry cannot be an empty entry. Try again.");
                }
            } while (String.IsNullOrEmpty(inputString)); // end do-while, inputString
            return inputString;
        } // end checkStringMeth()


        // checkRaitingMeth() method, check if string input can convert to int.
        public string checkRaitingMeth()
        {
            // Create variables.
            string RatingString;
            int Rating;
            string outputRating;

            // do-while loop to prompt user for raiting, msut be 0 <= x= 5.  
            do
            {
                // input from user
                RatingString = Console.ReadLine();

                // check if the provided score is integer.
                if (!int.TryParse(RatingString, out Rating))
                {
                    Console.WriteLine("ERROR: This is not a number, try again.");
                }

                // check if the provided score is 0 <= x <= 5.
                if ((Rating > 5) || (Rating < -1))
                {
                    Console.WriteLine("ERROR: The number must be > 0 but < 5, try again.");
                }

            } while ((!int.TryParse(RatingString, out Rating)) || ((Rating > 5) || (Rating < -1))); //end do-while, score

            // convert int to string, return string
            outputRating = Rating.ToString();
            outputRating = outputRating + " stars";
            return outputRating;
        } // end checkRaitingMeth()


    } // end class RestaurantList
} // end namespace