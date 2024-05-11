using System;

class Program
{
    /// <summary>
    /// Делегат для генерации случайных чисел.
    /// </summary>
    public delegate int RandomDelegate();

    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main(string[] args)
    {
        RandomDelegate[] delegates = new RandomDelegate[3];
        Random random = new Random();

        // Инициализация делегатов анонимными методами
        delegates[0] = delegate () { return random.Next(); };
        delegates[1] = delegate () { return random.Next(); };
        delegates[2] = delegate () { return random.Next(); };

        // Функция для вычисления среднего значения сгенерированных чисел
        Func<RandomDelegate[], double> Average = delegate (RandomDelegate[] dels)
        {
            double sum = 0;
            foreach (var del in dels)
            {
                sum += del();
            }
            return sum / dels.Length;
        };

        Console.WriteLine($"Среднее арифметическое: {Average(delegates)}");
        Console.ReadLine();
    }
}
