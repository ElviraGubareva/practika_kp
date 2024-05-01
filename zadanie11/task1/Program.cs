using System;

public abstract class Clothing
{
    public string Name { get; set; }

    public Clothing(string name)
    {
        Name = name;
    }

    public abstract double FabricConsumption();
}

public class Coat : Clothing
{
    public double V { get; set; }

    public Coat(string name, double v) : base(name)
    {
        V = v;
    }

    public override double FabricConsumption()
    {
        return V / 6.5 + 0.5;
    }
}

public class Suit : Clothing
{
    public double H { get; set; }

    public Suit(string name, double h) : base(name)
    {
        H = h;
    }

    public override double FabricConsumption()
    {
        return 2 * H + 0.3;
    }
}

public class Program
{
    public static void Main()
    {
        Clothing[] clothes = new Clothing[5]
        {
            new Coat("Coat1", 10),
            new Suit("Suit1", 20),
            new Coat("Coat2", 15),
            new Suit("Suit2", 25),
            new Coat("Coat3", 20)
        };

        foreach (var item in clothes)
        {
            Console.WriteLine($"Название: {item.Name}, Расход ткани: {item.FabricConsumption()}");
            Console.ReadLine();
        }
    }
}
