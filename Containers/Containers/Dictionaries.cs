using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
{
    class Dictionaries
    {
        Qu q = new Qu();
        public void DictionaryExample()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(0, "Cat");
            myDictionary.Add(1, "Dog");
            myDictionary[5] = "Bird";
            Console.WriteLine(myDictionary[5]);
        }
    }
}
