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
            Console.WriteLine("Type attack for combat or EXIT to leave.");
            Console.WriteLine($"You are currently in {World.roomsArray[0]}");
        }
    }
}
