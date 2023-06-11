using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = 1;
        int factorial = 1;

        while (factorial < x)
        {
            n++;
            factorial *= n;
        }

        if (factorial == x)
        {
            Console.WriteLine("{0} jest silnią liczby {1}", x, n);
        }
        else
        {
            Console.WriteLine("{0} nie jest silnią żadnej liczby naturalnej", x);
        }
    }
}
