// See https://aka.ms/new-console-template for more information
using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "YOUR MOTHER";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It seems to be a dull day today. You have two options.");
            Console.WriteLine("\n  1. Search your room.    2. Wither away.   ");
            int decision1 = Convert.ToInt32(Console.ReadLine());
            
            if (decision1 == 1)
            {
                Console.WriteLine("\nYou get out of your bed and find\n");
            }
            if (decision1 == 2)
            {
                Console.WriteLine("\nAs you take your last breaths, you start to realize what a stupid decision you've made.\n\n Press any key to continue. \n");
                Console.ReadKey();
                return;
            }
        }
    }
}
