using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var digits = new int[51];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Methods.Populater(digits);

            //TODO: Print the first number of the array
            Console.WriteLine(digits[0]);
            Console.WriteLine();
            //TODO: Print the last number of the array            
            Console.WriteLine(digits[50]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            Methods.NumberPrinter(digits);
            Console.WriteLine();
            //Console.WriteLine(NumberPrinter(digits));

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(digits);
            Methods.NumberPrinter(digits);
            Console.WriteLine();
            Console.WriteLine("---------REVERSE CUSTOM------------");
            Methods.ReverseArray(digits);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            Methods.ThreeKiller(digits);
            Methods.NumberPrinter(digits);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(digits);
            Methods.NumberPrinter(digits);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var myList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"{myList.Capacity}");
            Console.WriteLine();
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Methods.Populater(myList);

            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {myList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int lookFor;
            bool isaNumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isaNumber = int.TryParse(Console.ReadLine(), out lookFor);
            }
            while (isaNumber == false);
            Methods.NumberChecker(myList, lookFor);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            Methods.NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            Methods.OddKiller(myList);
            Methods.NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            Methods.NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArrary = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();
            Methods.NumberPrinter(myList);
            


            /// <summary>
            /// Generic print method will iterate over any collection that implements IEnumerable<T>
            /// </summary>
            /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
            /// <param name="collection"></param>
           #endregion
        }
    }
}