using System;
using System.Collections.Generic;

class SentenceManipulation
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;

        if (words.Length > 2)
        {
            words[1] = words[1] + words[2];
            var listOfWords = new List<string>(words);
            listOfWords.RemoveAt(2);
            words = listOfWords.ToArray();
        }

        if (words.Length > 2)
        {
            char[] thirdWordArray = words[2].ToCharArray();
            Array.Reverse(thirdWordArray);
            words[2] = new string(thirdWordArray);
        }

        if (words.Length > 0 && words[0].Length > 2)
        {
            words[0] = words[0].Substring(2);
        }

        Console.WriteLine("Измененное предложение:");
        Console.WriteLine(string.Join(" ", words));
        Console.ReadLine();
    }
}
