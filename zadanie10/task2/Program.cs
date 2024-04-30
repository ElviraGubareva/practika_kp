using System;
public class A
{
    protected int a = 21;
    protected int b = 21;

    public int C
    {
        get
        {
            int result = a + b;
            while (result > 0)
            {
                result--;
            }
            return result;
        }
    }
}

public class B : A
{
    private int d = 21;

    public B() : base()
    {
    }

    public B(int d)
    {
        this.d = d;
    }

    public int C2
    {
        get
        {
            int result = a + b + d;
            while (result > 0)
            {
                result--;
            }
            return result;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine("Значение свойства C класса A: " + a.C);

        B b1 = new B();
        Console.WriteLine("Значение свойства C2 класса B (конструктор по умолчанию): " + b1.C2);

        B b2 = new B(42);
        Console.WriteLine("Значение свойства C2 класса B (конструктор с параметром): " + b2.C2);
        Console.ReadLine();
    }
}
