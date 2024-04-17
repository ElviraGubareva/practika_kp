using System;

class A
{
    private int a;
    private int b;

    public A(int aValue, int bValue)
    {
        a = aValue;
        b = bValue;
    }

    public double CalculateExpression()
    {
        return (-b + 1.0 / a) / 3;
    }

    public int CubeSum()
    {
        int sum = a + b;
        return sum * sum * sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        A myObject = new A(5, 3);

        Console.WriteLine($"Значение выражения: {myObject.CalculateExpression()}");
        Console.WriteLine($"Сумма a и b в кубе: {myObject.CubeSum()}");
        Console.ReadLine();
    }
    
}
