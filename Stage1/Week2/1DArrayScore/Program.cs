
using System;

namespace OneDArrayScore
{
    class Program
    {

        // myMinMethod
        // ================================================================================
        public static int myMinMethod(int[] arrIn)
        {
            Array.Sort(arrIn); // sort array
            int retrnVal = arrIn[0];  // return first value in sorted array
            return retrnVal;
        }


        // myMaxMethod
        // ================================================================================
        public static int myMaxMethod(int[] arrIn)
        {
            int arrMaxLen = arrIn.Length - 1; // variable
            Array.Sort(arrIn); // sort array
            int retrnVal = arrIn[arrMaxLen];  // return end value in sorted
            return retrnVal;
        }


        // myAvgMethod
        // ================================================================================
        public static int myAvgMethod(int[] arrIn)
        {
            // variables
            int arrMaxLen = arrIn.Length;
            int totalScore = 0;          

            // for-loop to sum each value in the array to a single value
            for (int i = 0; i < arrIn.Length; i++)
            {
                totalScore = totalScore + arrIn[i];
                Console.WriteLine($"i:{i}, arrIn[i]:{arrIn[i]}, totalScore:{totalScore}.");
            }

            // return average value of array
            return (totalScore / arrMaxLen);
        }


        // Main()
        // ================================================================================
        static void Main(string[] args)
        {
            // global variables
            int[] arr = { 40, 5, 3, 7, 1 };

            // call methods
            Console.WriteLine($"Min value in the given array is '{myMinMethod(arr)}'.");
            Console.WriteLine($"Max value in the given array is '{myMaxMethod(arr)}'.");

            // odd issue of the sorted array being past into the method
            // this is due because the arr is built and stored in memory, so no matter where it's called it's updated on the memory
            // to prevent this, always create a temp copy to maniuplate & return that version.
            Console.WriteLine("-------");
            Console.WriteLine($"Avg value of the given array is '{myAvgMethod(arr)}'.");


        } // end Main()
    } // end ClassD
} // end namespace