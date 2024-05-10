using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = 796; 

        Task<int> task1 = Task.Run(() =>
        {
            int reversedNumber = int.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
            return reversedNumber;
        });

        Task task2 = task1.ContinueWith(t =>
        {
            Console.WriteLine("Результат: " + t.Result);
        });

        task2.Wait(); 
       Console.ReadLine(); 
    }
}
