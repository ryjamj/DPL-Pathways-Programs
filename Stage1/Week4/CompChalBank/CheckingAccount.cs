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
    class CheckingAccount : Account
    {
        // variables
        // =================================================
        // propertry approach
        public double AnnualFee { get; set; }

        // constructors
        // =================================================
        // 'default' constructor
        public CheckingAccount() : base()
        {
            AnnualFee = 0.0;
        }

        // 'parameter' constructor
        public CheckingAccount(string newAccountID, string newType, double newCurrentBalance, double newAnnualFee) : base(newAccountID, newType, newCurrentBalance)
        {
            AnnualFee = newAnnualFee;
        }

        // methods
        // =================================================
        public override void DepositMeth(string AmountString)
        {
            CurrentBalance = CurrentBalance + Convert.ToDouble(AmountString);
        }

        // WithdrawalMeth() for checking, amount cannot be greater than 50% of current balance
        public override void WithdrawalMeth(string AmountString)
        {
            double Amount = Convert.ToDouble(AmountString);
            if (Amount > CurrentBalance)
            {
                Console.WriteLine($"ERROR: the withdrawal amount '${Amount}' excesseds the current balance of '${CurrentBalance}'.");
            }
            else if (Amount > (0.50 * CurrentBalance))
            {
                Console.WriteLine($"ERROR: the withdrawal amount '${Amount}' cannot excessed 50% of the current balance of '${CurrentBalance}'.");
            }
            else
            {
                CurrentBalance = CurrentBalance - Amount;
                Console.WriteLine($"'${Amount}' has been withdrawn from the current balance of the account.");
            }
        }


        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()} |  AnnualFee: {AnnualFee}");
        }


    }// end class
}// end namespace

