using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Game
    {
        public int score = 0;

        public void PrintScore()
        {
            Console.WriteLine("You Scored!");
            Console.WriteLine(AddToScore(5));
            Console.WriteLine(AddToScore(15));
            Console.WriteLine(AddToScore(35));
        }

        public int AddToScore(int add)
        {
            score += add;
            return score;
        }

        public void PrintScore(int add)
        {
            Console.WriteLine("You Scored!");
            Console.WriteLine(AddToScore(add));
            Console.WriteLine(AddToScore(add));
            Console.WriteLine(AddToScore(add));
        }


    }

    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.score = 100;
            game.PrintScore(50);


            Console.ReadLine();
        }
    }
}
