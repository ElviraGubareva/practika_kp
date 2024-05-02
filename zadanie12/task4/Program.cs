using System;

class Program
{
    public delegate int RandomDelegate();

    static void Main(string[] args)
    {
        RandomDelegate[] delegates = new RandomDelegate[3];
        Random random = new Random();

        delegates[0] = delegate () { return random.Next(); };
        delegates[1] = delegate () { return random.Next(); };
        delegates[2] = delegate () { return random.Next(); };

        Func<RandomDelegate[], double> Average = delegate (RandomDelegate[] dels)
        {
            double sum = 0;
            foreach (var del in dels)
            {
                sum += del();
            }
            return sum / dels.Length;
        };

        Console.WriteLine($"Среднее арифметическое: {Average(delegates)}");
        Console.ReadLine();
    }
}
