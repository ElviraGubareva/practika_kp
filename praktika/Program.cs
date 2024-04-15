using System;

class Program
{
    static void Main()
    {
        // Ввод цены за килограмм и веса яблок
        Console.Write("Введите цену одного килограмма яблок (руб.): ");
        double pricePerKg = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите вес яблок (кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Вычисление стоимости покупки
        double cost = pricePerKg * weight;

        // Вывод результата
        Console.WriteLine($"Стоимость покупки: {cost} руб.");
        Console.ReadLine();
    }
}
