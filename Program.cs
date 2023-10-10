// See https://aka.ms/new-console-template for more information
using System;


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







        static void Main(string[] args)
        {   
            Random rnd = new Random();
            Console.Title = "YOUR MOTHER";
            Console.ForegroundColor = ConsoleColor.Green;
         
         // figure out character stuff
         
            Console.WriteLine("Your Character's name: \n");
            string? name = Convert.ToString(Console.ReadLine()); // name
            
            Console.WriteLine("\nTap to roll for your strength.\n");
            Console.ReadKey();
            
            int chaStrength = rnd.Next(3, 18); // character strength
            int chaIntel = rnd.Next(3, 18);
            int chaDex = rnd.Next(3, 18);

            int strengthbonus = calc_modifier(chaStrength); // bonus calculated by strength score, intelligence, and dexterity
            int intelbonus = calc_modifier(chaIntel);
            int dexbonus = calc_modifier(chaDex);
            
            
            Console.WriteLine("Your strength is: " + chaStrength + "\nAnd your strength mod is: " + strengthbonus); // display Ability scores and mods.
            Console.WriteLine("Your intelligence is: " + chaIntel + "\nAnd your intelligence mod is: " + intelbonus);
            Console.WriteLine("Your dexterity is: " + chaDex + "\nAnd your dexterity mod is: " + dexbonus);
            Console.ReadKey();

            // start the story
            Console.WriteLine("\n" + name + " wakes up to their annoying alarm clock, as usual \n");
            Console.WriteLine("It seems to be a dull morning today. Something feels wrong in your head , but you push off your worries to the side. \n ");
            
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
            }
            if (decision2 == 2)
            {
                Console.WriteLine("\n Press any key to roll...");
                Console.ReadKey();
                Console.WriteLine("\n Rolling craft (d20)...");
                int rollcraft = rnd.Next(1 , 20);
                Console.WriteLine("\n You rolled a: " + rollcraft);
                Console.ReadKey();

                if (rollcraft == 1)
                {
                    Console.WriteLine("\nAs you search the room, You accidentally slip on a perfectly placed banana peel.");
                    Console.WriteLine("\nTake two damage");
                }
                if (rollcraft == 20)
                {
                    Console.WriteLine("\nAs you search the room, you find a really rusty crowbar under your bed and a very suspicisous banana peel.");
                    // add banana peel and crowbar to inv
                }
                if (rollcraft >= 2 && rollcraft <= 10)
                {
                    Console.WriteLine("\nYou find nothing of real interest.");
                }
                if (rollcraft >= 10 && rollcraft <= 19)
                {
                    Console.WriteLine("\nYou find a really rusty crowbar under your bed.");
                    //add crowbar to inv
                }
            }
            
            
        }
    }
}
