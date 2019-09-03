using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Containers
{
    class List
    {
        Qu q = new Qu();

        public void ListExample()
        {
            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList.Add(2);
            myList.Add(9);
            myList.Remove(4);
            myList.Remove(5);
            myList.Sort();
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
