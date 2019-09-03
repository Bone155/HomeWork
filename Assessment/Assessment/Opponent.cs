using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Opponent
    {
        Random rand = new Random();
        bool hit;
        public int health = 150;
        public bool Punch()
        {
            bool LR;
            int punch = rand.Next(0, 2);
            if (punch == 0)
            {
                LR = true;
            }
            if (punch == 1)
            {
                LR = false;
            }
            if (punch == 0)
            {
                LR = true;
            }
            return LR;
        }

        public bool Jab()
        {
            bool LR;
            int left = rand.Next(0, 1);
            int right = rand.Next(0, 1);
            if (left == 0)
            {
                LR = true;
            }
            if (left == 1)
            {
                LR = false;
            }
            if (right == 0)
            {
                LR = true;
            }
            if (right == 1)
            {
                LR = false;
            }
            return LR;
        }

        public bool SidePunch()
        {
            bool LR;
            int left = rand.Next(0, 1);
            int right = rand.Next(0, 1);
            if (left == 0)
            {
                LR = true;
            }
            if (left == 1)
            {
                LR = false;
            }
            if (right == 0)
            {
                LR = true;
            }
            if (right == 1)
            {
                LR = false;
            }
            return LR;
        }

        public bool Uppercut()
        {
            bool LR;
            int left = rand.Next(0, 1);
            int right = rand.Next(0, 1);
            if (left == 0)
            {
                LR = true;
            }
            if (left == 1)
            {
                LR = false;
            }
            if (right == 0)
            {
                LR = true;
            }
            if (right == 1)
            {
                LR = false;
            }
            return LR;
        }

        public bool Block()
        {
            bool block;
            int b = rand.Next(0, 1);
            if (b == 0)
            {
                block = true;
            }
            if (b == 1)
            {
                block = false;
            }
            return block;
        }

        public bool Dodge()
        {
            bool LRN;
            int dodge = rand.Next(0, 1);
            if (dodge == 0)
            {
                LRN = true;
            }
            if (dodge == 1)
            {
                LRN = false;
            }
            return LRN;
        }
    }
}
