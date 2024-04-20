using System;

class TrainSeats
{
    static void Main()
    {
        int wagons = 18;
        int seats = 36;
        int[,] ticketsSold = new int[wagons, seats];

        for (int i = 0; i < wagons; i++)
        {
            for (int j = 0; j < seats; j++)
            {
                ticketsSold[i, j] = 0;
            }
        }

        ticketsSold[0, 0] = 1; 
        ticketsSold[1, 2] = 1; 


        CheckForFreeSeats(ticketsSold);
    }

    static void CheckForFreeSeats(int[,] ticketsSold)
    {
        bool freeSeatsAvailable = false;

        for (int i = 0; i < ticketsSold.GetLength(0); i++)
        {
            freeSeatsAvailable = false;
            for (int j = 0; j < ticketsSold.GetLength(1); j++)
            {
                if (ticketsSold[i, j] == 0)
                {
                    freeSeatsAvailable = true;
                    break;
                }
            }

            if (freeSeatsAvailable)
            {
                Console.WriteLine($"В вагоне {i + 1} есть свободные места.");
            }
            else
            {
                Console.WriteLine($"В вагоне {i + 1} нет свободных мест.");
            }
            Console.ReadLine();
        }
    }
}
