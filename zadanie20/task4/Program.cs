using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int A = -10; 
        int B = 1; 

        Parallel.For(A, B + 1, i =>
        {
            double result = Math.Atan(i);
            Console.WriteLine($"arctg({i}) = {result}");
        });

        Console.ReadLine(); 
    }
}
