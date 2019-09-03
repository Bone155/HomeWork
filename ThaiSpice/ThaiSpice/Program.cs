using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiSpice
{
    class Exercies
    {
        public void Thai()
        {
             int thaiSpiceRating = 0;

            Console.WriteLine("How spicy should your food be?\n");
            thaiSpiceRating = Int32.Parse(Console.ReadLine());

            if (thaiSpiceRating > 5)
            {
                thaiSpiceRating = 5;
            }
            else if (thaiSpiceRating < 0)
            {
                thaiSpiceRating = 0;
            }
            Console.WriteLine("You ordered with a spiciness rating of " + thaiSpiceRating.ToString());
        }
        
        public void Cookies()
        {
            int cookies = 0;
            Console.WriteLine("How many cookies would you like?");
            cookies = Int32.Parse(Console.ReadLine());

            cookies /= 23;
            Console.WriteLine(cookies);
            
        }

        public void Sketch()
        {
            int sketchbook = 0;
            Console.WriteLine("How many sketchbooks would you like?");
            sketchbook = Int32.Parse(Console.ReadLine());

            if (sketchbook < 9 || sketchbook > 30)
                Console.WriteLine("Error");
            else
                Console.WriteLine(sketchbook);
        }

        public void Blur()
        {
            string yn = Console.ReadLine();
            if (yn.Equals('y'))
                Console.WriteLine("y");
            if (yn.Equals('n'))
                Console.WriteLine("n");
            else
                Console.WriteLine("Error");
        }
    }

    class Program
    {
        static void Main()
        {
            Exercies spice = new Exercies();
            spice.Thai();

            spice.Cookies();

            spice.Sketch();

            spice.Blur();

            Console.ReadLine();
        }
    }
}
