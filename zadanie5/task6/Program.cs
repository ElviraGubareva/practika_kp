using System;

class Program
{
    static void Main()
    {
        int n = 7; 
        int[,] spiralArray = new int[n, n];
        int value = 1;
        int minRow = 0, maxRow = n - 1, minCol = 0, maxCol = n - 1;

        while (value <= n * n)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                spiralArray[minRow, i] = value++;
            }
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
            {
                spiralArray[i, maxCol] = value++;
            }
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
            {
                spiralArray[maxRow, i] = value++;
            }
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
            {
                spiralArray[i, minCol] = value++;
            }
            minCol++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiralArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}