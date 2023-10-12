using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
	public class Methods
	{
		public Methods()
		{
		}
        public static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        public static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    numberList.Remove(i);
                }

                NumberPrinter(numberList);
            }
        }
        public static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes! We have that number");
            }
            else
            {
                Console.WriteLine($"Sorry that number is not present.");
            }

        }
        public static void Populater(List<int> numberList)
        {
            while (numberList.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);
                numberList.Add(number);

            }
        }
        public static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }
        public static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
        }
        public static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

