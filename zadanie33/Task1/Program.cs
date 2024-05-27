using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task1.Contexts;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string dbPath = @"..\..\..\Database\DBTur_firm.db";
            TouristContext dbContext = new TouristContext(dbPath);

            Tourist newTourist = GatherTouristInfo();
            int addResult = await dbContext.AddTouristAsync(newTourist);
            Console.WriteLine(addResult > 0 ? "Турист успешно добавлен." : "Не удалось добавить туриста.");

            List<Tourist> tourists = await dbContext.GetTouristsAsync();
            Console.WriteLine("Список туристов:");
            DisplayTourists(tourists);

            if (tourists.Count > 0)
            {
                Console.WriteLine("Введите ID туриста для удаления:");
                if (int.TryParse(Console.ReadLine(), out int touristIdToDelete))
                {
                    int deleteResult = await dbContext.DeleteTouristAsync(touristIdToDelete);
                    Console.WriteLine(deleteResult > 0 ? "Турист успешно удален." : "Турист не найден.");
                }
                else
                {
                    Console.WriteLine("Введен недопустимый ID.");
                }
            }

            tourists = await dbContext.GetTouristsAsync();
            Console.WriteLine("Обновленный список туристов:");
            DisplayTourists(tourists);
        }

        static Tourist GatherTouristInfo()
        {
            Console.WriteLine("Введите фамилию туриста:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите имя туриста:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите отчество туриста:");
            string patronymic = Console.ReadLine();

            return new Tourist
            {
                LastName = lastName,
                FirstName = firstName,
                Patronymic = patronymic
            };
        }

        static void DisplayTourists(List<Tourist> tourists)
        {
            foreach (var tourist in tourists)
            {
                Console.WriteLine($"ID: {tourist.TouristId}, ФИО: {tourist.LastName} {tourist.FirstName} {tourist.Patronymic}");
            }
        }
    }
}
