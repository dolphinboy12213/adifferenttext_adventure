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
            
            Console.WriteLine(" _|_|_|                                          _|                _|_|_|_|_|                      _|            _|_|          _|                                    _|                                    
_|          _|_|    _|_|_|      _|_|    _|  _|_|        _|_|_|          _|      _|_|    _|    _|  _|_|_|_|      _|    _|    _|_|_|  _|      _|    _|_|    _|_|_|    _|_|_|_|  _|    _|  _|  _|_|    _|_|    
_|  _|_|  _|_|_|_|  _|    _|  _|_|_|_|  _|_|      _|  _|                _|    _|_|_|_|    _|_|      _|          _|_|_|_|  _|    _|  _|      _|  _|_|_|_|  _|    _|    _|      _|    _|  _|_|      _|_|_|_|  
_|    _|  _|        _|    _|  _|        _|        _|  _|                _|    _|        _|    _|    _|          _|    _|  _|    _|    _|  _|    _|        _|    _|    _|      _|    _|  _|        _|        
  _|_|_|    _|_|_|  _|    _|    _|_|_|  _|        _|    _|_|_|          _|      _|_|_|  _|    _|      _|_| 
                                                                                                                                                                                        
            
            Console.WriteLine("\nYou wake up.\n");
            Console.WriteLine("It seems to be a dull morning today. Something nags you in your head, but you push off your worries to the side. \n ");
            
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
                int craft = rnd.Next(1 , 20);
                Console.WriteLine("\n You rolled a: " + craft);
                Console.ReadKey();

                if (craft == 1)
                {
                    Console.WriteLine("\nAs you search the room, You accidentally slip on a perfectly placed banana peel.");
                    Console.WriteLine("\nTake two damage");
                }
                if (craft == 20)
                {
                    Console.WriteLine("\nAs you search the room, you find a really rusty crowbar under your bed and a very suspicisous banana peel.");
                    // add banana peel and crowbar to inv
                }
                if (craft >= 2 && craft <= 10)
                {
                    Console.WriteLine("\nYou find nothing of real interest.");
                }
                if (craft >= 10 && craft <= 19)
                {
                    Console.WriteLine("\nYou find a really rusty crowbar under your bed.");
                    //add crowbar to inv
                }
            }

            
        }
    }
}
