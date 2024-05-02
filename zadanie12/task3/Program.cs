using System;

class Program
{
    public delegate string StringDelegate(string str);

    static void Main(string[] args)
    {
        StringDelegate strDelegate;

        strDelegate = ToUpper;
        Console.WriteLine(strDelegate("Привет, мир!"));

        strDelegate = ToLower;
        Console.WriteLine(strDelegate("Привет, МИР!"));

        strDelegate = Reverse;
        Console.WriteLine(strDelegate("Привет, мир!"));
        Console.ReadLine();
    }

    public static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    public static string ToLower(string str)
    {
        return str.ToLower();
    }

    public static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
