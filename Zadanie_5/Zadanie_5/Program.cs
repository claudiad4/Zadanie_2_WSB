using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj wartość x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę wyrazów (n): ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        double term = 1;

        for (int i = 0; i <= n; i++)
        {
            sum += term;
            term *= x / (i + 1);
        }

        Console.WriteLine("Szacowana wartość e^{0} przy użyciu {1} wyrazów: {2}", x, n, sum);
    }
}
