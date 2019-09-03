using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
{
    class Qu
    {
        public void Print(string val)
        {
            Console.WriteLine(val);
        }
        public string Ask(string val)
        {
            Console.Write(val);
            return Console.ReadLine();
        }
    }
}
