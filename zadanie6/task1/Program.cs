using System;

class ReverseWords
{
    static void Main()
    {
        Console.WriteLine("Введите фрагмент текста:");
        string text = Console.ReadLine();

        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        string reversedText = string.Join(" ", words);
        Console.WriteLine("Текст в обратном порядке:");
        Console.WriteLine(reversedText);
        Console.ReadLine();
    }
}
