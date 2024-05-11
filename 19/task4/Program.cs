using System;

class RealMatrix
{
    private double[,] matrix;
    private int rows;
    private int cols;

    /// <summary>
    /// Конструктор класса RealMatrix.
    /// </summary>
    /// <param name="rows">Количество строк в матрице.</param>
    /// <param name="cols">Количество столбцов в матрице.</param>
    public RealMatrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new double[rows, cols];
    }

    /// <summary>
    /// Метод для инициализации матрицы.
    /// </summary>
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

    /// <summary>
    /// Метод для вывода матрицы.
    /// </summary>
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

    /// <summary>
    /// Метод для умножения матрицы на число.
    /// </summary>
    /// <param name="scalar">Число, на которое умножается матрица.</param>
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

    /// <summary>
    /// Метод для умножения матрицы на другую матрицу.
    /// </summary>
    /// <param name="otherMatrix">Другая матрица, на которую умножается текущая матрица.</param>
    /// <returns>Результат умножения матриц.</returns>
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

    /// <summary>
    /// Метод для умножения матрицы на число с присваиванием результата текущей матрице.
    /// </summary>
    /// <param name="scalar">Число, на которое умножается матрица.</param>
    public void MultiplyAssign(double scalar)
    {
        MultiplyByScalar(scalar);
    }

    /// <summary>
    /// Индексатор для доступа к элементам матрицы.
    /// </summary>
    /// <param name="i">Индекс строки.</param>
    /// <param name="j">Индекс столбца.</param>
    /// <returns>Элемент матрицы с заданными индексами.</returns>
    public double this[int i, int j]
    {
        get { return matrix[i, j]; }
        set { matrix[i, j] = value; }
    }

    /// <summary>
    /// Метод для возведения матрицы в степень.
    /// </summary>
    /// <param name="exponent">Степень, в которую возводится матрица.</param>
    /// <returns>Матрица, возведенная в заданную степень.</returns>
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