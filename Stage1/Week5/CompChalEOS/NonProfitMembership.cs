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
    class NonProfitMembership : Membership
    {
        // variables
        // =================================================
        public bool MEOrganization { get; set; }

        // constructors
        // =================================================
        // 'default' constructor
        public NonProfitMembership() : base()
        {
            MEOrganization = false;
        }

        // 'parameter' constructor
        public NonProfitMembership(string newMembershipID, string newContactEmail, string newType, double newAnnualCost, double newPurchaseAmountSum, bool newMEOrganization) : base(newMembershipID, newContactEmail, newType, newAnnualCost, newPurchaseAmountSum)
        {
            MEOrganization = newMEOrganization;
        }

        // methods
        // =================================================
        public override void cashBackMeth()
        {
            if (MEOrganization == true)
            {
                Console.WriteLine($"'${PurchaseAmountSum * 0.02}' has been rewarded back as a cash back reward to member id '{MembershipID}'.");
                PurchaseAmountSum = 0.0;
            }
            else
            {
                Console.WriteLine($"'${PurchaseAmountSum * 0.04}' has been rewarded back as a cash back reward to member id '{MembershipID}'.");
                PurchaseAmountSum = 0.0;
            }

        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()} | MEOrganization: {MEOrganization}");
        }


    }// end class
}// end namespace

