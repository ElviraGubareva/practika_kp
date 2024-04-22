using System;

class MatrixOperations
{
    static void Main()
    {
        Console.Write("Введите N (размер матрицы NxN, N < 10): ");
        int N = Convert.ToInt32(Console.ReadLine());
        while (N >= 10)
        {
            Console.Write("N должно быть меньше 10, введите N еще раз: ");
            N = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Введите нижнюю границу диапазона a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите верхнюю границу диапазона b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[N, N];
        Random rand = new Random();

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int evenSum = 0;
        foreach (int element in matrix)
        {
            if (element % 2 == 0)
            {
                evenSum += element;
            }
        }
        Console.WriteLine($"Сумма чётных элементов: {evenSum}");

        Console.WriteLine("Количество положительных элементов в каждом столбце:");
        for (int j = 0; j < N; j++)
        {
            int positiveCount = 0;
            for (int i = 0; i < N; i++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCount++;
                }
            }
            Console.WriteLine($"Столбец {j + 1}: {positiveCount}");
            Console.ReadLine();
        }
    }
}