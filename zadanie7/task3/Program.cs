    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string text = "Привет, мой e-mail адрес example@mail.com, а вот еще один: another_email@example.com.";
            string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            Console.ReadLine();
        }
    }
