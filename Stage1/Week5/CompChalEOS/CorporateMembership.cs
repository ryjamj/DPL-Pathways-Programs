/*
Program Name: CompChalEOS
Last Updated: 08/14/2023
Program Description: Competency Challenge End of Stage 1

Requirements:
1 - if OEOrganization = true,  CashBack() is doubled

Algorithm:
1 -

*/

using System;
namespace CompChalEOS

{
    class CorporateMembership : Membership
    {
        // variables
        // =================================================
        // N/A

        // constructors
        // =================================================
        // 'default' constructor
        public CorporateMembership() : base()
        {
            // N/A
        }

        // 'parameter' constructor
        public CorporateMembership(string newMembershipID, string newContactEmail, string newType, double newAnnualCost, double newPurchaseAmountSum) : base(newMembershipID, newContactEmail, newType, newAnnualCost, newPurchaseAmountSum)
        {
        }


        // methods
        // =================================================
        public override void cashBackMeth()
        {
            Console.WriteLine($"'${PurchaseAmountSum * 0.02}' has been rewarded back as a cash back reward to member id '{MembershipID}'.");
            PurchaseAmountSum = 0.0;
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()}");
        }


    }// end class
}// end namespace

