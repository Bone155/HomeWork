using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankEx
{
    class DigitalPiggyBank
    {
        private float currentBalance;
        public void Deposit(float net)
        {
            Console.WriteLine(currentBalance += net);
        }

        public float Withdraw()
        {
            return currentBalance -= currentBalance;
        }

        public float Balance()
        {
            return currentBalance;
        }
    }

    class Program
    {
        static void Main()
        {
            DigitalPiggyBank dpb = new DigitalPiggyBank();
            dpb.Deposit(50);
            Console.WriteLine(dpb.Balance());
            dpb.Deposit(75);
            Console.WriteLine(dpb.Balance());
            float cashInHand = dpb.Withdraw();
            Console.WriteLine(cashInHand);
            Console.ReadKey();
        }
    }
}
