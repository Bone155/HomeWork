using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablePractice
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello, user! Lets get ready to rumble! ";
            string teammate = "Did the opposing team forfiet the game before it even started";
            string you = "Yep";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;

            Console.WriteLine(displayGameState);
            Console.WriteLine(teammate);
            Console.WriteLine(you);
            Console.ReadKey();

        }
    }
}
