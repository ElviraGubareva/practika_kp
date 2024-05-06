using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = @"New_folder"; 
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            System.Console.WriteLine($"Папка '{folderPath}' была успешно создана.");
        }
        else
        {
            System.Console.WriteLine($"Папка '{folderPath}' уже существует.");
        }
        Console.ReadLine();
    }
}
