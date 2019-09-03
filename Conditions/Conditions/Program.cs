using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int num;
            Int32.TryParse(number, out num);
            
            if(num > 50)
            {
                Console.WriteLine("" + number + " is a large number");
            }
            else if(num < 50)
            {
                Console.WriteLine("" + number + " is a small number");
            }
            else
                Console.WriteLine("" + number + " is a balanced number");
            Console.ReadLine();
        }
    }
}
