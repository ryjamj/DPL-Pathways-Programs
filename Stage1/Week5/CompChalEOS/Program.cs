/*
Program Name: CompChalEOS
Last Updated: 08/14/2023
Program Description: Competency Challenge End of Stage 1

Requirements:
1-

Algorithm:
1 -

*/


using System;
namespace CompChalEOS
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
        static string checkMembershipTypeIntStringMeth()
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
        static bool checkMEOrganizationStringMeth()
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




        // Main()
        // ================================================================================
        static void Main(string[] args)
        {
            // Main() variables
            int index;
            string userChoiceString;
            bool userChoice;
            bool itemFoundBool;
            string MembershipIDString;
            string ContactEmailString;
            string MembershipTypeIntString;
            string AmountString;

            // create list of memberships
            List<Membership> membershipList = new List<Membership>();

            // Add a couple of test objects
            membershipList.Add(new RegularMembership("a1", "a1@gmail.com", "Regular", 50, 0));
            membershipList.Add(new ExecutiveMembership("b1", "b1@gmail.com", "Executive", 50, 0));
            membershipList.Add(new NonProfitMembership("c1", "c1@gmail.com", "NonProfit", 50, 0, true));
            membershipList.Add(new CorporateMembership("d1", "d1@gmail.com", "Corporate", 200, 0));

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
                    Console.WriteLine("--> L - List all of the memberships.");
                    Console.WriteLine("--> P - Perform a purchase transaction.");
                    Console.WriteLine("--> T - Perform a return transaction.");
                    Console.WriteLine("--> A - Apply cash-back rewards.");
                    Console.WriteLine("--> C - Create a new membership.");
                    Console.WriteLine("--> U - Update an existing membership.");
                    Console.WriteLine("--> D - Delete an existing membership.");
                    Console.WriteLine("--> Q - Quit the program.");

                    //  TODO: prompt user for input option.
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                    userChoiceString == "P" || userChoiceString == "p" ||
                                    userChoiceString == "T" || userChoiceString == "t" ||
                                    userChoiceString == "A" || userChoiceString == "a" ||
                                    userChoiceString == "C" || userChoiceString == "c" ||
                                    userChoiceString == "U" || userChoiceString == "u" ||
                                     userChoiceString == "D" || userChoiceString == "d" ||
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
                    for (index = 0; index < membershipList.Count; index++)
                    {
                        if (membershipList[index] != null)
                        {
                            Console.Write(membershipList[index]);
                            Console.WriteLine();
                        }
                    } // end for-loop
                } // end else-if L


                // --------------------------------------------------------
                //  Else if the option is a 'P' or 'p' then perform purchase method
                else if (userChoiceString == "P" || userChoiceString == "p")
                {
                    Console.WriteLine("-- In the P/p area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Perform a purchase and add amount into monthly total purcahses.");

                    // prompt user for MembershipID
                    Console.WriteLine("--> Please enter in MembershipID...");
                    MembershipIDString = checkStringMeth();

                    // for-loop, Look for MembershipID in list
                    for (index = 0; index < membershipList.Count; index++)
                    {
                        if (membershipList[index].MembershipID != MembershipIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // MembershipID found, prompt user for new amount value, perform despoit meth()
                                Console.WriteLine($"'Found membership '{MembershipIDString}' at index '{index}'");
                                Console.WriteLine("--> Please enter in purcahse amount...");
                                AmountString = checkAmountMeth();
                                membershipList[index].purchaseMeth(AmountString);
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop

                    // if user prompt of MembershipID not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine($"ERROR: Cound not find that membership id '{MembershipIDString}' within the list, action terminated.");
                    }
                } // end else-if P



                // --------------------------------------------------------
                //  Else if the option is a 'T' or 'T' then perform return method
                else if (userChoiceString == "T" || userChoiceString == "t")
                {
                    Console.WriteLine("-- In the T/t area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Perform a return and remove amount from monthly total purcahses.");

                    // prompt user for MembershipID
                    Console.WriteLine("--> Please enter in MembershipID...");
                    MembershipIDString = checkStringMeth();

                    // for-loop, Look for MembershipID in list
                    for (index = 0; index < membershipList.Count; index++)
                    {
                        if (membershipList[index].MembershipID != MembershipIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // MembershipID found, prompt user for new amount value, perform return meth()
                                Console.WriteLine($"'Found membership '{MembershipIDString}' at index '{index}'");
                                Console.WriteLine("--> Please enter in return amount...");
                                AmountString = checkAmountMeth();
                                membershipList[index].returnMeth(AmountString);
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop

                    // if user prompt of MembershipID not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine($"ERROR: Cound not find that membership id '{MembershipIDString}' within the list, action terminated.");
                    }
                } // end else-if T


                // --------------------------------------------------------
                //  Else if the option is a 'A' or 'a' then perform cash back method
                else if (userChoiceString == "A" || userChoiceString == "a")
                {
                    Console.WriteLine("-- In the A/a area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Perform a return and remove amount from monthly total purcahses.");

                    // prompt user for MembershipID
                    Console.WriteLine("--> Please enter in MembershipID...");
                    MembershipIDString = checkStringMeth();

                    // for-loop, Look for MembershipID in list
                    for (index = 0; index < membershipList.Count; index++)
                    {
                        if (membershipList[index].MembershipID != MembershipIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // MembershipID found, perform cash back meth()
                                Console.WriteLine($"'Found membership '{MembershipIDString}' at index '{index}'");
                                membershipList[index].cashBackMeth();
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop

                    // if user prompt of MembershipID not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine($"ERROR: Cound not find that membership id '{MembershipIDString}' within the list, action terminated.");
                    }
                } // end else-if A


                // --------------------------------------------------------
                //  Else if the option is a 'C' or 'c' then add a new member to the list
                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    Console.WriteLine("-- In the C/c area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Create a new membership account, add to list.");

                    // prompt user for MembershipID
                    Console.WriteLine("--> Please enter in new unique Membership ID value for the account...");
                    MembershipIDString = checkStringMeth();

                    // for-loop, Look for MembershipID in list
                    for (index = 0; index < membershipList.Count; index++)
                    {
                        if (membershipList[index].MembershipID != MembershipIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // MembershipID found, ERROR: Membership ID needs to be unique with no duplicates
                                Console.WriteLine($"'ERROR: A membership ID of '{MembershipIDString}' at index '{index}' already exists, action canceled");
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop


                    // if user prompt of MembershipID not found, create new objefct
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("--> Please enter in primary contact email address for the account...");
                        ContactEmailString = checkStringMeth();
                        Console.WriteLine("--> Please enter in 'Membership Type' for the account (1:Regular, 2:Executive, 3:NonProfit, 4:Corporate)...");
                        MembershipTypeIntString = checkMembershipTypeIntStringMeth();

                        if (MembershipTypeIntString == "1")  // Regular
                        {
                            membershipList.Add(new RegularMembership(MembershipIDString, ContactEmailString, "Regular", 50, 0));

                        }
                        else if (MembershipTypeIntString == "2")  // Executive
                        {
                            membershipList.Add(new ExecutiveMembership(MembershipIDString, ContactEmailString, "Executive", 50, 0));
                        }

                        else if (MembershipTypeIntString == "3")  // NonProfit
                        {
                            Console.WriteLine("--> Is this Non-Profit a military or educational organization (y/n)?...");
                            membershipList.Add(new NonProfitMembership(MembershipIDString, ContactEmailString, "NonProfit", 50, 0, checkMEOrganizationStringMeth()));
                        }
                        else // Corporate
                        {
                            membershipList.Add(new CorporateMembership(MembershipIDString, ContactEmailString, "Corporate", 200, 0));
                        } // end if, else if, else
                        Console.WriteLine("New membership account created.");
                    } // end if found
                } // end else if C


                // --------------------------------------------------------
                //  Else if the option is a 'U' or 'u' then update information about the employee (if it's there)
                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    Console.WriteLine("-- In the U/u area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Update information for an membership account.");

                    // prompt user for MembershipID
                    Console.WriteLine("--> Please enter in Membership ID value for the account to update...");
                    MembershipIDString = checkStringMeth();

                    // for-loop, Look for MembershipID in list
                    for (index = 0; index < membershipList.Count; index++)
                    {
                        if (membershipList[index].MembershipID != MembershipIDString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine("--> Please enter in primary contact email address for the account...");
                                ContactEmailString = checkStringMeth();
                                Console.WriteLine("--> Please enter in 'Membership Type' for the account (1:Regular, 2:Executive, 3:NonProfit, 4:Corporate)...");
                                MembershipTypeIntString = checkMembershipTypeIntStringMeth();

                                if (MembershipTypeIntString == "1")  // Regular
                                {

                                    membershipList[index] = new RegularMembership(MembershipIDString, ContactEmailString, "Regular", 50, 0); ;
                                    itemFoundBool = true;
                                    Console.WriteLine("Membership account updated.");
                                    break;

                                }
                                else if (MembershipTypeIntString == "2") // Executive
                                {
                                    membershipList[index] = new ExecutiveMembership(MembershipIDString, ContactEmailString, "Executive", 50, 0);
                                    itemFoundBool = true;
                                    Console.WriteLine("Membership account updated.");
                                    break;
                                }
                                else if (MembershipTypeIntString == "3")  // NonProfit
                                {
                                    Console.WriteLine("--> Is this Non-Profit a military or educational organization (y/n)?...");
                                    membershipList[index] = new NonProfitMembership(MembershipIDString, ContactEmailString, "NonProfit", 50, 0, checkMEOrganizationStringMeth());
                                    itemFoundBool = true;
                                    Console.WriteLine("Membership account updated.");
                                    break;
                                }
                                else  // Corporate
                                {
                                    membershipList[index] = new CorporateMembership(MembershipIDString, ContactEmailString, "Corporate", 200, 0);
                                    itemFoundBool = true;
                                    Console.WriteLine("Membership account updated.");
                                    break;
                                } // end if, else if, else
                            } // end if (itemFoundBool == false)
                        } // end if-else
                    } // end for-loop

                    // if user prompt of MembershipID not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine($"ERROR: Cound not find that membership id '{MembershipIDString}' within the list, action terminated.");
                    }
                } // end else if U





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

