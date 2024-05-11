using System;

class Program
{
    /// <summary>
    /// Делегат для выполнения операций над строками.
    /// </summary>
    /// <param name="str">Строка, над которой выполняется операция.</param>
    /// <returns>Результат операции над строкой.</returns>
    public delegate string StringDelegate(string str);

    /// <summary>
    /// Главный метод программы.
    /// </summary>
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

    /// <summary>
    /// Метод для преобразования строки в верхний регистр.
    /// </summary>
    /// <param name="str">Строка, которую нужно преобразовать.</param>
    /// <returns>Строка в верхнем регистре.</returns>
    public static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    /// <summary>
    /// Метод для преобразования строки в нижний регистр.
    /// </summary>
    /// <param name="str">Строка, которую нужно преобразовать.</param>
    /// <returns>Строка в нижнем регистре.</returns>
    public static string ToLower(string str)
    {
        return str.ToLower();
    }

    /// <summary>
    /// Метод для обращения строки.
    /// </summary>
    /// <param name="str">Строка, которую нужно обратить.</param>
    /// <returns>Обращенная строка.</returns>
    public static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
