using System;
using System.Linq;

class RemoveUpperCase
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string result = new string(input.Where(c => !char.IsUpper(c)).ToArray());

        Console.WriteLine("Строка без заглавных символов:");
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
