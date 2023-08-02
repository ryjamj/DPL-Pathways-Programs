/*
Program Name:
Last Updated:
Program Description:

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace OOPInheritanceSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - test default for FoodService class
            Console.WriteLine("\nExample 1 ============================");
            FoodService TestKFC = new FoodService(); // create class
            Console.WriteLine(TestKFC); // test ToString() override
            TestKFC.HoursOperation(); // test method, class FoodService

            // Example 2 - pass parameters into FastFoodRestaurant class
            Console.WriteLine("\nExample 2 ============================");
            FastfoodRestaurant KFC = new FastfoodRestaurant("KFC", "3 stars", "low cost", "9:00am", "7:00pm", false); // create class
            Console.WriteLine(KFC); // test ToString() override
            KFC.HoursOperation(); // test method, class FoodService
            KFC.checkForFriest(); // test method, class FastFoodRestaurant

            // Example 3 - pass parameters into FancyRestaurant class
            Console.WriteLine("\nExample 3 ============================");
            FancyRestaurant CrownSteakhouse = new FancyRestaurant("Crown Steakhouse", "5 stars", "high cost", "4:00pm", "11:00pm", true, 100); // create class
            Console.WriteLine(CrownSteakhouse); // test ToString() override
            CrownSteakhouse.HoursOperation(); // test method, class FoodService
            CrownSteakhouse.checkCostofPlate(); // test method, class FancyRestaurant

            // Example 4 - test default for FancyRestaurant class
            Console.WriteLine("\nExample 4 ============================");
            FancyRestaurant TestCrownSteakhouse = new FancyRestaurant(); // create class
            Console.WriteLine(TestCrownSteakhouse); // test ToString() override
            TestCrownSteakhouse.HoursOperation(); // test method, class FoodService
            TestCrownSteakhouse.checkCostofPlate(); // test method, class FancyRestaurant

        } // end Main()
    } // end class
}  // end namespace