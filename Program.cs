// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


string[] inventory = new string[4];
int inventory_spaces = 0;
Random rnd = new Random();
Console.Title = "YOUR MOTHER";
Console.ForegroundColor = ConsoleColor.Green;
int narratorInsanity = 0;

// figure out character stuff

Console.WriteLine("Your Character's name: \n");
string? name = Convert.ToString(Console.ReadLine()); // name

Console.WriteLine("\nTap to roll for " + name + "'s stats \n");
Console.ReadKey();
int[] statroll = new int[3];
for (int i = 0; i < 3; i++)
{
    statroll[i] = rnd.Next(1, 6) + rnd.Next(1, 6) + rnd.Next(1, 6);
}

int chaStrength = statroll[0]; // character strength
int chaIntel = statroll[1]; // character intelligence
int chaDex = statroll[2]; // character dexterity

int strengthbonus = calc_modifier(chaStrength); // bonus calculated by strength, intelligence, and dexterity score.
int intelbonus = calc_modifier(chaIntel);
int dexbonus = calc_modifier(chaDex);

int Maxhealth = calc_maxhealth(chaStrength, chaDex);
int currentHealth = Maxhealth;
string clothes = "nothing";

Console.WriteLine("\nYour strength is: " + chaStrength + "\nAnd your strength mod is: +" + strengthbonus); // display Ability scores and mods.
Console.WriteLine("\nYour intelligence is: " + chaIntel + "\nAnd your intelligence mod is: +" + intelbonus);
Console.WriteLine("\nYour dexterity is: " + chaDex + "\nAnd your dexterity mod is: +" + dexbonus);
Console.WriteLine("\nYour total health is: " + Maxhealth);
Console.WriteLine("\nPress any key to Continue");
Console.ReadKey();

Console.Clear();

// start the story
Console.WriteLine("\n" + name + " wakes up to the same annoying alarm clock, as usual.\n");
Console.WriteLine("It seems to be another dull morning today. Something feels wrong in your head ,but you push off your worries to the side. \n ");

Console.WriteLine("\n  1. Get out of bed.    2. Go back to sleep.   \n");

int decision1 = Convert.ToInt32(Console.ReadLine());



if (decision1 == 1)
{
    Console.WriteLine("\nYou get out of your bed and find that your room is way colder than it should be. Strange.\n");
    Console.ReadKey();
}
if (decision1 == 2)
{
    int i = rnd.Next(1, 5);

    if (i == 1 || i == 2)
    {
        Console.WriteLine("\nYou pass out and suffocate on your pillow.\n\n Press Y to end the game \n");
        string? s = Console.ReadLine();

        if (s == "y" || s == "Y")
        {
            return;
        }
        else
        {
            Console.WriteLine("Can you seriously not follow simple instructions?");
            int ii = rnd.Next(1, 4);

            if (ii <= 3)
            {
                Console.ReadKey();
                return;
            }
            else if (ii == 4)
            {
                Console.ReadKey();
                Console.WriteLine("Fine, I'll give you one more chance. but don't pull more shit on me.\n");
                Console.WriteLine("YOU'VE BEEN WARNED");
                narratorInsanity++;
            }

        }
    }
    else if (i >= 3)
    {
        Console.WriteLine("You wake up a bit later feeling a bit more refreshed");
    }
}
Console.Clear();
Console.WriteLine(" 1. Open your closet.  2. Investigate Your room.(D20) \n");
int decision2 = Convert.ToInt32(Console.ReadLine());
if (decision2 == 1)
{
    Console.WriteLine("\nYou open your closet and get dressed for the day ahead.");
    clothes = "Common Clothes";
    Console.WriteLine("\nNow wearing: " + clothes);
}
else if (decision2 == 2)
{
    Console.WriteLine("\n Press any key to roll...");
    Console.ReadKey();
    Console.WriteLine("\n Rolling intelligence (d20)...");
    int rollIntel = rnd.Next(1, 20);
    Console.WriteLine("\n You rolled a: " + (rollIntel + intelbonus) + "(" + rollIntel + " + " + intelbonus + ")");
    Console.ReadKey();

    if (rollIntel == 1)
    {
        Console.WriteLine("\nAs you search the room, You accidentally slip on a perfectly placed banana peel.");
        Console.WriteLine("\nTake twelve damage");
        currentHealth = currentHealth - 12;
        Console.WriteLine("HP: " + currentHealth + "/" + Maxhealth);

    }
    else if (rollIntel == 20)
    {
        Console.WriteLine("\nAs you search the room, you find a really rusty crowbar under your bed and a very suspicisous banana peel.");
        Console.WriteLine("Pickup crowbar? (y/n)");
        string? i = Console.ReadLine();
        if (i == "y")
        {
            Console.WriteLine("You have picked up: Rusty Crowbar.");
            inventory[inventory_spaces] = "Rusty Crowbar";
            inventory_spaces++;
        }
        Console.WriteLine("Pickup Banana Peel? (y/n)");
        string? ii = Console.ReadLine();
        if (ii == "y")
        {
            Console.WriteLine("You have picked up: Banana Peel");
            inventory[inventory_spaces] = "Banana Peel";
            inventory_spaces++;
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
        if (i == "y" || i == "Y")
        {
            Console.WriteLine("You have picked up: Rusty Crowbar. \n\nInventory: ");
            inventory[inventory_spaces] = "Rusty Crowbar";
            inventory_spaces++;
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }
        }

    }
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("1. Open your closet.  2. Go to the hallway.");
    string? inside_decision2 = Console.ReadLine();

    if (inside_decision2 == "1")
    {
        Console.WriteLine("You open your closet and get dressed for the day ahead.\n");
        clothes = "Common Clothes";
        Console.WriteLine("You are now wearing: " + clothes + "\n");
        Console.WriteLine("Press any key...");
        Console.ReadKey();

    }
    else if (inside_decision2 == "2")
    {
        Console.WriteLine("Press any key...");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Fuck you.");
    }

}

Console.Clear();

Console.WriteLine("As " + name + " walks out of their room, they hear a big crash, straight ahead, in the living room. \n");
Console.ReadKey();
Console.Clear();
Console.WriteLine("1. Go to the living room.  2. Go to the Laundry Room. 3. Equip an item.\n");

int calc_modifier(int ability_score)
{
    int ability_mod = 0;
    if (ability_score >= 3 && ability_score <= 5)
    {
        ability_mod = 1;
    }
    else if (ability_score >= 6 && ability_score <= 8)
    {
        ability_mod = 2;
    }
    else if (ability_score >= 9 && ability_score <= 13)
    {
        ability_mod = 3;
    }
    else if (ability_score >= 14 && ability_score <= 16)
    {
        ability_mod = 4;
    }
    else if (ability_score >= 17 && ability_score <= 18)
    {
        ability_mod = 5;
    }
    return ability_mod;

}

int calc_maxhealth(int strength, int dex)
{
    int Maxhealth = (int)Math.Round((strength * 1.5) + (dex * 1.2));
    return Maxhealth;
}
