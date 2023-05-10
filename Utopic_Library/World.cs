using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public static class World
    {
        public static string[] roomsArray = new string[5];
        public static string[] weaponsArray = new string[5];
        public static string[] potionsArray = new string[2];
        public static string[] treasureArray = new string[3];

        public static List<string> utopicRaces = new List<string>() { "Human", "Elf", "Sea Walker", "Goblin", "Dwarf", "Flight", "Elven Halfling" };
        public static List<string> utopicClasses = new List<string>() { "Architect", "Scientist", "Scholar", "Witch", "Warrior", "Rover" };

        public static List<Player> players = new List<Player>();
        public static List<Mobs> mobs = new List<Mobs>();
        public static List<Rooms> rooms = new List<Rooms>();
        public static List<Potions> potions = new List<Potions>();
        public static List<Weapons> weapons = new List<Weapons>();
        public static List<Item> items = new List<Item>();
        public static List<Treasure> treasure = new List<Treasure>();



        public static List<string> playerInfo = new List<string>();

    }
}
