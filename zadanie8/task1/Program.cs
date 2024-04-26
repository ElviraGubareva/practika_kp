using System;
using System.Collections.Generic;
using System.Linq;

// Описание структуры WORKER
struct WORKER
{
    public string FullName; // Фамилия и инициалы работника
    public string Position; // Название занимаемой должности
    public int YearOfEmployment; // Год поступления на работу
}

class Program
{
    static void Main(string[] args)
    {
        List<WORKER> workers = new List<WORKER>();

        Console.WriteLine("Введите данные о 10 работниках:");
        for (int i = 0; i < 10; i++)
        {
            WORKER worker = new WORKER();

            Console.Write("Фамилия и инициалы работника: ");
            worker.FullName = Console.ReadLine();

            Console.Write("Название занимаемой должности: ");
            worker.Position = Console.ReadLine();

            Console.Write("Год поступления на работу: ");
            worker.YearOfEmployment = int.Parse(Console.ReadLine());

            workers.Add(worker);
        }

        workers = workers.OrderBy(w => w.FullName).ToList();

        Console.Write("Введите минимальный стаж работы: ");
        int experience = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;

        bool found = false;
        foreach (var worker in workers)
        {
            if (currentYear - worker.YearOfEmployment > experience)
            {
                Console.WriteLine(worker.FullName);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Работников со стажем работы более " + experience + " лет нет.");
        }
        Console.ReadLine();
    }
}
