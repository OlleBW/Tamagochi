using System;

Tamagotchi Tama = new Tamagotchi();

Console.WriteLine("Please pick a name for your Tamagotchi!");
Tama.name = Console.ReadLine();
Console.WriteLine($"You picked the name {Tama.name}");

while (Tama.getAlive() == true)
{
    Tama.printStats();

    Console.WriteLine("Chose what you want to do. (Write a corresponding number)");
    Console.WriteLine($"1. Teach {Tama.name} a new word");
    Console.WriteLine($"2. Play with your Tamagotchi");
    Console.WriteLine($"3. Feed your Tamagotchi");
    Console.WriteLine($"4. Do nothing");
    string Action = Console.ReadLine();
    if (Action == "1")
    {
        Console.Clear();
        Console.WriteLine("Test");

        Tama.Tick();
    }

    if (Action == "2")
    {
        Console.Clear();
        Console.WriteLine("Test 2");

        Tama.Tick();
    }

    if (Action == "3")
    {
        Console.Clear();

        Tama.Feed();

        Tama.Tick();

        Console.Clear();
    }

    if (Action == "4")
    {
        Console.Clear();

        Tama.Tick();
    }
    else
    {
        Console.Clear();
    }
}