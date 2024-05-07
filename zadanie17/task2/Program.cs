using System;

namespace FlowerLibrary
{
    public class Flower
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Flower(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Цветок: {Name}, Цвет: {Color}");
        }
    }

    public class Rose : Flower
    {
        public Rose(string color) : base("Роза", color) { }
    }

    public class Tulip : Flower
    {
        public Tulip(string color) : base("Тюльпан", color) { }
    }
}

class Program
{
    static void Main(string[] args)
    {
        FlowerLibrary.Rose rose = new FlowerLibrary.Rose("Красный");
        rose.DisplayInfo();

        FlowerLibrary.Tulip tulip = new FlowerLibrary.Tulip("Желтый");
        tulip.DisplayInfo();
        Console.ReadLine();
    }
}
