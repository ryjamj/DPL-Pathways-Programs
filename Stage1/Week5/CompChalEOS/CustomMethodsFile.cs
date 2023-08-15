/*
Program Name: CompChalEOS
Last Updated: 08/14/2023
Program Description: Competency Challenge End of Stage 1

Requirements:
1 - file to hold the custom functions used to check user entries for accuracy.

Algorithm:
1- 

*/

using System;
namespace CompChalEOS
{
    public class CustomMethodsFile
    {
        // checkStringMeth() Method, check if string input is valid
        // ================================================================================
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


        // checkAmountMeth() method to check int inputs
        // ================================================================================
        public string checkAmountMeth()
        {
            // Create variables.
            string AmountString;
            int Amount;
            string outputAmount;

            // do-while loop to prompt user for raiting, msut be 0 <= x.  
            do
            {
                // input from user
                AmountString = Console.ReadLine();

                // check if the provided score is integer.
                if (!int.TryParse(AmountString, out Amount))
                {
                    Console.WriteLine("ERROR: This is not a number, try again.");
                }

                // check if the provided score is 0 <= x.
                if (Amount <= 0)
                {
                    Console.WriteLine("ERROR: The number must be > 0, try again.");
                }

            } while ((!int.TryParse(AmountString, out Amount)) || (Amount <= 0)); //end do-while, score

            // convert int to string, return string
            outputAmount = Amount.ToString();
            return outputAmount;
        } // end checkAmountMeth()


        // checkMembershipTypeIntStringMeth() method to check int inputs for method type, returns string
        // ================================================================================
        public string checkMembershipTypeIntStringMeth()
        {
            // Create variables.
            string AmountString;
            int Amount;
            string outputAmount;


            // do-while loop to prompt user for raiting, msut be 0 <= x.  
            do
            {
                // input from user
                AmountString = Console.ReadLine();

                // check if the provided score is integer.
                if (!int.TryParse(AmountString, out Amount))
                {
                    Console.WriteLine("ERROR: This is not a number, try again.");
                }

                // check if the provided score is 0 <= x.
                if (Amount > 4)
                {
                    Console.WriteLine("ERROR: Invalied number, use 1:Regular, 2:Executive, 3:NonProfit, 4:Corporate, try again.");
                }

            } while ((!int.TryParse(AmountString, out Amount)) || (Amount > 4)); //end do-while, score

            // convert int to string, return string
            outputAmount = Amount.ToString();
            return outputAmount;
        } // end checkMembershipTypeIntStringMeth()


        // checkMEOrganizationStringMeth() Method, check if string input is valid, return bool
        // ================================================================================
        public bool checkMEOrganizationStringMeth()
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

                // cehck for 'y' or 'no' response
                if ((inputString != "y") && (inputString != "n"))
                {
                    Console.WriteLine("ERROR: response must either be 'y' for yes or 'n' for no. Try again.");
                }
            } while ((String.IsNullOrEmpty(inputString)) || ((inputString != "y") && (inputString != "n"))); // end do-while, inputString

            // check for value, return correct bool
            if (inputString == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        } // end checkMEOrganizationStringMeth()

    }// end class
}// end namespace

