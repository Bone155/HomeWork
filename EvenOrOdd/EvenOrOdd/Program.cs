using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int Inp;
            Int32.TryParse(number, out Inp);
            if (Inp % 2 == 0)
                Console.WriteLine("Output: Even");
            if (Inp % 2 == 1)
                Console.WriteLine("Output: Odd");
            
            Console.ReadLine();
        }
    }
}
