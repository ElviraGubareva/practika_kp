using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Чтение строк из файла "mark.txt"
        var lines = File.ReadAllLines("mark.txt");
        foreach (var line in lines)
        {
            // Разделение строки на части
            var parts = line.Split(' ');
            // Получение фамилии
            var surname = parts[0];
            // Получение оценок
            var marks = parts.Skip(1).Select(int.Parse).ToArray();
            // Вычисление среднего балла
            var averageMark = marks.Average();

            // Вывод фамилии и среднего балла
            Console.WriteLine($"Фамилия: {surname}, Средний балл: {averageMark}");
            Console.ReadLine();
        }
    }
}
