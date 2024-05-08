using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "abc#d##c";
        Console.WriteLine("Original String: " + input);
        Console.WriteLine("Processed String: " + ProcessString(input));
        Console.ReadLine();
    }

    static string ProcessString(string input)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != '#')
            {
                stack.Push(input[i]);
            }
            else if (stack.Count > 0)
            {
                stack.Pop();
            }
        }

        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
