using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueTypes
{
    //Structs contain the actual data.
    struct VTest { public int ITest; }
    //Classes work more like pointers.
    class RTest { public int ITest; }


    class MainClass
    {
        static VTest vt1;
        static RTest rt1;
        static VTest vt2;
        static RTest rt2;

        public static void Main(string[] args)
        {
            testVT();
            testRT();
            Console.ReadKey();
        }

        static void testVT()
        {
            //Test how Structs work
            vt1.ITest = 2;                //Init vt1's ITest Value
            vt2 = vt1;                    //Set vt2 to be the same as vt1
            vt2.ITest = 3;                //set vt2's ITest Value
            Console.WriteLine("vt1= " + vt1.ITest + ",vt2=" + vt2.ITest);
        }
        static void testRT()
        {
            //Test how Classes work
            rt1 = new RTest();            //Init rt1 (Required for Reference types)
            rt1.ITest = 2;                //assign rt1's ITest var
            rt2 = rt1;                    //set rt2 to be the same as rt1
            rt2.ITest = 3;                //set rt2's ITest value
            Console.WriteLine("rt1= " + rt1.ITest + ",rt2=" + rt2.ITest);
        }
    }
}
