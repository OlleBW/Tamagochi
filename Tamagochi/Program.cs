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
        Tama.Tick();
        Console.Clear();
        Console.WriteLine($"Write a word for {Tama.name} to learn!");
        string word = Console.ReadLine();
        Tama.Teach(word);
    }

    if (Action == "2")
    {
        Tama.Tick();
        Console.Clear();
        Tama.Play();
    }

    if (Action == "3")
    {
        Tama.Tick();
        Console.Clear();

        Tama.Feed();

        Console.Clear();
    }

    if (Action == "4")
    {
        Tama.Tick();
        Console.Clear();
    }
    else
    {
        Console.Clear();
    }
}
Console.Clear();
Console.WriteLine("You Lost!");
Console.WriteLine("Press Enter to quit");
Console.ReadLine();