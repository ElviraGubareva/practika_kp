using System;
using System.Collections;

class CD
{
    public string Title { get; set; }
    public ArrayList Songs { get; set; }

    public CD(string title)
    {
        Title = title;
        Songs = new ArrayList();
    }

    public void AddSong(string song)
    {
        Songs.Add(song);
    }

    public void RemoveSong(string song)
    {
        Songs.Remove(song);
    }

    public void DisplaySongs()
    {
        Console.WriteLine("Песни в " + Title + ":");
        foreach (string song in Songs)
        {
            Console.WriteLine(song);
        }
    }
}

class MainClass
{
    static Hashtable catalog = new Hashtable();

    public static void Main(string[] args)
    {
        string command;
        do
        {
            Console.WriteLine("Введите команду:");
            command = Console.ReadLine();
            switch (command)
            {
                case "add cd":
                    Console.WriteLine("Введите название диска:");
                    string title = Console.ReadLine();
                    catalog.Add(title, new CD(title));
                    break;
                case "remove cd":
                    Console.WriteLine("Введите название диска:");
                    title = Console.ReadLine();
                    catalog.Remove(title);
                    break;
                case "add song":
                    Console.WriteLine("Введите название диска:");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите название песни:");
                    string song = Console.ReadLine();
                    (CD)catalog[title]).AddSong(song);
                    break;
                case "remove song":
                    Console.WriteLine("Введите название диска:");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите название песни:");
                    song = Console.ReadLine();
                    ((CD)catalog[title]).RemoveSong(song);
                    break;
                case "display catalog":
                    foreach (DictionaryEntry entry in catalog)
                    {
                        Console.WriteLine("Диск: " + entry.Key);
                        ((CD)entry.Value).DisplaySongs();
                    }
                    break;
                case "display cd":
                    Console.WriteLine("Введите название диска:");
                    title = Console.ReadLine();
                    ((CD)catalog[title]).DisplaySongs();
                    break;
            }
        } while (command != "exit");
        Console.ReadLine();
    }
}
