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
    class HourlyEmployee : Employee
    {
        // variables
        // =================================================
        // propertry approach
        public string HourlyRate { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public HourlyEmployee() : base()
        {
            HourlyRate = "0";
        }

        // This is the 'parameter' constructor when parameters are passed in
        public HourlyEmployee(string newLastName, string newFirstName, string newEmployeeType, string newHourlyRate) : base(newLastName, newFirstName, newEmployeeType)
        {
            HourlyRate = newHourlyRate;
        }

        // methods
        // =================================================
        // this will be a 'override' method to test Polymorphism.
        public override void CalculateBonus()
        {
            double BonusAmount = Convert.ToDouble(HourlyRate) * 40.0;
            Console.WriteLine($"\"The Hourly Employee '{FirstName} {LastName}' receives a bonus of ${BonusAmount}\".");
        }
        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return (base.ToString() + "HourlyRate: " + HourlyRate);
        }

    }// end class
}// end namespace