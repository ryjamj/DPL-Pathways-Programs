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
    class CDAccount : Account, ICalcAnnualInterest
    {
        // variables
        // =================================================
        public double AnnualInterestRate { get; set; }
        public double Penalty { get; set; }

        // constructors
        // =================================================
        // 'default' constructor
        public CDAccount() : base()
        {
            AnnualInterestRate = 0.0;
            Penalty = 0.0;
        }

        // 'parameter' constructor
        public CDAccount(string newAccountID, string newType, double newCurrentBalance, double newAnnualInterestRate, double newPenalty) : base(newAccountID, newType, newCurrentBalance)
        {
            AnnualInterestRate = newAnnualInterestRate;
            Penalty = newPenalty;
        }

        // methods
        // =================================================
        public override void DepositMeth(string AmountString)
        {
            CurrentBalance = CurrentBalance + Convert.ToDouble(AmountString);
        }

        // WithdrawalMeth() for CD, amount cannot be greater than current balance + Penalty
        public override void WithdrawalMeth(string AmountString)
        {
            Console.WriteLine($"WARNING: withdrawing from this CD account will incur a penalty fee of '${Penalty}'.");
            double Amount = Convert.ToDouble(AmountString);
            if ((Amount + Penalty) > CurrentBalance)
            {
                Console.WriteLine($"ERROR: the withdrawal amount '${Amount}' & penality '${Penalty}' excesseds the current balance of '${CurrentBalance}'.");
            }
            else
            {
                CurrentBalance = CurrentBalance - (Amount + Penalty);
                Console.WriteLine($"'${Amount}' & penality '${Penalty}' has been withdrawn from the current balance of the account.");
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
            return ($"{base.ToString()} |  AnnualInterestRate: {AnnualInterestRate} | Penalty: ${Penalty} | calcAnnualInterestMeth: ${calcAnnualInterestMeth()}");
        }


    }// end class
}// end namespace

