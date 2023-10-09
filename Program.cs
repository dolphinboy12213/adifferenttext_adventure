// See https://aka.ms/new-console-template for more information
using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random rnd = new Random();
            Console.Title = "YOUR MOTHER";
            Console.ForegroundColor = ConsoleColor.Green;
         
         // figure out character stuff
         
            Console.WriteLine("Your Character's name: \n");
            string? name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nTap to roll for your strength.\n");
            Console.ReadKey();
            int chastrength = rnd.Next(3, 18);
            int strengthbonus;
            if (chastrength <= 6)
            {
                strengthbonus = 1;
            }
            if (chastrength >= 6 && chastrength <= 10)
            {
                strengthbonus = 2;
            }
            if (chastrength >= 10 && chastrength <= 13)
            {
                strengthbonus = 3;
            }
            else 
            {
                strengthbonus = 4;
            }
            Console.WriteLine("Your strength is: \n" + chastrength + "\nAnd your strength mod is:\n" + strengthbonus);

            Console.WriteLine("\n" + name + " wakes up to an annoying alarm clock.  \n");
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
