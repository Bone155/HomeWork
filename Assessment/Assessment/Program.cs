using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();
            Opponent opponent = new Opponent();
            Move move = new Move();

            Console.WriteLine("You gotta defeat your opponent in order to win.");
            Console.WriteLine("You have a variety of actions you can do to defeat your opponent.");
            Console.WriteLine("You can punch, jab, side punch, block, and dodge.");
            Console.WriteLine("");
            Console.WriteLine("FIGHT!");
            while (player.health >= 0 && opponent.health >= 0)
            {
                move.Action();

            }

            Console.ReadLine();
        }
    }
}
