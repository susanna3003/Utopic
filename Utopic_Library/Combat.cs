using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public static class Combat
    {
        public static void CombatMethod()
        {
            //Create random object
            Random rand = new Random();
            int playerAttack = rand.Next(10, 21);
            int mobAttack = rand.Next(10, 21);
            int playerHP = 50, mobHP = 50;

            //String damage = "1D8";
            //Char[] delim = { 'D' };
            //string[] tokenDamage = damage.Split(delim);

            bool ifCombat = false;
            bool endCombat = true;
            string userAns;
            Console.WriteLine("A deadly enemy approaches!");
            Console.WriteLine("Will you go into combat? Y/N");
            userAns = Console.ReadLine();

            switch (userAns)
            {
                case "Y":
                    ifCombat = true;
                    break;

                case "N":
                    endCombat = true;
                    break;

                case "y":
                    ifCombat = true;
                    break;

                case "n":
                    endCombat = true;
                    break;
            }


            int mobLevel = rand.Next(1, 6); // will later define mobLevels for each mob but as of now just generating rand level
            int lucky = rand.Next(0, 2); // determines if command goes in player's favor - 0 == player's luck, 1 == mob's luck - FIGURE OUT HOW TO REGENERATE LUCKY ON EACH TURN

            do
            {
                Console.WriteLine("Your opponent is a level " + mobLevel + " which is the number of rounds it will take to end the battle!");
                Console.WriteLine("Available commands: S - strike, B - block, F - flee");
                string combatCommand = Console.ReadLine();

                for (int i = 0; i < mobLevel; i++) //create mobLevel to control length of battle (higher level mob --> longer battle)
                {
                    lucky = rand.Next(0, 2);
                    playerAttack = rand.Next(10, 21);
                    mobAttack = rand.Next(10, 21);

                    if (combatCommand == "S" && lucky == 0)
                    {
                        mobHP -= playerAttack;
                        Console.WriteLine("Succesful strike!");
                        Console.WriteLine("You dealt " + playerAttack + " damage!");
                        Console.ReadLine();
                    }
                    else if (combatCommand == "S" && lucky == 1)
                    {
                        playerHP -= mobAttack;
                        Console.WriteLine("You've been damaged!");
                        Console.ReadLine();
                    }
                    else if (combatCommand == "B" && lucky == 0)
                    {
                        Console.WriteLine("(MOBTYPE)'s attack has been blocked!");
                        Console.ReadLine();
                    }
                    else
                    {
                        playerHP -= mobAttack;
                        Console.WriteLine("(MOBTYPE) evaded your block and damaged you!");
                        Console.ReadLine();
                    }
                }

                if (combatCommand == "F" && lucky == 0)
                {
                    Console.WriteLine("You've fled the battle!");
                    Console.ReadLine();
                    ifCombat = false;
                }
                else if (combatCommand == "F" && lucky == 1)
                {
                    playerHP -= mobAttack;
                    Console.WriteLine("You fled the battle but (MOBTYPE) got one last strike in!");
                    Console.ReadLine();
                    ifCombat = false;
                }
                else if (playerHP > mobHP)
                {
                    Console.WriteLine("You have won the battle!");
                    Console.WriteLine("PlayerHP: " + playerHP + " MobHP: " + mobHP);
                    Console.ReadLine();
                    ifCombat = false;
                }
                else
                {
                    Console.WriteLine("You have lost the battle! Better luck next time!");
                    Console.WriteLine("PlayerHP: " + playerHP + " MobHP: " + mobHP);
                    Console.ReadLine();
                    ifCombat = false;
                }
            }
            while (ifCombat == true);

            do
            {
                Console.WriteLine("Very well, perhaps the next battle shall be yours.");
                Console.ReadLine();
            }
            while (endCombat = true);

        }
    }
}
