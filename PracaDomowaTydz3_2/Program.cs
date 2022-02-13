using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaTydz3_2
{
    internal class Program
    {
        static int GetInputData()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int value) || value < 0 || value > 100)
                {
                    Console.WriteLine("Podana wartość nie jest z przedziału 0-100.\nSpróbuj jeszcze raz:");
                    continue;
                }
                return value;
            }
        }

        static void Main(string[] args)
        {
            var random = new Random();
            var randomValue = random.Next(100);
            int userValue;
            int userTrial = 1;

            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(5);
                Console.Write($" {random.Next(100)} ");
            }

            
            Console.WriteLine("\n\nRandomizator liczb! Sprawdz swoje szczęście!");
            Console.WriteLine("Wylosowana liczba jest z przedziału 0-100.\nPodaj swój szczęśliwy traf:");

            do
            {
                userValue = GetInputData();
                if (userValue > randomValue)
                {
                    Console.WriteLine("Podana liczba jest zbyt duża!\nSpróbuj jeszcze raz:");
                    userTrial++;
                }
                else if (userValue < randomValue)
                {
                    Console.WriteLine("Podana liczba jest zbyt mała!\nSpróbuj jeszcze raz:");
                    userTrial++;
                }
                else
                    Console.WriteLine($"Udało Ci się odganąć w {userTrial} próbach, gratulacje!");
            }
            while (userValue != randomValue);
        }
    }
}
