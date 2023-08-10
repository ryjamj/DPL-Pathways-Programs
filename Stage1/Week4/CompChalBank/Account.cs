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
    abstract class Account

    {
        // variables
        // =================================================
        public string AccountID { get; set; }
        public string Type { get; set; }
        public double CurrentBalance { get; set; }

        // constructors
        // =================================================
        // 'default' constructor
        public Account()
        {
            AccountID = null;
            Type = null;
            CurrentBalance = 0.0;
        }
        // 'parameter' constructor
        public Account(string newAccountID, string newType, double newCurrentBalance)
        {
            AccountID = newAccountID;
            Type = newType;
            CurrentBalance = newCurrentBalance;
        }

        // methods
        // =================================================
        // this is the abstract method that all children must implement
        public abstract void DepositMeth(string AmountString);
        public abstract void WithdrawalMeth(string AmountString);

        // ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"AccountID: {AccountID} | Type: {Type} |  CurrentBalance: ${CurrentBalance}");
        }

    }// end class
}// end namespace  