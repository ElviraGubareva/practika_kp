using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var files = Directory.GetFiles("D:\\", "*.*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }

        var dirPath = "D:\\Example_36tp";
        Directory.CreateDirectory(dirPath);

        var sourceDir = "D:\\SomeOtherDirectory"; 
        var sourceFiles = Directory.GetFiles(sourceDir).Take(3);
        foreach (var sourceFile in sourceFiles)
        {
            var destinationFile = Path.Combine(dirPath, Path.GetFileName(sourceFile));
            File.Copy(sourceFile, destinationFile);
        }

        var copiedFiles = Directory.GetFiles(dirPath);
        foreach (var copiedFile in copiedFiles)
        {
            File.SetAttributes(copiedFile, FileAttributes.Hidden);

            var linkFile = Path.Combine(dirPath, Path.GetFileNameWithoutExtension(copiedFile) + "_link" + Path.GetExtension(copiedFile));
            using (var writer = File.CreateText(linkFile))
            {
                writer.WriteLine($"Это ссылка на скрытый файл: {copiedFile}");
            }
        }
        Console.ReadLine();
    }
}
