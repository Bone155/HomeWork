using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Player
    {
        public int health = 150;
        public string Punch(string LR)
        {
            if (LR == "left punch")
            {
                LR = "left punch";
            }
            if (LR == "right punch")
            {
                LR = "right punch";
            }
            return LR;
        }

        public string Jab(string LR)
        {
            if (LR == "left jab")
            {
                LR = "left jab";
            }
            if (LR == "right jab")
            {
                LR = "right jab";
            }
            return LR;
        }

        public string SidePunch(string LR)
        {
            if (LR == "left side punch")
            {
                LR = "left side punch";
            }
            if (LR == "right side punch")
            {
                LR = "right side punch";
            }
            return LR;
        }

        public string Uppercut(string LR)
        {
            if (LR == "left uppercut")
            {
                LR = "left uppercut";
            }
            if (LR == "right uppercut")
            {
                LR = "right uppercut";
            }
            return LR;
        }

        public string Block(string block)
        {
            if (block == "block")
            {
                block = "block";
                return block;
            }
            return block;
        }

        public string Dodge(string LR)
        {
            if (LR == "dodge left")
            {
                LR = "dodge left";
            }
            if (LR == "dodge right")
            {
                LR = "dodge right";
            }
            return LR;
        }
    }
}
