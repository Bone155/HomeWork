using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claming
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int Inp;
            Int32.TryParse(number, out Inp);

            if (Inp < 15)
            {
                Inp = 15;
                Console.WriteLine(Inp);
            }
                
            if (Inp > 30)
            {
                Inp = 30;
                Console.WriteLine(Inp);
            }

            Console.ReadLine();
        }
    }
}
