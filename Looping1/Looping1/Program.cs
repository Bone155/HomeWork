using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping1
{
    class Example
    {
        public string Ask(string _val)
        {
            Console.Write(_val);
            return Console.ReadLine();
        }
    }
    class Program
    {
        static void Main()
        {
            Example ex = new Example();
            //for (int n = 1; n < 101; n++)
            //{
            //    Console.WriteLine(n);
            //}

            //int num = 100;
            //while (num < 101 && num > 0)
            //{
            //    num--;

            //    Console.WriteLine(num);
            //}

            //int year = 1993;
            //do
            //{
            //    year++;
            //    Console.WriteLine(year);
            //} while (year > 1993 & year < 2017);

            //Console.WriteLine("Howdy! What are your favorite numbers?");
            //Console.WriteLine("Whats the first number");
            //string[] number = new string[3];
            //number[0] = Console.ReadLine();
            //Console.WriteLine("Okay, Whats your second number");
            //number[1] = Console.ReadLine();
            //Console.WriteLine("Okay, Whats your third number");
            //number[2] = Console.ReadLine();
            //Console.WriteLine("Okay, your favoite numbers are " + number[0] + "," + number[1] + ", and " + number[2]);

            //Console.WriteLine("Enter an x and y value");
            //string xValue = Console.ReadLine();
            //string yValue = Console.ReadLine();
            //int x1;
            //int y1;
            //Int32.TryParse(xValue, out x1);
            //Int32.TryParse(yValue, out y1);
            //while (x1 < y1)
            //{
            //    x1++;
            //    Console.WriteLine(x1);
            //}

            //int i1;
            //Int32.TryParse(ex.Ask("How Many Numbers"), out i1);
            //int[] num1 = new int[i1];
            //int big = 0;
            //for (int i = 0; i < num1.Length; i++)
            //{
            //    Int32.TryParse(ex.Ask("Enter your numbers"), out num1[i]);
            //    if (big < num1[i])
            //        big = num1[i];
            //}
            //Console.WriteLine("The biggest number is " + big);

            //int i2;
            //Int32.TryParse(ex.Ask("How Many Numbers"), out i2);
            //int[] num2 = new int[i2];
            //int small = int.MaxValue;
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    Int32.TryParse(ex.Ask("Enter your numbers"), out num2[i]);
            //    if (small > num2[i])
            //        small = num2[i];
            //}
            //Console.WriteLine("The smallest number is " + small);

            //Console.WriteLine("Enter a start number");
            //string startValue = Console.ReadLine();
            //Console.WriteLine("Enter an ending number");
            //string endValue = Console.ReadLine();
            //int x2;
            //int y2;
            //Int32.TryParse(startValue, out x2);
            //Int32.TryParse(endValue, out y2);
            //for (int i = x2; i <= y2; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine("Even");
            //    if (i % 2 == 1)
            //        Console.WriteLine("Odd");
            //}

            //int x3;
            //int y3;
            //Int32.TryParse(ex.Ask("Enter a start number"), out x3);
            //Int32.TryParse(ex.Ask("Enter an end number"), out y3);
            //while (x3 < y3)
            //{
            //    if (x3 % 3 == 0)
            //        Console.Write("Fizz");
            //    if (x3 % 5 == 0)
            //        Console.Write("Buzz");
            //    if (x3 % 3 != 0 && x3 % 5 != 0)
            //        Console.Write(x3);
            //    Console.WriteLine();
            //    x3++;
            //}

            //string[,] num3 = new string[5, 2] {
            //    { "X", "X"},
            //    { "X", "X"},
            //    { "X", "X"},
            //    { "X", "X"},
            //    { "X", "X"}
            //                                  };
            //for (int row = 0; row < num3.GetLength(0); row++)
            //{
            //    Console.Write("");
            //    for (int col = 0; col < num3.GetLength(1); col++)
            //    {
            //        Console.Write(num3[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            //string[,] num4 = new string[3, 6]
            //{
            //    {"X", "X", "X", "X", "X", "X"},
            //    {"X", "X", "X", "X", "X", "X"},
            //    {"X", "X", "X", "X", "X", "X"}
            //};
            //for (int row = 0; row < num4.GetLength(0); row++)
            //{
            //    Console.Write("");
            //    for (int col = 0; col < num4.GetLength(1); col++)
            //    {
            //        Console.Write(num4[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("I'm going to generate a number between 1 and 10. You have 5 tries to guess it!");
            int numberA = 4;
            int guess;
            for (int i = 1; i < 6; i++)
            {
                int.TryParse(ex.Ask("Round " + i + " - make your guess "), out guess);
                if (guess > numberA)
                    Console.WriteLine("Too high");
                if (guess < numberA)
                    Console.WriteLine("Too low");
                if (guess == numberA)
                {
                    Console.WriteLine("Oh good for you, you got it");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
 