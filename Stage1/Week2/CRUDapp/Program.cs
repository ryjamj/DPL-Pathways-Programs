/*
Program Name: CRUDapp
Last Updated: 07/25/2023
Program Description:
    Working with provdied script of working with txt file.
    Working through CRUD operations.

Requirements:
1 - use names.txt file, save to nameArray.

Algorithm:
1 - Provide the user a menu of options
2- 
1 - L
2S
C
R
U
D
Q

*/

using System;

namespace CRUDApp
{
    class Program
    {


        // checkNameStringMeth() Method, check if nameString is valid
        // ================================================================================
        static string checkNameStringMeth()
        {
            // variables
            string nameString;

            // do while, check if nameString is valid
            do
            {
                Console.WriteLine("--> Please enter in name...");
                nameString = Console.ReadLine();
                if (String.IsNullOrEmpty(nameString))
                {
                    Console.WriteLine("ERROR: name cannot be an empty entry. Try again.");
                }
            } while (String.IsNullOrEmpty(nameString)); // end do-while, nameString

            return nameString;

        } // end checkNameStringMeth()



        // Main()
        // ================================================================================
        static void Main(string[] args)
        {
            // Declare Global variables
            string userChoiceString;
            string checkNameString;
            bool userChoice;
            const int arraySize = 12;
            string[] nameArray = new string[arraySize];
            string inputFileName = "names.txt";
            string outputFileName = "new_names.txt";
            bool itemFoundBool;

            // do while to loop Main()
            do
            {
                // TODO: Get a valid input
                do
                {
                    //  Initialize variables
                    userChoice = false;

                    //  TODO: Provide the user a menu of options
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("--> L: Load the data file into an array.");
                    Console.WriteLine("--> S: Save the array to the data file.");
                    Console.WriteLine("--> C: Add a name to the array.");
                    Console.WriteLine("--> R: Read names from the array.");
                    Console.WriteLine("--> U: Update a name in the array.");
                    Console.WriteLine("--> D: Delete a name from the array.");
                    Console.WriteLine("--> Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)
                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                userChoiceString == "S" || userChoiceString == "s" ||
                                userChoiceString == "C" || userChoiceString == "c" ||
                                userChoiceString == "R" || userChoiceString == "r" ||
                                userChoiceString == "U" || userChoiceString == "u" ||
                                userChoiceString == "D" || userChoiceString == "d" ||
                                userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("ERROR: Please enter a valid option.");
                    }

                } while (!userChoice); // end do-while, TODO: Get a valid input


                //  TODO: If the option is 'L' or 'l' then load the text file (names.txt) into the array of strings (nameArray)
                if (userChoiceString == "L" || userChoiceString == "l")
                {
                    Console.WriteLine("-- In the L/l area --");
                    int index = 0;  // index for my array
                    using (StreamReader sr = File.OpenText(inputFileName))
                    {
                        string s = "";
                        Console.WriteLine("--- Here is the content of the file names.txt ---");
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            nameArray[index] = s;
                            index = index + 1;
                        }
                        Console.WriteLine("");
                    }
                }// end else if L


                //  TODO: Else if the option is an 'S' or 's' then store the array of strings into the text file
                else if (userChoiceString == "S" || userChoiceString == "s")
                {
                    Console.WriteLine("-- In the S/s area --");
                    using (StreamWriter sr = File.CreateText(outputFileName))
                    {
                        for (int index = 0; index < arraySize; index++)
                        {
                            sr.WriteLine(nameArray[index]);
                        }
                    }
                    Console.WriteLine("Array saved to file.");
                } // end else if S


                //  TODO: Else if the option is a 'C' or 'c' then add a name to the array (if there's room)
                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("-- In the C/c area --");

                    // for-loop, look for blank value, fill in with new name
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) != "")
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"Space found at index '{index}'.");
                                nameArray[index] = checkNameStringMeth();
                                itemFoundBool = true;
                            }
                        }

                    } // end for-loop

                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("Thre is no room for any more names.");
                    }

                } // end else if C


                //  TODO: Else if the option is an 'R' or 'r' then print the array
                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("-- In the R/r area --");
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) != "")
                            Console.WriteLine(nameArray[index]);
                        else
                            Console.WriteLine("Index " + index + " is available.");
                    }
                } // end else if R


                //  TODO: Else if the option is a 'U' or 'u' then update a name in the array (if it's there)
                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("-- In the U/u area --");
                    Console.WriteLine("Look for name to update in array");
                    checkNameString = checkNameStringMeth();

                    // for-loop, Look for checkNameString
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) != checkNameString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"'{checkNameString}' found at index '{index}'.");
                                nameArray[index] = checkNameStringMeth();
                            }
                        }
                    } // end for-loop

                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("Thre is no room for any more names.");
                    }
                } // end else if U


                //  TODO: Else if the option is a 'D' or 'd' then delete the name in the array (if it's there)
                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("-- In the D/d area --");
                    Console.WriteLine("Look for name to delete in array");
                    checkNameString = checkNameStringMeth();

                    // for-loop, Look for checkNameString
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) == checkNameString)
                        {
                            Console.WriteLine($"'{checkNameString}' found at index '{index}'.");
                            nameArray[index] = "";
                        }
                        else
                        {
                            Console.WriteLine($"That name is not at index '{index}'.");
                        }
                    } // end for-loop

                } // end else if D


                //  TODO: Else if the option is a 'Q' or 'q' then quit the program
                else
                {
                    Console.WriteLine("Good-bye!");
                } // end else if Q


            } while (!(userChoiceString == "Q") && !(userChoiceString == "q")); // end do-while, loop Main()


        }  // end main
    }  // end program
}  // end namespace