using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер телевизионного канала (1 - Беларусь 1, 7 - Беларусь 7, 12 - ТНТ): ");
        int channelNumber = int.Parse(Console.ReadLine());

        switch (channelNumber)
        {
            case 1:
                Console.WriteLine("Наиболее популярные программы на канале Беларусь 1:");
                Console.WriteLine("- Мелодрама \"Пустой дом\"");
                Console.WriteLine("- Детективный сериал \"След\"");
                break;
            case 7:
                Console.WriteLine("Наиболее популярные программы на канале Беларусь 7:");
                break;
            case 12:
                Console.WriteLine("Наиболее популярные программы на канале ТНТ:");
                Console.WriteLine("- Шоу \"Comedy Club\"");
                Console.WriteLine("- Реалити-шоу \"Битва Экстрасенсов\"");
                break;
            default:
                Console.WriteLine("Неверный номер канала. Пожалуйста, введите корректный номер.");
                break;
        }
        Console.ReadLine();
    }
}
