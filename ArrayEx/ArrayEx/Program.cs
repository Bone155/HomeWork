using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx
{
    class Q
    {
        public void Print(string val)
        {
            Console.WriteLine(val);
        }
        public string Ask(string val)
        {
            Console.Write(val);
            return Console.ReadLine();
        }
    }
    class Exercise
    {
        Q q = new Q();
        public void Five(int[] num)
        {
            int max = 0;
            int min = int.MaxValue;
            for(int i = 0; i < num.Length; i++)
            {
                int.TryParse(q.Ask("Enter a number"), out num[i]);
                if (max < num[i])
                {
                    max = num[i];
                }
                if (min > num[i])
                {
                    min = num[i];
                }
            }
            q.Print("The largest value is " + max + " and the smallest value is " + min);
        }

        public void Six(int[,] num)
        {
            int number;
            for(int row = 0; row < num.GetLength(0); row++)
            {
                for(int col = 0; col < num.GetLength(1); col++)
                {
                    int.TryParse(q.Ask("Enter a number"), out number);
                    num[row, col] = number;
                }
            }
            for(int row = 0; row < num.GetLength(0); row++)
            {
                for(int col = 0; col < num.GetLength(1); col++)
                {
                    Console.Write(num[row, col]);
                    Console.WriteLine();
                }
            }
        }

        public void Seven(int[,] num)
        {
            int number;
            int sum = 0;
            for (int row = 0; row < num.GetLength(0); row++)
            {
                for (int col = 0; col < num.GetLength(1); col++)
                {
                    int.TryParse(q.Ask("Enter a number "), out number);
                    num[row, col] = number;
                }
            }
            for (int row = 0; row < num.GetLength(0); row++)
            {
                for (int col = 0; col < num.GetLength(1); col++)
                {
                    sum += num[row, col];
                }
                q.Print("The sum of row is: " + sum);
                sum = 0;
            }
            for (int col = 0; col < num.GetLength(1); col++)
            {
                for (int row = 0; row < num.GetLength(0); row++)
                {
                    sum += num[row, col];
                }
                q.Print("The sum of column is: " + sum);
                sum = 0;
            }
        }

        public void Eight(int[] num)
        {
            int character;
            int attack = 40;
            for ( int round = 0; round < 5; round++)
             {
                int.TryParse(q.Ask("Attack character "), out character);
                int health = num[character];
                if (health <= 0)
                {
                    Console.WriteLine("Character " + character + " is dead");
                }
                else
                {
                    health -= attack;
                    Console.WriteLine("Successful hit. Character " + character + " now has " + health + " health");
                    num[character] = health;
                }
            }
            for(int i = 0; i < num.Length; i++)
            {
                if(num[i] >= 0)
                {
                    Console.WriteLine("Character " + i + " has " + num[i] + " health");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Q q = new Q();
            Exercise ex = new Exercise();
            int[] num = new int[10];
            int[,] numa = new int[3,3];
            int[,] numb = new int[29, 5];
            int[] numc = new int[5] { 100, 100, 100, 100, 100};
            ex.Five(num);
            //ex.Six(numa);
            //ex.Seven(numb);
            //ex.Eight(numc);

            Console.ReadLine();            
        }
    }
}
