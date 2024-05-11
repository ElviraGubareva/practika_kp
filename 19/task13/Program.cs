using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Путь к исходному файлу.
        string sourceFilePath = "source.txt";
        // Путь к файлу с четными строками.
        string evenFilePath = "even.txt";
        // Путь к файлу с нечетными строками.
        string oddFilePath = "odd.txt";

        // Проверка на существование исходного файла.
        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine($"Файл '{sourceFilePath}' не найден.");
            return;
        }

        // Чтение строк из исходного файла.
        var lines = File.ReadLines(sourceFilePath).ToArray();

        // Запись четных строк в файл.
        File.WriteAllLines(evenFilePath, lines.Where((line, index) => index % 2 == 1));
        // Запись нечетных строк в файл.
        File.WriteAllLines(oddFilePath, lines.Where((line, index) => index % 2 == 0));
        Console.ReadLine();
    }
}
