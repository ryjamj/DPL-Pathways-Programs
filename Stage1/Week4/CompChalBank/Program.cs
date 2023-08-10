/*
Program Name: CompChalBank
Last Updated: 08/10/2023
Program Description: End of week Competency Challenge - Bank

Requirements:
1-

Algorithm:
1 -

*/


using System;
namespace CompChalBank
{
    class Program
    {

        // checkStringMeth() Method, check if string input is valid
        // ================================================================================
        static string checkStringMeth()
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
        static string checkAmountMeth()
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
                if (Amount < -1)
                {
                    Console.WriteLine("ERROR: The number must be > 0, try again.");
                }

            } while ((!int.TryParse(AmountString, out Amount)) || (Amount < -1)); //end do-while, score

            // convert int to string, return string
            outputAmount = Amount.ToString();
            return outputAmount;
        } // end checkAmountMeth()


        // Main()
        // ================================================================================
        static void Main(string[] args)
        {

            // Main() variables
            int index = 0;
            string userChoiceString;
            bool userChoice;
            bool itemFoundBool;
            string AccountIDString = "";
            string AmountString = "";

            // create list of accounts
            List<Account> accountList = new List<Account>();

            // Add a couple of test objects
            accountList.Add(new SavingsAccount("A1", "Savings Account", 100, 0.5));
            accountList.Add(new CheckingAccount("B1", "Checking Account", 200, 20));
            accountList.Add(new CDAccount("C1", "CD Account", 300, 0.2, 20));


            // --------------------------------------------------------
            // do while to loop Main()
            do
            {
                // --------------------------------------------------------
                // Get a valid user input on what task to perform
                do
                {
                    //  Initialize variables
                    userChoice = false;

                    //  TODO: Provide the user a menu of options
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("--> L - List all of the accounts.");
                    Console.WriteLine("--> D - Perform a deposit transaction.");
                    Console.WriteLine("--> W - Perform a withdrawal transaction.");
                    Console.WriteLine("--> Q - Quit the program.");

                    //  TODO: prompt user for input option.
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                    userChoiceString == "D" || userChoiceString == "d" ||
                                    userChoiceString == "W" || userChoiceString == "w" ||
                                    userChoiceString == "Q" || userChoiceString == "q");

                    // Check user input is valid
                    if (!userChoice)
                    {
                        Console.WriteLine("ERROR: Please enter a valid option.");
                    }

                } while (!userChoice); // end do-while, TODO: Get a valid input



                // --------------------------------------------------------
                //  Else if the option is an 'L' or 'l' then print the list
                if (userChoiceString == "L" || userChoiceString == "l")
                {
                    Console.WriteLine("-- In the L/l area --");
                    for (index = 0; index < accountList.Count; index++)
                    {
                        if (accountList[index] != null)
                        {
                            Console.Write(accountList[index]);
                            Console.WriteLine();
                        }
                    } // end for-loop
                } // end else-if L


                // --------------------------------------------------------
                //  Else if the option is a 'D' or 'd' then perform deposit method
                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("-- In the D/d area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Deposit money into an account.");

                    // prompt user for AccountID
                    Console.WriteLine("--> Please enter in AccountID...");
                    AccountIDString = checkStringMeth();

                    // for-loop, Look for AccountID in list
                    for (index = 0; index < accountList.Count; index++)
                    {
                        if (accountList[index].AccountID != AccountIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // AccountID found, prompt user for new amount value, perform despoit meth()
                                Console.WriteLine($"'Found account '{AccountIDString}' at index '{index}'");
                                Console.WriteLine("--> Please enter in amount to despoit into account...");
                                AmountString = checkStringMeth();
                                accountList[index].DepositMeth(AmountString);
                                Console.WriteLine($"'{AmountString}' has been despoited into the current balance of the account.");
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop

                    // if user prompt of AccountID not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("Cound not find that account id within the list.");
                    }
                } // end else-if D



                // --------------------------------------------------------
                //  Else if the option is a 'W' or 'd' then perform withdrawal method
                else if (userChoiceString == "W" || userChoiceString == "w")
                {
                    Console.WriteLine("-- In the W/w area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Withdrawal money into an account.");

                    // prompt user for AccountID
                    Console.WriteLine("--> Please enter in AccountID...");
                    AccountIDString = checkStringMeth();

                    // for-loop, Look for AccountID in list
                    for (index = 0; index < accountList.Count; index++)
                    {
                        if (accountList[index].AccountID != AccountIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // AccountID found, prompt user for new amount value, perform despoit meth()
                                Console.WriteLine($"'Found account '{AccountIDString}' at index '{index}'");
                                Console.WriteLine("--> Please enter in amount to withdrawal into account...");
                                AmountString = checkStringMeth();
                                accountList[index].WithdrawalMeth(AmountString);
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop

                    // if user prompt of AccountID not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("Cound not find that account id within the list.");
                    }
                } // end else-if W



                // --------------------------------------------------------
                //  Else if the option is a 'Q' or 'q' then quit the program
                else
                {
                    Console.WriteLine("Good-bye!");
                } // end else if Q

            } while (!(userChoiceString == "Q") && !(userChoiceString == "q")); // end do-while, loop Main()

        } // end Main()
    } // end class Program
}  // end namespace

