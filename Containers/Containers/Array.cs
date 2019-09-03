using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
{
    class Array
    {
        Qu q = new Qu();
        public void ArrayExample(int size)
        {
            int[] array = new int[size];
            int number;
            foreach (int index in array)
            {
                int.TryParse(q.Ask("Enter a number: "), out number);
                array[index] = number;
                Console.WriteLine(array[index]);
            }
        }
    }
}
