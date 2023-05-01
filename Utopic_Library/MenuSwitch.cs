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
                    i++;
                    break;

                case "south":
                    int j = 0;
                    Console.WriteLine(World.roomsArray[j]);
                    j--;
                    break;

                case "weapons":
                    foreach (var weapon in World.weaponsArray)
                    {
                        Console.WriteLine(weapon.ToString());
                    }
                    break;

                case "items":
                    foreach (var item in World.itemList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;

                case "treasure":
                    foreach (var treasure in World.treasureArray)
                    {
                        Console.WriteLine(treasure.ToString());
                    }
                    break;

                case "potions":
                    foreach (var potion in World.potionsArray)
                    {
                        Console.WriteLine(potion.ToString());
                    }
                    break;

                case "mobs":
                    foreach (var mob in World.mobList)
                    {
                        Console.WriteLine(mob.ToString());
                    }
                    break;
            }
        }
    }
}
