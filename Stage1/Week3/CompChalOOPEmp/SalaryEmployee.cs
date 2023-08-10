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
namespace CompChalOOPEmp
{
    class SalaryEmployee : Employee
    {
        // variables
        // =================================================
        // propertry approach
        public string AnnualSalary { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public SalaryEmployee() : base()
        {
            AnnualSalary = "0";
        }

        // This is the 'parameter' constructor when parameters are passed in
        public SalaryEmployee(string newLastName, string newFirstName, string newEmployeeType, string newAnnualSalary) : base(newLastName, newFirstName, newEmployeeType)
        {
            AnnualSalary = newAnnualSalary;
        }

        // methods
        // =================================================
        // this will be a 'override' method to test Polymorphism.
        public override void CalculateBonus()
        {
            double BonusAmount = Convert.ToDouble(AnnualSalary) * 0.10;
            Console.WriteLine($"\"The Salary Employee '{FirstName} {LastName}' receives a bonus of ${BonusAmount}\".");
        }
        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return (base.ToString() + "AnnualSalary: " + AnnualSalary);
        }

    }// end class
}// end namespace