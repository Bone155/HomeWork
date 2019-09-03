using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExercise
{
    class Program
    {
        static void Main()
        {
            double playerHealth;
            double monsterHealth = 100;
            playerHealth = 1.00000000001;
            monsterHealth = 100000000000;
            string battleStart = "Fight!";
            string playerHealthText = "PLayer has " + playerHealth + " health";
            string monsterHealthText = "Monster has " + monsterHealth + " health";

            Console.WriteLine(battleStart);
            Console.WriteLine(playerHealthText);
            Console.WriteLine(monsterHealthText);
            Console.ReadLine();

        }
    }
}
