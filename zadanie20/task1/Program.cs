public class Task
{
    public int Number { get; set; }

    public Task(int number)
    {
        Number = number;
    }

    public int SwapDigits()
    {
        int firstDigit = Number / 100;
        int secondDigit = (Number / 10) % 10;
        int thirdDigit = Number % 10;

        return secondDigit * 100 + firstDigit * 10 + thirdDigit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Task task1 = new Task(467);
        Task task2 = new Task(958);
        Task task3 = new Task(248);

        Console.WriteLine(task1.SwapDigits());  
        Console.WriteLine(task2.SwapDigits());  
        Console.WriteLine(task3.SwapDigits());  
        Console.ReadLine();
    }
}
