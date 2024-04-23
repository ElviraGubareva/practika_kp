using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "великолепный, столовая, солнечно-ясный, электро-газо-сварщик";

        string pattern = @"\b\w+-?\w+\b";

        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
        Console.ReadLine();
    }
}
