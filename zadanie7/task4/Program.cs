using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "обвесть, машина, колледж, ремонт, хлеб";
        string pattern = @"\b\w*[бвгджзйклмнпрстфхцчшщ]{2}\b";

        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
        Console.ReadLine();
    }
}
