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
namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------
            int p = 0; // used for counter
            List<int> firstlist = new List<int>(); // Creating an List<T> of Integers

            // Adding elements to List, one index at a time
            firstlist.Add(17);
            firstlist.Add(19);
            firstlist.Add(21);
            firstlist.Add(9);
            firstlist.Add(75);
            firstlist.Add(19);
            firstlist.Add(73);


            // -----------------------------------------------
            // Displaying the elements of List
            Console.WriteLine("Elements Present in List:");
            p = 0;
            foreach (int item in firstlist)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(item);
                p++;
            }
            Console.WriteLine(" ");


            // -----------------------------------------------
            // removing the element at index 3
            Console.WriteLine($"Removing the element at index 3, which will be a '{firstlist[3]}'");
            firstlist.RemoveAt(3); // '9' will be removed from the List at index 3, and the list will reshuffle to where '75' will come in at index 3
            Console.WriteLine($"Re-print list to view change.");
            p = 0;
            foreach (int item in firstlist) // print list again to view change
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(item);
                p++;
            }

        } // end Main()
    } // end class Program
}  // end namespace