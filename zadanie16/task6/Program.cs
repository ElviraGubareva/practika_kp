using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("mark.txt");
        foreach (var line in lines)
        {
            var parts = line.Split(' ');
            var surname = parts[0];
            var marks = parts.Skip(1).Select(int.Parse).ToArray();
            var averageMark = marks.Average();

            Console.WriteLine($"Фамилия: {surname}, Средний балл: {averageMark}");
            Console.ReadLine();
        }
    }
}
