using System;

namespace TwoDArrayScore
{
    class Program
    {

        // Main()
        // ================================================================================
        static void Main(string[] args)
        {
            // global variables - array of student score.
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, {10, 11, 12} };


            // max value per student
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int maxVal = 0;
                int checkVal = 0;
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    checkVal = arr[row, col];
                    //Console.WriteLine($"'{arr[row, col]}'");
                    if (maxVal < checkVal) {
                        maxVal = checkVal;
                    }
                }
                Console.WriteLine($"Max value'{maxVal}'.");
            }


            // min value per student
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int minVal = 100;
                int checkVal = 0;
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    checkVal = arr[row, col];
                    //Console.WriteLine($"'{arr[row, col]}'");
                    if (checkVal < minVal)
                    {
                        minVal = checkVal;
                    }
                }
                Console.WriteLine($"Min value'{minVal}'.");
            }


            // average value per student
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int average = 0;
                int total = 0;
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    //Console.WriteLine($"'{arr[row, col]}'");
                    total = total + arr[row, col];
                }
                average = total / 4;
                Console.WriteLine($"Average value is '{average}'.");
            }


        } // end Main()
    } // end ClassD
} // end namespace