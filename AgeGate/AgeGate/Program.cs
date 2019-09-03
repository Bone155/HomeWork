using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int old;
            Int32.TryParse(age, out old);

            if (old < 18)
                Console.WriteLine("You are a minor.");
            else if (old >= 18 && old <= 49)
                Console.WriteLine("You are an adult.");
            else if (old >= 50 && old <= 64)
                Console.WriteLine("You are eligible to join AARP.");
            else
                Console.WriteLine("You are eligible for retirment.");

            Console.ReadLine();
        }
    }
}
