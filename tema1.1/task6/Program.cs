using System;

class Program
{
    static void Main()
    {
        double A = 0.0; 
        double B = 1.0; 
        int M = 20; 

        double H = (B - A) / M; 

        Console.WriteLine("Значения функции F(x) на отрезке [{0}, {1}]:", A, B);
        Console.WriteLine("x\t\tF(x)");

        for (int i = 0; i <= M; i++)
        {
            double xi = A + i * H;
            double Fi = Math.Atan(Math.Sqrt(xi));
            Console.WriteLine("{0:F4}\t{1:F4}", xi, Fi);
        }
        Console.ReadLine();
    }
}
