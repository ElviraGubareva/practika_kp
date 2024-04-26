using System;

public enum Post
{
    Manager,
    Developer,
    Accountant,
}

public class Accountant
{
    public bool AskForBonus(Post worker, int hours)
    {
        const int standardHours = 160;

        return hours > standardHours;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Accountant accountant = new Accountant();

        bool isBonusGranted = accountant.AskForBonus(Post.Manager, 170);

        if (isBonusGranted)
        {
            Console.WriteLine("Сотруднику положена премия.");
        }
        else
        {
            Console.WriteLine("Сотруднику не положена премия.");
        }
        Console.ReadLine();
    }
}
