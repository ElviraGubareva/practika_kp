using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица перевода дюймов в сантиметры:");
        Console.WriteLine("Дюймы\tСантиметры");

        for (int inches = 2; inches <= 24; inches += 2)
        {
            double centimeters = inches * 2.54;
            Console.WriteLine($"{inches}\t{centimeters:F2}");
        }
        Console.ReadLine();
    }
}
