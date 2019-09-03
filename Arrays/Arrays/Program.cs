using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Exercises
    {
        public int SumNumbers(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }

        public int SmallestValue(int[] numbers)
        {
            int small = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (small > numbers[i])
                    small = numbers[i];
            }
            return small;
        }

        public int LargestValue(int[] numbers)
        {
            int big = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (big < numbers[i])
                    big = numbers[i];
            }
            return big;
        }

        public int FindIndex(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (value == numbers[i])
                    return i;

            }
            return -1;
        }

        public int CountElement(int[] numbers, int value)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (value == numbers[i])
                    count++;
            }
            return count;
        }

        public bool Unique(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Array.Sort(numbers);
                if (numbers[i] == numbers[i + 1])
                    count++;
                if (count >= 2)
                    return false;
            }
            return true;
        }

        public void Reverse(int[] numbers)
        {
            for(int i = numbers.Length-1; i > -1; i--)
            {
                 Console.WriteLine(numbers[i]);
            }
        }

        public void Sorting(int[] numbers)
        {
            Array.Sort(numbers);
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void DesSorting(int[] numbers)
        {
            Array.Sort(numbers);
            for (int i = numbers.Length - 1; i > -1; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }
    class Program
    {
        static void Main()
        {
            Exercises ex = new Exercises();
            int[] num1 = { 33, 74, 52, 10, 2022, 10101, 1, 1, 2, 9, 67, 2, 45, 1, 2, 9, };
            int[] num2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Console.WriteLine(ex.SumNumbers(num1));
            Console.WriteLine(ex.SmallestValue(num1));
            Console.WriteLine(ex.LargestValue(num1));
            Console.WriteLine(ex.FindIndex(num1, 2022));
            Console.WriteLine(ex.CountElement(num1, 2));
            Console.WriteLine(ex.Unique(num2));
            ex.Reverse(num2);
            ex.Sorting(num1);
            ex.DesSorting(num1);

            Console.ReadLine();
        }
    }
}
