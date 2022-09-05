using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private int boredom;
    public bool Alive = true;
    public string name;
    private int hunger;

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 5 || boredom > 5)
        {
            Alive = false;
        }
    }
}