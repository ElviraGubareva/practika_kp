using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string sourceFilePath = "source.txt"; 
        string evenFilePath = "even.txt";
        string oddFilePath = "odd.txt"; 

        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine($"Файл '{sourceFilePath}' не найден.");
            return;
        }

        var lines = File.ReadLines(sourceFilePath).ToArray();

        File.WriteAllLines(evenFilePath, lines.Where((line, index) => index % 2 == 1));
        File.WriteAllLines(oddFilePath, lines.Where((line, index) => index % 2 == 0));
        Console.ReadLine();
    }
}
