using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvEx
{
    class Television
    {
            private int currentChannel;
            private int currentVolume;

            // increases the volume by one
            public void IncreaseVolume()
            {
                Console.WriteLine(currentVolume++);
            }

            // decreases the volume by one
            public void DecreaseVolume()
            {
                Console.WriteLine(currentVolume--);
            }

            // // returns the current volume
            public int Volume()
            {
                return currentVolume;
            }

            // increases the channel num by one
            public void IncreaseChannel()
            {
                Console.WriteLine(currentChannel++);
            }

            // decreases the channel num by one
            public void DecreaseChannel()
            {
                Console.WriteLine(currentChannel--);
            }

            // returns the current channel
            public int Channel()
            {
                return currentChannel;
            }
        
    }

    class Program
    {
        static void Main()
        {
            Television myTv = new Television();
            Console.WriteLine("The current channel is " + myTv.Channel());
            myTv.IncreaseChannel();
            Console.WriteLine("The current channel is " + myTv.Channel());

            Console.ReadLine();
        }
    }
    
    
    
}
