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
    class SavingsAccount : Account, ICalcAnnualInterest
    {
        // variables
        // =================================================
        public double AnnualInterestRate { get; set; }

        // constructors
        // =================================================
        // 'default' constructor
        public SavingsAccount() : base()
        {
            AnnualInterestRate = 0.0;
        }

        // 'parameter' constructor
        public SavingsAccount(string newAccountID, string newType, double newCurrentBalance, double newAnnualInterestRate) : base(newAccountID, newType, newCurrentBalance)
        {
            AnnualInterestRate = newAnnualInterestRate;
        }

        // methods
        // =================================================
        public override void DepositMeth(string AmountString)
        {
            CurrentBalance = CurrentBalance + Convert.ToDouble(AmountString);
        }

        // WithdrawalMeth() for savings, amount cannot be greater than current balance
        public override void WithdrawalMeth(string AmountString)
        {
            double Amount = Convert.ToDouble(AmountString);
            if (Amount > CurrentBalance)
            {
                Console.WriteLine($"ERROR: the withdrawal amount '${Amount}' excesseds the current balance of '${CurrentBalance}'.");
            }
            else
            {
                CurrentBalance = CurrentBalance - Amount;
                Console.WriteLine($"'${Amount}' has been withdrawn from the current balance of the account.");
            }
        }

        // instance calcAnnualInterestMeth()
        public double calcAnnualInterestMeth()
        {
            return (AnnualInterestRate * CurrentBalance);
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()} |  AnnualInterestRate: {AnnualInterestRate} | calcAnnualInterestMeth: ${calcAnnualInterestMeth()}");
        }


    }// end class
}// end namespace

