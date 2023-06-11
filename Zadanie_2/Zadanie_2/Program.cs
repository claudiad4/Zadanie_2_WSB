using System;

class Program
{
    static void Fibonacci(int n)
    {
        int first = 0;
        int second = 1;

        Console.Write("Ciąg Fibonacciego dla {0} wyrazów: ", n);

        if (n >= 1)
            Console.Write("{0} ", first);
        if (n >= 2)
            Console.Write("{0} ", second);

        for (int i = 3; i <= n; i++)
        {
            int next = first + second;
            Console.Write("{0} ", next);

            first = second;
            second = next;
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę wyrazów, które chciałbyś, aby wygenerował algorytm: ");
        int n = int.Parse(Console.ReadLine());

        Fibonacci(n);
    }
}
