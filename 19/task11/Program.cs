using System;
using System.IO;


class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        // Путь к папке.
        string folderPath = @"New_folder";

        // Проверка на существование папки.
        if (!Directory.Exists(folderPath))
        {
            // Создание папки, если она не существует.
            Directory.CreateDirectory(folderPath);
            System.Console.WriteLine($"Папка '{folderPath}' была успешно создана.");
        }
        else
        {
            // Вывод сообщения, если папка уже существует.
            System.Console.WriteLine($"Папка '{folderPath}' уже существует.");
        }

        // Ожидание ввода пользователя перед завершением программы.
        Console.ReadLine();
    }
}
