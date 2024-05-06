using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "file.txt";
        string newFilePath = "newFile.txt";
        string[] lines = new string[5] { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };

        File.WriteAllLines(filePath, lines);

        Console.WriteLine("Содержимое файла:");
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }

        int lineCount = File.ReadLines(filePath).Count();
        Console.WriteLine($"Количество строк: {lineCount}");

        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }

        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Take(lineCount - 1));

        int s1 = 1, s2 = 3; 
        Console.WriteLine($"Строки с {s1} по {s2}:");
        foreach (var line in File.ReadLines(filePath).Skip(s1 - 1).Take(s2 - s1 + 1))
        {
            Console.WriteLine(line);
        }

        int maxLength = File.ReadLines(filePath).Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");

        char startChar = 'П'; 
        Console.WriteLine($"Строки, начинающиеся на букву '{startChar}':");
        foreach (var line in File.ReadLines(filePath).Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Reverse());
        Console.ReadLine();
    }
}
