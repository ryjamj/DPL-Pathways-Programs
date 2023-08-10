/*
Program Name: CompChalOOPEmp
Last Updated: 08/03/2023
Program Description: Use OOP to work on Comptency Challange

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace listOOPEmp
{
    abstract class Employee
    {
        // variables
        // =================================================
        // propertry approach
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmployeeType { get; set; }

        // constructors
        // =================================================
        // This is the 'default' constructor
        public Employee()
        {
            LastName = "";
            FirstName = "";
            EmployeeType = "";
        }
        // This is the 'parameter' constructor when parameters are passed in
        public Employee(string newLastName, string newFirstName, string newEmployeeType)
        {
            LastName = newLastName;
            FirstName = newFirstName;
            EmployeeType = newEmployeeType;
        }


        // methods
        // =================================================
        // this will be a 'virtual' method in our base class.
        public virtual void CalculateBonus()
        {
            Console.WriteLine("\"The returns the bonus amount for the employee\".");
        }

        // ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"ToString() return = LastName: {LastName}, FirstName: {FirstName}, EmployeeType: {EmployeeType}, ");
        }

    }// end class
}// end namespace  