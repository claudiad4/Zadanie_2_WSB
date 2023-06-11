using System;

class Program
{
    static void Main(string[] args)
    {
        int n, k;

        Console.WriteLine("Podaj liczbę n (większą lub równą 5): ");
        n = int.Parse(Console.ReadLine());

        while (n < 5)
        {
            Console.WriteLine("Niepoprawna wartość liczby! Podaj liczbę większą lub równą 5: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Podaj liczbę k (większą lub równą 5): ");
        k = int.Parse(Console.ReadLine());

        while (k < 5)
        {
            Console.WriteLine("Niepoprawna wartość liczby! Podaj liczbę większą lub równą 5: ");
            k = int.Parse(Console.ReadLine());
        }

        long silniaN = 1;
        for (int i = 2; i <= n; i++)
            silniaN *= i;

        long silniaK = 1;
        for (int i = 2; i <= k; i++)
            silniaK *= i;

        long m = (silniaN - silniaK) / silniaK;

        Console.WriteLine("Wynik m = (n! - k!) / k! dla n = {0} i k = {1} wynosi: {2}", n, k, m);
    }
}
