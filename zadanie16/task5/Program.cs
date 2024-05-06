using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        File.WriteAllLines("f1.dat", new[] { "1", "2", "3", "4", "5" });
        File.WriteAllLines("f2.dat", new[] { "2", "3", "1", "5", "4" });

        var f1 = File.ReadAllLines("f1.dat").Select(int.Parse).ToArray();
        var f2 = File.ReadAllLines("f2.dat").Select(int.Parse).ToArray();

        var minF2 = f2.Min();
        var closestToF2Min = f2.OrderBy(x => Math.Abs((long)x - minF2)).First();
        Console.WriteLine($"Число, наиболее близкое к минимальному в f2.dat: {closestToF2Min}");

        var posNegZeroCounts = new[] { f1, f2 }
            .Select((numbers, i) => new
            {
                File = i == 0 ? "f1.dat" : "f2.dat",
                Positive = numbers.Count(x => x > 0),
                Negative = numbers.Count(x => x < 0),
                Zero = numbers.Count(x => x == 0)
            });

        foreach (var counts in posNegZeroCounts)
        {
            Console.WriteLine($"В файле {counts.File}: {counts.Positive} положительных, {counts.Negative} отрицательных, {counts.Zero} нулевых");
        }

        var isOrdered = f1.SequenceEqual(f1.OrderBy(x => x));
        Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isOrdered}");
        var isAlternating = f1.Zip(f1.Skip(1), (a, b) => Math.Sign(a) != Math.Sign(b)).All(x => x);
        Console.WriteLine($"Числа в f1.dat образуют знакопеременную последовательность: {isAlternating}");
        Console.ReadLine();
    }
}
