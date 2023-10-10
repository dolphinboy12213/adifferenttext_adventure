// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {   
        static int calc_modifier(int ability_score)
        {   // to find bonus mod. for a ability score
            int modifier;

            if (ability_score <= 6)
            {
                modifier = 1;
            }
            else if (ability_score >= 6 && ability_score <= 10)
            {
                modifier = 2;
            }
            else if (ability_score >= 10 && ability_score <= 13)
            {
                modifier = 3;
            }
            else 
            {
                modifier = 4;
            }

           return modifier;
            
        }



        static int calc_maxhealth(int Strength, int Dexterity){
            int maxhealth = (2 * Strength) + (2 * Dexterity);
            return maxhealth;
        }



        static void Main(string[] args)
        {   
            string[] inventory = new string[4];
            Random rnd = new Random();
            Console.Title = "YOUR MOTHER";
            Console.ForegroundColor = ConsoleColor.Green;
         
         // figure out character stuff
         
            Console.WriteLine("Your Character's name: \n");
            string? name = Convert.ToString(Console.ReadLine()); // name
            
            Console.WriteLine("\nTap to roll for " +name+ "'s stats \n");
            Console.ReadKey();
            int[] statroll = new int[3];
            for(int i = 0; i < 3; i++)
            {
                 statroll[i] = rnd.Next(1,6) + rnd.Next(1,6) + rnd.Next(1,6);
            }

            int chaStrength = statroll[0]; // character strength
            int chaIntel = statroll[1]; // character intelligence
            int chaDex = statroll[2]; // character dexterity

            int strengthbonus = calc_modifier(chaStrength); // bonus calculated by strength, intelligence, and dexterity score.
            int intelbonus = calc_modifier(chaIntel);
            int dexbonus = calc_modifier(chaDex);
            
            int Maxhealth = calc_maxhealth(chaStrength, chaDex);
            
            Console.WriteLine("\nYour strength is: " + chaStrength + "\n\nAnd your strength mod is: +" + strengthbonus); // display Ability scores and mods.
            Console.WriteLine("\nYour intelligence is: " + chaIntel + "\n\nAnd your intelligence mod is: +" + intelbonus);
            Console.WriteLine("\nYour dexterity is: " + chaDex + "\n\nAnd your dexterity mod is: +" + dexbonus);
            Console.WriteLine("\nYour total health is: " + Maxhealth);
            Console.WriteLine("\nPress any key to Continue");
            Console.ReadKey();

            Console.Clear();

            // start the story
            Console.WriteLine("\n" + name + " wakes up to the same annoying alarm clock, as usual.\n");
            Console.WriteLine("It seems to be another dull morning today. Something feels wrong in your head , but you push off your worries to the side. \n ");
            
            Console.WriteLine("\n  1. Get out of bed.    2. Go back to sleep.   \n");
            
            int decision1 = Convert.ToInt32(Console.ReadLine());
            
            
            
            if (decision1 == 1)
            {
                Console.WriteLine("\nYou get out of your bed and find that your room is way colder than it should be. Strange.\n");
                Console.ReadKey();
            }
            if (decision1 == 2)
            {
                Console.WriteLine("\nYou pass out and suffocate on your pillow.\n\n Press any key to continue. \n");
                Console.ReadKey();
                return;
            }

            Console.WriteLine(" 1. Open your closet.  2. Investigate Your room.(D20) \n");
            int decision2 = Convert.ToInt32(Console.ReadLine());
            if (decision2 == 1)
            {
                Console.WriteLine("\nYou open your closet and get dressed for the day ahead.");
                inventory[0] = "Common Clothes";
                Console.WriteLine("You have picked up: Common Clothes.\n\n Inventory:");
                foreach (string item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
            if (decision2 == 2)
            {
                Console.WriteLine("\n Press any key to roll...");
                Console.ReadKey();
                Console.WriteLine("\n Rolling craft (d20)...");
                int rollIntel = rnd.Next(1 , 20);
                Console.WriteLine("\n You rolled a: " + (rollIntel + intelbonus) + "(" + rollIntel + "+" + intelbonus + ")");
                Console.ReadKey();

                if (rollIntel == 1)
                {
                    Console.WriteLine("\nAs you search the room, You accidentally slip on a perfectly placed banana peel.");
                    Console.WriteLine("\nTake two damage");
                }
                else if (rollIntel == 20)
                {
                    Console.WriteLine("\nAs you search the room, you find a really rusty crowbar under your bed and a very suspicisous banana peel.");
                    Console.WriteLine("Pickup crowbar? (y/n)");
                    string? i = Console.ReadLine();
                    if (i == "y")
                    {
                         Console.WriteLine("You have picked up: Rusty Crowbar.");
                         inventory[1] = "Rusty Crowbar";
                    }
                    Console.WriteLine("Pickup Banana Peel? (y/n)");
                    string? ii = Console.ReadLine();
                    if (ii == "y")
                    {
                        Console.WriteLine("You have picked up: Banana Peel");
                        inventory[2] = "Banana Peel";
                    }
                    Console.WriteLine("\n\n Inventory:");
                    foreach (string item in inventory)
                    {
                         Console.WriteLine(item);
                    }

                }
                else if (rollIntel >= 2 && rollIntel <= 10)
                {
                    Console.WriteLine("\nYou find nothing of real interest.");
                }
                else if (rollIntel >= 10 && rollIntel <= 19)
                {
                    Console.WriteLine("\nYou find a really rusty crowbar under your bed.");
                    Console.WriteLine("Pickup crowbar? (y/n)");
                    string? i = Console.ReadLine();
                    if (i == "y")
                    {
                         Console.WriteLine("You have picked up: Rusty Crowbar. \n\nInventory: ");
                         inventory[1] = "Rusty Crowbar";
                         foreach(string item in inventory)
                         {
                            Console.WriteLine(item);
                         }
                    }
                }
            }
            
            
        }
    }
}
