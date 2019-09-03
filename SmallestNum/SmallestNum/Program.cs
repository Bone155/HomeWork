using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            string number3 = Console.ReadLine();
            string Inp1 = number1;
            string Inp2 = number2;
            string Inp3 = number3;
            int num1;
            int num2;
            int num3;
            Int32.TryParse(Inp1, out num1);
            Int32.TryParse(Inp2, out num2);
            Int32.TryParse(Inp3, out num3);

            if (num1 < num2 && num1 < num3)
                Console.WriteLine(num1);
            else if (num2 < num1 && num2 < num3)
                Console.WriteLine(num2);
            else
                Console.WriteLine(num3);

            Console.ReadLine();
        }
    }
}
