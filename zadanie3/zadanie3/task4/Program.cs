using System;

class RealMatrix
{
    private double[,] matrix;
    private int rows;
    private int cols;

    public RealMatrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new double[rows, cols];
    }

    // Инициализация матрицы
    public void InitializeMatrix()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Введите элемент матрицы [{i},{j}]: ");
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    // Вывод матрицы
    public void PrintMatrix()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Умножение матрицы на число
    public void MultiplyByScalar(double scalar)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] *= scalar;
            }
        }
    }

    // Умножение матрицы на другую матрицу
    public RealMatrix MultiplyByMatrix(RealMatrix otherMatrix)
    {
        RealMatrix resultMatrix = new RealMatrix(rows, otherMatrix.cols);

        if (cols != otherMatrix.rows)
        {
            Console.WriteLine("Невозможно выполнить умножение, т.к. количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            return null;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < otherMatrix.cols; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols; k++)
                {
                    sum += matrix[i, k] * otherMatrix.matrix[k, j];
                }
                resultMatrix.matrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }

    // Реализация операций присваивания
    public void MultiplyAssign(double scalar)
    {
        MultiplyByScalar(scalar);
    }

    // Доступ к элементу по индексам
    public double this[int i, int j]
    {
        get { return matrix[i, j]; }
        set { matrix[i, j] = value; }
    }

    // Операция возведения в степень
    public RealMatrix Power(int exponent)
    {
        if (rows != cols)
        {
            Console.WriteLine("Матрица должна быть квадратной для операции возведения в степень.");
            return null;
        }

        RealMatrix resultMatrix = new RealMatrix(rows, cols);

        if (exponent == 0)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = (i == j) ? 1 : 0;
                }
            }
            return resultMatrix;
        }

        if (exponent == 1)
        {
            return this;
        }

        RealMatrix tempMatrix = new RealMatrix(rows, cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempMatrix[i, j] = matrix[i, j];
            }
        }

        while (exponent > 1)
        {
            resultMatrix = MultiplyByMatrix(tempMatrix);
            tempMatrix = resultMatrix;
            exponent--;
        }

        return resultMatrix;
    }
}

class Program
{
    static void Main()
    {
        RealMatrix matrix1 = new RealMatrix(2, 2);
        matrix1.InitializeMatrix();
        Console.WriteLine("Введенная матрица 1:");
        matrix1.PrintMatrix();

        RealMatrix matrix2 = new RealMatrix(2, 2);
        matrix2.InitializeMatrix();
        Console.WriteLine("Введенная матрица 2:");
        matrix2.PrintMatrix();

        Console.WriteLine("Результат умножения матрицы 1 на число 2:");
        matrix1.MultiplyByScalar(2);
        matrix1.PrintMatrix();

        Console.WriteLine("Результат умножения матрицы 1 на матрицу 2:");
        RealMatrix resultMatrix = matrix1.MultiplyByMatrix(matrix2);
        if (resultMatrix != null)
        {
            resultMatrix.PrintMatrix();
        }

        Console.WriteLine("Результат возведения матрицы 1 в степень 2:");
        RealMatrix poweredMatrix = matrix1.Power(2);
        if (poweredMatrix != null)
        {
            poweredMatrix.PrintMatrix();
        }

        Console.WriteLine("Тестируем доступ к элементам матрицы:");
        Console.WriteLine("Элемент матрицы 1 на позиции [1,1]:" + matrix1[1, 1]);

        Console.WriteLine("Присваиваем элементу [1,1] значение 7:");
        matrix1[1, 1] = 7;
        Console.WriteLine("Новая матрица 1:");
        matrix1.PrintMatrix();
        Console.ReadLine();
    }
}