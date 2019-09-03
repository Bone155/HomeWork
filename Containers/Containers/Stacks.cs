using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
{
    class Stacks
    {
        Qu q = new Qu();
        public void StackExample()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(3);
            myStack.Push(1);
            Console.WriteLine(myStack.Pop());
            myStack.Push(2);
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
