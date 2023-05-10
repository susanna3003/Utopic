using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public class Player
    {
        //TODO create object, read from player csv file
        //Player player = new Player();

        public static string GetPlayerName()
        {
            Console.WriteLine("What is your name great traveler?");
            string playerName = Console.ReadLine();
            return playerName;
        }

        public static string GetPlayerPass()
        {
            Console.WriteLine("Make yourself a password - it must have 1 Capital Letter, 1 lowercase letter, and 1 special character.");
            string playerPasswrd = Console.ReadLine();
            return playerPasswrd;
        }

        public static string GetPlayerRace()
        {
            Console.WriteLine("Now, to choose your race. Would you like to see a list of races? Y/N");
            string playerSays = Console.ReadLine();

            for (int i = 0; i < World.utopicRaces.Count; i++)
            {
                Console.WriteLine(World.utopicRaces[i]);
            }

            Console.WriteLine("If you have chosen your race, please type it below.");
            string playerRace = Console.ReadLine();
            return playerRace;
        }

        public static string GetPlayerClass()
        {
            Console.WriteLine("Now choose a class. To see a list of classes type CLASSES");
            string playerClass = Console.ReadLine();

            for (int i = 0; i < World.utopicClasses.Count; i++)
            {
                Console.WriteLine(World.utopicClasses[i]);
            }

            return playerClass;
        }
    }
}
