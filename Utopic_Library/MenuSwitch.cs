using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopic_Library
{
    public static class MenuSwitch
    {
        //TO DO switch statement to take "north", "south", "weapons", etc commands and call proper methods
        public static void WelcomeMethod()
        {
            Console.WriteLine("Welcome to Utopic!");
            Console.WriteLine("Type North or South to begin your journey.");
            Console.WriteLine("Type Weapons, Items, Treasure, Potions, or Mobs to see the list for each.");
            string userTypes = Console.ReadLine();
            Console.ReadLine();
            switch (userTypes)
            {
                case "north":
                    int i = 0;
                    Console.WriteLine(World.roomsArray[i]);
                    Console.ReadLine();
                    i++;
                    break;

                case "south":
                    int j = 0;
                    Console.WriteLine(World.roomsArray[j]);
                    Console.ReadLine();
                    j--;
                    break;

                case "weapons":
                    for (int read = 0; read < World.weaponsArray.Length; read++)
                    {
                        Console.WriteLine(World.weaponsArray[1]);
                        Console.ReadLine();
                    }
                    break;

                case "items":
                    for (int read = 0; read < World.itemList.Count; read++)
                    {
                        Console.WriteLine(World.itemList[read]);
                        Console.ReadLine();
                    }
                    break;

                case "treasure":
                    for (int read = 0; read < World.treasureArray.Length; read++)
                    {
                        Console.WriteLine(World.treasureArray[read]);
                        Console.ReadLine();
                    }
                    break;

                case "potions":
                    for (int read = 0; read < World.potionsArray.Length; read++)
                    {
                        Console.WriteLine(World.potionsArray[read]);
                        Console.ReadLine();
                    }
                    break;

                case "mobs":
                    for (int read = 0; read < World.mobList.Count; read++)
                    {
                        Console.WriteLine(World.mobList[read]);
                        Console.ReadLine();
                    }
                    break;
            }
        }
    }
}
