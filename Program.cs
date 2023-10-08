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
            
            Console.WriteLine("It seems to be a dull morning today. Something nags you in your head, but you push off your worries to the side. \n ");
            
            Console.WriteLine("\n  1. Get out of bed.    2. Wither away.   ");
            
            int decision1 = Convert.ToInt32(Console.ReadLine());
            
            if (decision1 == 1)
            {
                Console.WriteLine("\nYou get out of your bed and find that your room is way colder than it should be. Strange.\n");
                Console.ReadKey();
            }
            if (decision1 == 2)
            {
                Console.WriteLine("\nAs you take your last breaths, you start to realize what a stupid decision you've made.\n\n Press any key to continue. \n");
                Console.ReadKey();
                return;
            }

            Console.WriteLine(" 1. Open your closet.  2. Investigate Your room.(D20) \n");
            int decision2 = Convert.ToInt32(Console.ReadKey());
            if (decision2 == 1)
            {

            }
            if (decision2 == 2)
            {
                Console.WriteLine("wee");
            }

            
        }
    }
}
