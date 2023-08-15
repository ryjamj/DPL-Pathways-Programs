/*
Program Name: CompChalEOS
Last Updated: 08/14/2023
Program Description: Competency Challenge End of Stage 1

Requirements:
1 -

Algorithm:
1 -

*/

using System;
namespace CompChalEOS
{
    abstract class Membership

    {
        // variables
        // =================================================
        public string MembershipID { get; set; }
        public string ContactEmail { get; set; }
        public string Type { get; set; }
        public double AnnualCost { get; set; }
        public double PurchaseAmountSum { get; set; }

        // constructors
        // =================================================
        // 'default' constructor
        public Membership()
        {
            MembershipID = null;
            ContactEmail = null;
            Type = null;
            AnnualCost = 0.0;
            PurchaseAmountSum = 0.0;
        }
        // 'parameter' constructor
        public Membership(string newMembershipID, string newContactEmail, string newType, double newAnnualCost, double newPurchaseAmountSum)
        {
            MembershipID = newMembershipID;
            ContactEmail = newContactEmail;
            Type = newType;
            AnnualCost = newAnnualCost;
            PurchaseAmountSum = newPurchaseAmountSum;
        }

        // methods
        // =================================================
        public void purchaseMeth(string AmountString)
        {
            double Amount = Convert.ToDouble(AmountString);
            PurchaseAmountSum = PurchaseAmountSum + Amount;
            Console.WriteLine($"'The purchase amount of ${Amount}' has been added to the monthly summation of purcahses for membership {MembershipID}.");
        }
        public void returnMeth(string AmountString)
        {
            double Amount = Convert.ToDouble(AmountString);
            if (Amount > PurchaseAmountSum)
            {
                Console.WriteLine($"ERROR: 'The return amount of '${Amount}' is greater than the current monthly purcahse amount of '${PurchaseAmountSum}', cannot perform return.");
            }
            else
            {
                PurchaseAmountSum = PurchaseAmountSum - Amount;
                Console.WriteLine($"'The return amount of '${Amount}' has been removed from the monthly summation of purcahses for membership {MembershipID}.");

            }
        }

        // this is the abstract method that all children must implement
        public abstract void cashBackMeth();

        // ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"MembershipID: {MembershipID} | ContactEmail: {ContactEmail} |  Type: {Type} |  AnnualCost: ${AnnualCost} |  PurchaseAmountSum: ${PurchaseAmountSum}");
        }

    } // end class
} // end namespace 