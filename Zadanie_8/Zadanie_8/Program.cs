using System;

class Program
{
    static void Main(string[] args)
    {
        int min = 1;
        int max = 20;
        int zgadywanaLiczba;
        int odpowiedz;

        Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");
        Console.WriteLine("Naciśnij dowolny klawisz, gdy będziesz gotowy.");
        Console.ReadKey();

        do
        {
            zgadywanaLiczba = (min + max) / 2;
            Console.WriteLine("Czy Twoja liczba to " + zgadywanaLiczba + "?");
            Console.WriteLine("Wpisz -1, jeśli jest mniejsza, 1, jeśli jest większa, 0 jeśli zgadłem:");
            odpowiedz = int.Parse(Console.ReadLine());

            if (odpowiedz == -1)
            {
                max = zgadywanaLiczba - 1;
            }
            else if (odpowiedz == 1)
            {
                min = zgadywanaLiczba + 1;
            }
            else if (odpowiedz == 0)
            {
                Console.WriteLine("Odgadłem! Twoja liczba to " + zgadywanaLiczba + ".");
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Spróbuj jeszcze raz.");
            }
        } while (true);
    }
}
