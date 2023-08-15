/*
Program Name: CompChalEOS
Last Updated: 08/14/2023
Program Description: Competency Challenge End of Stage 1

Requirements:
1 - for ISpecialOffer, return 25% of the annual membership cost

Algorithm:
1 -

*/

using System;
namespace CompChalEOS

{
    class RegularMembership : Membership, ISpecialOffer
    {
        // variables
        // =================================================
        // N/A

        // constructors
        // =================================================
        // 'default' constructor
        public RegularMembership() : base()
        {
            // N/A
        }

        // 'parameter' constructor
        public RegularMembership(string newMembershipID, string newContactEmail, string newType, double newAnnualCost, double newPurchaseAmountSum) : base(newMembershipID, newContactEmail, newType, newAnnualCost, newPurchaseAmountSum)
        {
        }

        // methods
        // =================================================
        public override void cashBackMeth()
        {
            Console.WriteLine($"'${PurchaseAmountSum * 0.02}' has been rewarded back as a cash back reward to member id '{MembershipID}'.");
            PurchaseAmountSum = 0.0;
        }

        // instance specialOfferMeth()
        public double specialOfferMeth()
        {
            return (AnnualCost * 0.25);
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()} | specialOfferMeth: ${specialOfferMeth()}");
        }


    }// end class
}// end namespace

