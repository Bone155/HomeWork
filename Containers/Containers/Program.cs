using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
{
    class Program
    {
        static void Main()
        {
            Array array = new Array();
            array.ArrayExample(5);
            List list = new List();
            list.ListExample();
            Stacks stacks = new Stacks();
            stacks.StackExample();
            Dictionaries dictionary = new Dictionaries();
            dictionary.DictionaryExample();

            Console.ReadLine();
        }
    }
}
