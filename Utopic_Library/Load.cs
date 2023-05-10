using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public class Load
    {
        public static StreamReader input;

        public static void LoadGame()
        {
            LoadRooms();
            LoadWeapons();
            LoadPotions();
            LoadTreasures();
            LoadItems();
            LoadMobs();
        }
        //public static void LoadRooms()
        //{
        //    int index = 0;
        //    StreamReader input;
        //    input = File.OpenText(@"C:\Users\quayles5806\Source\Repos\Utopic\Utopic_Library\Menu Items\Rooms.csv");

        //    while (index < World.roomsArray.Length && !input.EndOfStream)
        //    {
        //        World.roomsArray[index] = input.ReadLine();
        //        index++;
        //    }

        //    input.Close();

        //}

        //public static void LoadWeapons()
        //{
        //    int index = 0;
        //    StreamReader input;
        //    input = File.OpenText(@"C:\Users\quayles5806\Source\Repos\Utopic\Utopic_Library\Menu Items\Weapons.csv");

        //    while (index < World.weaponsArray.Length && !input.EndOfStream)
        //    {
        //        World.weaponsArray[index] = input.ReadLine();
        //        index++;
        //    }

        //    input.Close();
        //}

        //public static void LoadPotions()
        //{
        //    int index = 0;
        //    StreamReader input;
        //    input = File.OpenText(@"C:\Users\quayles5806\Source\Repos\Utopic\Utopic_Library\Menu Items\Potions.csv");

        //    while (index < World.potionsArray.Length && !input.EndOfStream)
        //    {
        //        World.potionsArray[index] = input.ReadLine();
        //        index++;
        //    }

        //    input.Close();
        //}

        //public static void LoadTreasures()
        //{
        //    int index = 0;
        //    StreamReader input;
        //    input = File.OpenText(@"C:\Users\quayles5806\Source\Repos\Utopic\Utopic_Library\Menu Items\Treasure.csv");

        //    while (index < World.treasureArray.Length && !input.EndOfStream)
        //    {
        //        World.treasureArray[index] = input.ReadLine();
        //        index++;
        //    }

        //    input.Close();
        //}

        //public static void LoadItems()
        //{
        //    int index = 0;
        //    StreamReader input;
        //    input = File.OpenText(@"C:\Users\quayles5806\Source\Repos\Utopic\Utopic_Library\Menu Items\Items.csv");

        //    while (index < World.itemList.Count && !input.EndOfStream)
        //    {
        //        World.itemList.Add(input.ReadLine());
        //    }

        //    input.Close();
        //}

        //public static void LoadMobs()
        //{
        //    StreamReader input;
        //    input = File.OpenText(@"C:\Users\quayles5806\Source\Repos\Utopic\Utopic_Library\Menu Items\Mobs.csv");

        //    while (!input.EndOfStream)
        //    {
        //        World.mobList.Add(input.ReadLine());
        //    }

        //    input.Close();
        //}

        public static void LoadPlayer()
        {
            StreamReader input;
            input = File.OpenText("PlayerInfo.csv");

            while (!input.EndOfStream)
            {
                World.playerInfo.Add(input.ReadLine());
            }

            input.Close();
        }
    }
}
