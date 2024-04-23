using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is an example text in English.";

        bool isEnglish = IsEnglishText(text);

        if (isEnglish)
        {
            Console.WriteLine("Текст является текстом на английском языке.");
        }
        else
        {
            Console.WriteLine("Текст не является текстом на английском языке.");
        }
        Console.ReadLine();
    }

    static bool IsEnglishText(string text)
    {
        string pattern = @"[^A-Za-z\s.,!?;:'""\(\)\[\]]";
        MatchCollection matches = Regex.Matches(text, pattern);

        return matches.Count == 0;
    }
}
