/*
Program Name: CompChalOOPEmp
Last Updated: 08/04/2023
Program Description:
    Create a CRUD program that creates employee objects.

Requirements:
Each employee will have a last name, first name and employee type (hourly or salary).
An hourly employee will have an hourly rate. 
A salary employee will have an annual salary.
Bonuses are calculated as followed:
If not hourly or salary, the bonus is 0.
Hourly, the bonus is two weeks pay (40 hours per week)
Salary, the bonus is 10%

Algorithm:
You want a menu that will provide you the options of doing the following:
L - Load the single text file into the program.  The text file stores four lines for each employee including last name, first name, employee type and hourly rate or salary (depending on employee type - H or S)
S - Store the current employee information in the text file
C - Add an employee
R - Print a list of all the employees including their calculated bonus,
U - Update information for an employee,
D - Delete an employee
Q - Quit the program
*/


using System;
namespace CompChalOOPEmp
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


        // checkEmployeeTypeMeth() Method, check if EmployeeType is either 'S' or 'H'
        // ================================================================================
        static string checkEmployeeTypeMeth()
        {
            // variables
            string inputString;

            // do while, check if inputString is valid
            do
            {
                // input from user
                inputString = Console.ReadLine();

                // check if input is empty
                if (String.IsNullOrEmpty(inputString))
                {
                    Console.WriteLine("ERROR: Employee Type entry cannot be an empty entry. Try again.");
                }

                // check if input is either 'S' or 'H'
                if ((inputString != "S") && (inputString != "H"))
                {
                    Console.WriteLine("ERROR: Employee Type entry must either be an 'S' or an 'H'Try again.");
                }

            } while (String.IsNullOrEmpty(inputString) || ((inputString != "S") && (inputString != "H"))); // end do-while, inputString

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

            // do-while loop to prompt user for raiting, msut be 0 <= x= 5.  
            do
            {
                // input from user
                AmountString = Console.ReadLine();

                // check if the provided score is integer.
                if (!int.TryParse(AmountString, out Amount))
                {
                    Console.WriteLine("ERROR: This is not a number, try again.");
                }

                // check if the provided score is 0 <= x <= 5.
                if (Amount < -1)
                {
                    Console.WriteLine("ERROR: The number must be > 0, try again.");
                }

            } while ((!int.TryParse(AmountString, out Amount)) || (Amount < -1)); //end do-while, score

            // convert int to string, return string
            outputAmount = Amount.ToString();
            return outputAmount;

        } // end checkRaitingMeth()




        // Main()
        // ================================================================================
        static void Main(string[] args)
        {

            // Main() variables
            string inputFileName = "EmployeeTextFile.txt";
            string outputFileName = "new_EmployeeTextFile.txt";
            int index = 0;
            int Rows = 25;
            string userChoiceString;
            bool userChoice;
            bool itemFoundBool;
            string LastNameString = "";
            string FirstNameString = "";
            string EmployeeTypeString = "";
            string AmountString = "";

            // create 1d array arrayOfEmployees using Employee class
            Employee[] arrayOfEmployees = new Employee[25];
            for (index = 0; index < arrayOfEmployees.Length; index++)
            {
                arrayOfEmployees[index] = new Employee();
            }


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
                    Console.WriteLine("--> O - Open the user's list of employees.");
                    Console.WriteLine("--> S - Save the user's list of employees.");
                    Console.WriteLine("--> C - Add a Employee to array (require last name, first name, employee type, and amount for pay).");
                    Console.WriteLine("--> R - Print a list of all the employees.");
                    Console.WriteLine("--> U - Update the values for a employee.");
                    Console.WriteLine("--> D - Delete a employee.");
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

                } while (!userChoice); // end do-while, TODO: Get a valid input



                // --------------------------------------------------------
                //  If the option is 'O' or 'o' then load the text file (names.txt) into the array of strings (nameArray)
                if (userChoiceString == "O" || userChoiceString == "o")
                {
                    Console.WriteLine("-- In the O/o area --");

                    // TODO: read in txt file, use ReadLine() to read in 1 line at a time, check 3rd entry 'S', create object, save object in 1d treat arrayOfEmployees array.
                    index = 0;
                    using (StreamReader sr = File.OpenText(inputFileName))
                    {
                        LastNameString = "";
                        FirstNameString = "";
                        EmployeeTypeString = "";
                        AmountString = "";
                        while ((LastNameString = sr.ReadLine()) != null)
                        {
                            FirstNameString = sr.ReadLine();
                            EmployeeTypeString = sr.ReadLine();
                            AmountString = sr.ReadLine();
                            if (EmployeeTypeString == "S")
                            {
                                SalaryEmployee tempObject = new SalaryEmployee();  // create SalaryEmployee object
                                tempObject.LastName = LastNameString;
                                tempObject.FirstName = FirstNameString;
                                tempObject.EmployeeType = EmployeeTypeString;
                                tempObject.AnnualSalary = AmountString;
                                arrayOfEmployees[index] = tempObject;
                            }
                            else
                            {
                                HourlyEmployee tempObject = new HourlyEmployee();  // create HourlyEmployee object
                                tempObject.LastName = LastNameString;
                                tempObject.FirstName = FirstNameString;
                                tempObject.EmployeeType = EmployeeTypeString;
                                tempObject.HourlyRate = AmountString;
                                arrayOfEmployees[index] = tempObject;
                            }
                            index++;
                        }
                    }
                }// end else if L


                // --------------------------------------------------------
                //  TODO: Else if the option is an 'S' or 's' then store the array of strings into the text file
                else if (userChoiceString == "S" || userChoiceString == "s")
                {
                    Console.WriteLine("-- In the S/s area --");
                    // save 1d object array to file
                    using (StreamWriter sw = File.CreateText(outputFileName))
                    {
                        for (index = 0; index < arrayOfEmployees.GetLength(0); index++)
                        {
                            if (arrayOfEmployees[index].LastName != null)
                            {
                                sw.WriteLine(arrayOfEmployees[index].LastName);
                                sw.WriteLine(arrayOfEmployees[index].FirstName);
                                sw.WriteLine(arrayOfEmployees[index].EmployeeType);

                                // struggeling with this portion...
                                //     if (arrayOfEmployees[index].EmployeeType == "S")
                                //     {
                                //         sw.WriteLine(arrayOfEmployees[index].AnnualSalary);
                                //     }
                                //     else
                                //     {
                                //         sw.WriteLine(arrayOfEmployees[index].HourlyRate);
                                //     }
                            }
                        } // end for-loop
                    }
                    Console.WriteLine("Array saved to file.");
                } // end else if S


                // --------------------------------------------------------
                //  Else if the option is an 'R' or 'r' then print the array
                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("-- In the R/r area --");
                    /*
                    try using counter, count number of "" entries. count to 25. if counter reaches 25, report back error message "file is blank"
                    */
                    for (index = 0; index < arrayOfEmployees.GetLength(0); index++)
                    {
                        if (arrayOfEmployees[index] != null)
                        {
                            Console.Write(arrayOfEmployees[index]);
                            Console.WriteLine();
                        }
                    } // end for-loop
                } // end else if R


                // --------------------------------------------------------
                //  Else if the option is a 'U' or 'u' then update information about the employee (if it's there)
                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    Console.WriteLine("-- In the U/u area --");
                    itemFoundBool = false; // flag variable
                    Console.WriteLine("Update information for an employee,");

                    // TO-DO: prompt user for last name & first name of employee to search for
                    Console.WriteLine("--> Please enter in 'Last Name' of employee...");
                    LastNameString = checkStringMeth();
                    Console.WriteLine("--> Please enter in 'First Name' of employee...");
                    FirstNameString = checkStringMeth();

                    // for-loop, Look for LastNameString & FirstNameString
                    for (index = 0; index < Rows; index++)
                    {
                        if (((arrayOfEmployees[index].LastName) != LastNameString) || ((arrayOfEmployees[index].FirstName) != FirstNameString))
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                // TO-DO: employee found, prompt user for new information
                                Console.WriteLine($"'Found at index '{index}', employee '{arrayOfEmployees[index].LastName}'");
                                Console.WriteLine("--> Please enter in new 'Last Name' for the Employee...");
                                LastNameString = checkStringMeth();
                                Console.WriteLine("--> Please enter in new 'First Name' for the Employee...");
                                FirstNameString = checkStringMeth();
                                Console.WriteLine("--> Please enter in new 'Employee Type' for the Employee...");
                                EmployeeTypeString = checkEmployeeTypeMeth();

                                // Check employee type, assign AnnualSalary or HourlyRate
                                if (EmployeeTypeString == "S")
                                {
                                    Console.WriteLine("--> Please enter in new 'Salray' for the Employee...");
                                    AmountString = checkAmountMeth();
                                    SalaryEmployee tempObject = new SalaryEmployee();
                                    tempObject.LastName = LastNameString;
                                    tempObject.FirstName = FirstNameString;
                                    tempObject.EmployeeType = EmployeeTypeString;
                                    tempObject.AnnualSalary = AmountString;
                                    arrayOfEmployees[index] = tempObject;
                                }
                                else
                                {
                                    Console.WriteLine("--> Please enter in new 'Hourly Rate' for the Employee...");
                                    AmountString = checkAmountMeth();
                                    HourlyEmployee tempObject = new HourlyEmployee();
                                    tempObject.LastName = LastNameString;
                                    tempObject.FirstName = FirstNameString;
                                    tempObject.EmployeeType = EmployeeTypeString;
                                    tempObject.HourlyRate = AmountString;
                                    arrayOfEmployees[index] = tempObject;
                                }
                                itemFoundBool = true;
                            }
                        }
                    } // end for-loop

                    // if user prompt of LastNameString & FirstNameString not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("Cound not find employee with that 'Last Name' & 'First Name' in the array.");
                    }
                } // end else if U


                // --------------------------------------------------------
                //  Else if the option is a 'D' or 'd' then delete the employee in the array (if it's there)
                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("-- In the D/d area --");
                    Console.WriteLine("Delete employee information from the array.");
                    itemFoundBool = false; // flag variable

                    // TO-DO: prompt user for last name & first name of employee to search for
                    Console.WriteLine("--> Please enter in 'Last Name' of employee...");
                    LastNameString = checkStringMeth();
                    Console.WriteLine("--> Please enter in 'First Name' of employee...");
                    FirstNameString = checkStringMeth();

                    // for-loop, Look for LastNameString & FirstNameString
                    for (index = 0; index < Rows; index++)
                    {
                        if (((arrayOfEmployees[index].LastName) != LastNameString) || ((arrayOfEmployees[index].FirstName) != FirstNameString))
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"Found employee '{LastNameString}, {FirstNameString}' at index '{index}', entry deleted and space available for new entry");
                                Employee tempObject = new Employee(); // create Employee object
                                arrayOfEmployees[index] = tempObject;
                                itemFoundBool = true;
                            }
                        } // end if-else
                    } // end for-loop

                    // if user prompt of LastNameString & FirstNameString not found 
                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("Cound not find employee with that 'Last Name' & 'First Name' in the array.");
                    }
                } // end else if D


                // --------------------------------------------------------
                //  Else if the option is a 'C' or 'c' then add a name to the array (if there's room)
                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    Console.WriteLine("-- In the C/c area --");
                    itemFoundBool = false; // flag variable

                    // for-loop, look for blank value, fill in with new name
                    for (index = 0; index < Rows; index++)
                    {
                        if ((arrayOfEmployees[index].LastName) != null)
                        {
                            // nothing, skip for now
                        }
                        else
                        {
                            if (itemFoundBool == false)
                            {
                                Console.WriteLine($"'Blank space found at index '{index}'");
                                Console.WriteLine("--> Please enter in new 'Last Name' for the Employee...");
                                LastNameString = checkStringMeth();
                                Console.WriteLine("--> Please enter in new 'First Name' for the Employee...");
                                FirstNameString = checkStringMeth();
                                Console.WriteLine("--> Please enter in new 'Employee Type' for the Employee...");
                                EmployeeTypeString = checkEmployeeTypeMeth();
                                if (EmployeeTypeString == "S")
                                {
                                    Console.WriteLine("--> Please enter in new 'Salray' for the Employee...");
                                    AmountString = checkAmountMeth();
                                    SalaryEmployee tempObject = new SalaryEmployee();
                                    tempObject.LastName = LastNameString;
                                    tempObject.FirstName = FirstNameString;
                                    tempObject.EmployeeType = EmployeeTypeString;
                                    tempObject.AnnualSalary = AmountString;
                                    arrayOfEmployees[index] = tempObject;
                                }
                                else
                                {
                                    Console.WriteLine("--> Please enter in new 'Hourly Rate' for the Employee...");
                                    AmountString = checkAmountMeth();
                                    HourlyEmployee tempObject = new HourlyEmployee();
                                    tempObject.LastName = LastNameString;
                                    tempObject.FirstName = FirstNameString;
                                    tempObject.EmployeeType = EmployeeTypeString;
                                    tempObject.HourlyRate = AmountString;
                                    arrayOfEmployees[index] = tempObject;
                                }
                                itemFoundBool = true;
                            }
                        }
                    } // end for-loop

                    if (itemFoundBool == false)
                    {
                        Console.WriteLine("There is no room for any more employees in the array.");
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

