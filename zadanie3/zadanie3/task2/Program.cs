using System;

class ArrayHelper
{
    private int[,] array;

    public ArrayHelper(int[,] arr)
    {
        array = arr;
    }

    public int SumMainDiagonal()
    {
        int sum = 0;
        for (int i = 0; i < Math.Min(array.GetLength(0), array.GetLength(1)); i++)
        {
            sum += array[i, i];
        }
        return sum;
    }

    public static bool operator >(ArrayHelper obj1, ArrayHelper obj2)
    {
        return obj1.SumMainDiagonal() > obj2.SumMainDiagonal();
    }

    public static bool operator <(ArrayHelper obj1, ArrayHelper obj2)
    {
        return obj1.SumMainDiagonal() < obj2.SumMainDiagonal();
    }
}

class Program
{
    static void Main()
    {
        int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        ArrayHelper obj1 = new ArrayHelper(array1);

        int[,] array2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 4, 4 } };
        ArrayHelper obj2 = new ArrayHelper(array2);

        if (obj1 > obj2)
            Console.WriteLine("Сумма элементов главной диагонали в obj1 больше чем в obj2");
        else if (obj1 < obj2)
            Console.WriteLine("Сумма элементов главной диагонали в obj1 меньше чем в obj2");
        else
            Console.WriteLine("Сумма элементов главной диагонали в obj1 равна сумме в obj2");
        Console.ReadLine();
    }
}