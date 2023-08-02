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
    class Program
    {
        static void Main(string[] args)
        {
            // Main() variables
            string inputFileName = "restaurant_rank.txt";
            string outputFileName = "new_restaurant_rank.txt";
            string userChoiceString;
            string checkNameString;
            bool userChoice;
            bool itemFoundBool;

            int index = 0;
            const int arrayFileInSize = 50;
            string[] input1DArray = new string[arrayFileInSize];

            int Rows = 25;
            int Columns = 2;
            string[,] name2DArray = new string[Rows, Columns];

            // create object
            RestaurantList NewListObj = new RestaurantList();


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
                    Console.WriteLine("--> O - Open the user's list of restaurants.");
                    Console.WriteLine("--> S - Save the user's list of restaurants.");
                    Console.WriteLine("--> C - Add a restaurant and rating (require name and rating).");
                    Console.WriteLine("--> R - Print a list of all the restaurants and their rating.");
                    Console.WriteLine("--> U - Update the rating for a restaurant.");
                    Console.WriteLine("--> D - Delete a restaurant.");
                    Console.WriteLine("--> Q - Quit the program.");

                    //  TODO: prompt user for input option.
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString == "O" || userChoiceString == "o" ||
                                userChoiceString == "S" || userChoiceString == "s" ||
                                userChoiceString == "C" || userChoiceString == "c" ||
                                userChoiceString == "R" || userChoiceString == "r" ||
                                userChoiceString == "U" || userChoiceString == "u" ||
                                userChoiceString == "D" || userChoiceString == "d" ||
                                userChoiceString == "Q" || userChoiceString == "q");

                    // Check user input is valid
                    if (!userChoice)
                    {
                        Console.WriteLine("ERROR: Please enter a valid option.");
                    }
                } while (!userChoice); // end do-while, Get a valid input



                // --------------------------------------------------------
                //  If the option is 'O' or 'o' then load the text file (names.txt) into the array of strings (nameArray)
                if (userChoiceString == "O" || userChoiceString == "o")
                {
                    Console.WriteLine("-- In the O/o area --");

                    // TODO: read in txt file, treat as 1d array.
                    index = 0;
                    using (StreamReader sr = File.OpenText(inputFileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            input1DArray[index] = s;
                            index = index + 1;
                        }

                        // TODO: convert 1d array -to- 2d array
                        index = 0;
                        for (int x = 0; x < Rows; x++)
                        {
                            for (int y = 0; y < Columns; y++)
                            {
                                name2DArray[x, y] = input1DArray[index];
                                index++;
                            }
                        }
                    }
                }// end else if L


                // --------------------------------------------------------
                //  TODO: Else if the option is an 'S' or 's' then store the array of strings into the text file
                else if (userChoiceString == "S" || userChoiceString == "s")
                {
                    Console.WriteLine("-- In the S/s area --");

                    // conver 2d array -to - 1d array
                    int k = 0;
                    for (int x = 0; x < Rows; x++)
                    {
                        for (int y = 0; y < Columns; y++)
                        {
                            if (name2DArray[x, 0] != "")
                            {
                                input1DArray[k++] = name2DArray[x, y];
                            }
                        }
                    }

                    // save 1d array to file
                    using (StreamWriter sr = File.CreateText(outputFileName))
                    {
                        for (index = 0; index < arrayFileInSize; index++)
                        {
                            sr.WriteLine(input1DArray[index]);
                        }
                    }
                    Console.WriteLine("Array saved to file.");
                } // end else if S


                // --------------------------------------------------------
                //  Else if the option is an 'R' or 'r' then print the array
                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("-- In the R/r area --");

                    //TODO: Print to conole contents of 2d array.
                    Console.WriteLine("--- Here is the content of the file names.txt ---");


                    /*
                    try using counter, count number of "" entries. count to 25. if counter reaches 25, report back error message "file is blank"
                    */


                    for (int i = 0; i < name2DArray.GetLength(0); i++)
                    {
                        if (name2DArray[i, 0] != "")
                        {
                            {
                                // printing the 2d arary
                                for (int j = 0; j < name2DArray.GetLength(1); j++)
                                {
                                    Console.Write(name2DArray[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                    } // end for-loop
                } // end else if R


                // --------------------------------------------------------
                //  Else if the option is a 'U' or 'u' then update the rating for a restaurant (if it's there)
                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("-- In the U/u area --");
                    Console.WriteLine("Look for restaurant to update raiting in array");
                    Console.WriteLine("--> Please enter in restaurant name...");
                    checkNameString = NewListObj.checkStringMeth();

                    // for-loop, Look for checkNameString
                    for (index = 0; index < Rows; index++)
                    {
                        if ((name2DArray[index, 0]) != checkNameString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"'Found at index '{index}', restaurant '{name2DArray[index, 0]}' has a rating of '{name2DArray[index, 1]}'.");
                                Console.WriteLine("--> Please enter in new raiting for the restaurant...");
                                name2DArray[index, 1] = NewListObj.checkRaitingMeth();
                                itemFoundBool = true;
                            }
                        }
                    } // end for-loop

                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("That name is not on the list.");
                    }
                } // end else if U


                // --------------------------------------------------------
                //  Else if the option is a 'D' or 'd' then delete the restaurant & raiting in the array (if it's there)
                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("-- In the D/d area --");
                    Console.WriteLine("-- > Please enter in restaurant name to delete...");
                    checkNameString = NewListObj.checkStringMeth();

                    // for-loop, Look for checkNameString
                    for (index = 0; index < Rows; index++)
                    {
                        if ((name2DArray[index, 0]) != checkNameString)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"Found restaurant '{checkNameString}'at index '{index}', entry deleted and space available for new entry");
                                name2DArray[index, 0] = "";
                                name2DArray[index, 1] = "";
                                itemFoundBool = true;
                            }
                        }
                    } // end for-loop

                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("That name is not on the list.");
                    }
                } // end else if D


                // --------------------------------------------------------
                //  Else if the option is a 'C' or 'c' then add a name to the array (if there's room)
                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("-- In the C/c area --");

                    // for-loop, look for blank value, fill in with new name
                    for (index = 0; index < Rows; index++)
                    {
                        if ((name2DArray[index, 0]) != "")
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"Space found at index '{index}'.");
                                Console.WriteLine("--> Please enter in name of restaurant.");
                                name2DArray[index, 0] = NewListObj.checkStringMeth();
                                Console.WriteLine("--> Please enter in raiting of restaurant.");
                                name2DArray[index, 1] = NewListObj.checkRaitingMeth();
                                itemFoundBool = true;
                            }
                        }
                    } // end for-loop

                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("There is no room for any more restaurants.");
                    }
                } // end else if C



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