using System;
using System.IO;
using System.Linq;

class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Путь к файлу.
        string filePath = "file.txt";
        // Путь к новому файлу.
        string newFilePath = "newFile.txt";
        // Массив строк для записи в файл.
        string[] lines = new string[5] { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };

        // Запись строк в файл.
        File.WriteAllLines(filePath, lines);

        Console.WriteLine("Содержимое файла:");
        // Чтение и вывод строк из файла.
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }

        // Подсчет количества строк в файле.
        int lineCount = File.ReadLines(filePath).Count();
        Console.WriteLine($"Количество строк: {lineCount}");

        // Подсчет и вывод количества символов в каждой строке.
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }

        // Запись в новый файл всех строк, кроме последней.
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Take(lineCount - 1));

        // Вывод строк с s1 по s2.
        int s1 = 1, s2 = 3;
        Console.WriteLine($"Строки с {s1} по {s2}:");
        foreach (var line in File.ReadLines(filePath).Skip(s1 - 1).Take(s2 - s1 + 1))
        {
            Console.WriteLine(line);
        }

        // Поиск и вывод длины самой длинной строки.
        int maxLength = File.ReadLines(filePath).Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLength}");

        // Вывод строк, начинающихся на определенный символ.
        char startChar = 'П';
        Console.WriteLine($"Строки, начинающиеся на букву '{startChar}':");
        foreach (var line in File.ReadLines(filePath).Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        // Запись строк в обратном порядке в новый файл.
        File.WriteAllLines(newFilePath, File.ReadLines(filePath).Reverse());

        // Ожидание ввода пользователя перед завершением программы.
        Console.ReadLine();
    }
}
