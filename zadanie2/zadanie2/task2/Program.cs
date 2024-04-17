using System;

class PrintEdition
{
    public string Title { get; set; }
    public int Year { get; set; }
}

class Book : PrintEdition
{
    public string Author { get; set; }
}

class Magazine : PrintEdition
{
    public string Editor { get; set; }
}

class Textbook : Book
{
    public string Subject { get; set; }
}

class Program
{
    static void Main()
    {
        Magazine magazine = new Magazine();
        magazine.Title = "Незнайка";
        magazine.Year = 2024;
        magazine.Editor = "Муравьева";

        Book book = new Book();
        book.Title = "Война и мир";
        book.Year = 1868;
        book.Author = "Толстой";

        Textbook textbook = new Textbook();
        textbook.Title = "Основы информатики";
        textbook.Year = 2020;
        textbook.Author = "Орлов";
        textbook.Subject = "Информатика";

        Console.WriteLine($"Журнал: {magazine.Title}, Редактор: {magazine.Editor}, Год: {magazine.Year}");
        Console.WriteLine($"Книга: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
        Console.WriteLine($"Заглавие: {textbook.Title}, Автор: {textbook.Author}, Предмет: {textbook.Subject}, Год: {textbook.Year}");
        Console.ReadLine();
    }
}