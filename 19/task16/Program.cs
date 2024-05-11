using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Получение списка всех файлов в директории "D:\\"
        var files = Directory.GetFiles("D:\\", "*.*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            // Вывод пути каждого файла
            Console.WriteLine(file);
        }

        // Создание новой директории "D:\\Example_36tp"
        var dirPath = "D:\\Example_36tp";
        Directory.CreateDirectory(dirPath);

        // Копирование первых трех файлов из директории "D:\\SomeOtherDirectory" в "D:\\Example_36tp"
        var sourceDir = "D:\\SomeOtherDirectory";
        var sourceFiles = Directory.GetFiles(sourceDir).Take(3);
        foreach (var sourceFile in sourceFiles)
        {
            var destinationFile = Path.Combine(dirPath, Path.GetFileName(sourceFile));
            File.Copy(sourceFile, destinationFile);
        }

        // Скрытие скопированных файлов и создание ссылок на них
        var copiedFiles = Directory.GetFiles(dirPath);
        foreach (var copiedFile in copiedFiles)
        {
            // Установка атрибута "скрытый" для файла
            File.SetAttributes(copiedFile, FileAttributes.Hidden);

            // Создание файла-ссылки на скрытый файл
            var linkFile = Path.Combine(dirPath, Path.GetFileNameWithoutExtension(copiedFile) + "_link" + Path.GetExtension(copiedFile));
            using (var writer = File.CreateText(linkFile))
            {
                writer.WriteLine($"Это ссылка на скрытый файл: {copiedFile}");
            }
        }
        Console.ReadLine();
    }
}
