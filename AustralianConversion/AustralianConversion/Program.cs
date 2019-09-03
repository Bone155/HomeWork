using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustralianConversion
{

    public class Money
    {
        public float aud;
        public float usd;


        public float Usd
        {
            set
            {
                aud = 1 / 2 * value;
            }

            get
            {
                return (1f / .68f) * aud;
            }

        }



        class Program
        {
            static void Main(string[] args)
            {
                Money myMoney = new Money();
                myMoney.aud = 40;
                Console.WriteLine(myMoney.aud);
                Console.WriteLine(myMoney.usd);
            }
        }
    }
}
