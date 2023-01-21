using System;

namespace Emerytura
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwisko = Console.ReadLine();
            int wiek = int.Parse(Console.ReadLine());
            int wiekEmerytalny = int.Parse(Console.ReadLine());
           

            Console.WriteLine($"Witaj, {nazwisko}!");

            if (wiek < 0 || wiekEmerytalny < 0)
            {
                Console.WriteLine("Wiek nie może być ujemny!");
                return;
            }

            if (wiek >= wiekEmerytalny)
            {
                Console.WriteLine("Jesteś emerytem!");
            }
            if (wiek - wiekEmerytalny = x)
            {
                Console.WriteLine($"Do emerytury brakuje Ci {x <= 5} lat!");
                return
            }
            else
            {
                Console.WriteLine($"Do emerytury brakuje Ci {x >= 5} lat!");
                return
            }

        }
    }