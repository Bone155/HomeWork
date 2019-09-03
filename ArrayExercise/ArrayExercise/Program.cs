using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
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
    class Program
    {
        static void Main()
        {
            Q q = new Q();
            int[,] dragons = new int[3, 7];
            int food;
            for (int row = 0; row < dragons.GetLength(0); row++)
            {
                q.Ask("Dragon's name: ");
                for (int col = 0; col < dragons.GetLength(1); col++)
                {
                    int.TryParse(q.Ask("Food eaten on day " + col + ": "), out food);
                    dragons[row, col] = food;
                }
            }
            int average;
            int sum = 0;
            for(int row = 0; row < dragons.GetLength(0); row++)
            {
                for(int col = 0; col < dragons.GetLength(1); col++)
                {
                    sum += dragons[row, col];
                }
            }
            average = sum / 21;
            q.Print("The average amount of food per day is " + average);

            for (int row = 0; row < dragons.GetLength(0); row++)
            {
                sum = 0;
                for (int col = 0; col < dragons.GetLength(1); col++)
                {
                    sum += dragons[row, col];
                }
                average = sum / 7;
                q.Print("The average of food this dragon eats is " + average + " for 7 days");
            }

            int max = 0;
            int dragon = -1;
            int day = -1;
            for (int row = 0; row < dragons.GetLength(0); row++)
            {
                for (int col = 0; col < dragons.GetLength(1); col++)
                {
                    if(max < dragons[row, col])
                    {
                        max = dragons[row, col];
                        dragon = row;
                        day = col;
                    }
                }
            }
            Console.WriteLine("Dragon " + dragon + " ate the most today with a quantity of " + max + " on day " + day);

            int min = int.MaxValue;
            int drag = -1;
            int dy = -1;
            for (int row = 0; row < dragons.GetLength(0); row++)
            {
                for (int col = 0; col < dragons.GetLength(1); col++)
                {
                    if (min > dragons[row, col])
                    {
                        min = dragons[row, col];
                        drag = row;
                        dy = col;
                    }
                }
            }
            Console.WriteLine("Dragon " + drag + " ate the minimum today with a quantity of " + min + " on day " + dy);

            Console.ReadLine();
        }
    }
}
