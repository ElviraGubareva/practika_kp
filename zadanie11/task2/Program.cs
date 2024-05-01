using System;

abstract class Bird
{
    public abstract int FoodNeeded();
}

class Stork : Bird
{
    public override int FoodNeeded()
    {
        return 5; // количество пищи, необходимое аисту
    }
}

class Crow : Bird
{
    public override int FoodNeeded()
    {
        return 3; // количество пищи, необходимое вороне
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bird[] birds = new Bird[5];
        birds[0] = new Stork();
        birds[1] = new Crow();
        birds[2] = new Stork();
        birds[3] = new Crow();
        birds[4] = new Stork();

        for (int i = 0; i < birds.Length; i++)
        {
            Console.WriteLine($"Птица {i + 1} требует {birds[i].FoodNeeded()} единиц пищи.");
            Console.ReadLine();
        }
    }
}
