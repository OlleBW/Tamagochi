using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private bool Alive;
    private int boredom;
    private int hunger;
    private List<string> words = new List<string>();
    private Random generator;
    public string name;

    public Tamagotchi()
    {
        Alive = true;
    }
    public bool getAlive()
    {
        return Alive;
    }
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            Alive = false;
        }
    }
    public void printStats()
    {
        Console.WriteLine($"Name: {name} Hunger: {hunger} Boredom: {boredom}");
    }
    public void Feed()
    {
        Console.WriteLine($"{name} ate your food and lost 2 hunger points!");
        Console.WriteLine("Press Enter to continue.");
        hunger = -2;
        if (hunger <= 0)
        {
            hunger = 0;
        }
        Console.ReadLine();
    }
    public void Play()
    {
        if (words.Count == 0)
        {
            Console.WriteLine($"Sorry but {name} does not know any words yet.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
        if (words.Count > 0)
        {
            int rndmWord = generator.Next(words.Count);
            Console.WriteLine($"{name} says: {rndmWord}");
        }
    }
    public void Teach(string word)
    {
        Console.WriteLine($"{name} learnt the word: {word}");
        words.Add(word);
        boredom = -2;
        if (boredom <= 0)
        {
            boredom = 0;
        }
        Console.WriteLine($"Press Enter to continue!");
        Console.ReadLine();
    }
}