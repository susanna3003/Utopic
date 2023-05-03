using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Utopic_Library;

/**
* 2/22/23
* CSC 153
* Susanna Quayle
* Sprint 1
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo 

            Load.LoadGame();

            MenuSwitch.WelcomeMethod();
            int i = 0;
            bool continueGame = true;

            do
            {
                string userTypes = Console.ReadLine();
                switch (userTypes.ToLower())
                {
                    case "north":
                        i++;
                        Console.WriteLine(World.roomsArray[i]);
                        break;

                    case "south":
                        i--;
                        Console.WriteLine(World.roomsArray[i]);
                        break;

                    case "weapons":
                        for (int read = 0; read < World.weaponsArray.Length; read++)
                        {
                            Console.WriteLine(World.weaponsArray[read]);
                        }
                        break;

                    case "items":
                        for (int read = 0; read < World.itemList.Count; read++)
                        {
                            Console.WriteLine(World.itemList[read]);
                        }
                        break;

                    case "treasure":
                        for (int read = 0; read < World.treasureArray.Length; read++)
                        {
                            Console.WriteLine(World.treasureArray[read]);
                        }
                        break;

                    case "potions":
                        for (int read = 0; read < World.potionsArray.Length; read++)
                        {
                            Console.WriteLine(World.potionsArray[read]);
                        }
                        break;

                    case "mobs":
                        for (int read = 0; read < World.mobList.Count; read++)
                        {
                            Console.WriteLine(World.mobList[read]);
                        }
                        break;

                    case "attack":
                        Combat.CombatMethod();
                        break;

                    case "exit":
                        continueGame = false;
                        break;
                }
            }
            while (continueGame == true);
        }
    }
}
