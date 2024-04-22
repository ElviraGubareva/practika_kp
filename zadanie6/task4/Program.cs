using System;
using System.Linq;

class IdentityCode
{
    static void Main()
    {
        Console.WriteLine("Введите фамилию, имя и отчество:");
        string fullName = Console.ReadLine().Replace(" ", "").ToUpper();
        int identityCode = fullName.Sum(c => c - 'А' + 1);

        while (identityCode > 9)
        {
            identityCode = SumDigits(identityCode);
        }

        Console.WriteLine($"Код личности: {identityCode}");
        Console.ReadLine();
    }

    static int SumDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
