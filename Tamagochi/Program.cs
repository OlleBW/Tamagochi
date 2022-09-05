using System;

Tamagotchi Tama = new Tamagotchi();

Console.WriteLine("Please pick a name for your Tamagotchi!");
Tama.name = Console.ReadLine();
Console.WriteLine($"You picked the name {Tama.name}");

while (Tama.Alive == true)
{
    Console.WriteLine("Chose what you want to do.");
    Console.WriteLine($"1. Teach {Tama.name} a new word");


    string Action = Console.ReadLine();

    Tama.Tick();
}