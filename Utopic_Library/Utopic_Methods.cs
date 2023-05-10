using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utopic_Library
{
    public class Utopic_Methods
    {
        public static void GetPlayerName()
        {
            Console.WriteLine("What is your name great traveler?");
            World.players[0].PlayerName = Console.ReadLine();
            GetPlayerPass();
        }

        public static void GetPlayerPass()
        {
            Console.WriteLine("Make yourself a password - it must have 1 Capital Letter, 1 lowercase letter, and 1 special character.");
            World.players[0].PlayerPasswrd = Console.ReadLine();
            GetPlayerRace();
        }

        public static void GetPlayerRace()
        {
            Console.WriteLine("Now, to choose your race. A list of races is displayed below.");

            for (int i = 0; i < World.utopicRaces.Count; i++)
            {
                Console.WriteLine(World.utopicRaces[i]);
            }

            Console.WriteLine("If you have chosen your race, please type it below.");
            World.players[0].PlayerRace = Console.ReadLine();
            GetPlayerClass();
        }

        public static void GetPlayerClass()
        {
            Console.WriteLine("Now choose a class. A list of classes is displayed below.");

            for (int i = 0; i < World.utopicClasses.Count; i++)
            {
                Console.WriteLine(World.utopicClasses[i]);
            }
            Console.WriteLine("If you have chosen your class, please type it below");
            World.players[0].PlayerClass = Console.ReadLine();
        }

    }
}
