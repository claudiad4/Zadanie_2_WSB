using System;

class Program
{
    static long Power(long baseNum, long exponent)
    {
        long result = 1;

        while (exponent > 0)
        {
            if (exponent % 2 == 1)
                result *= baseNum;

            baseNum *= baseNum;
            exponent /= 2;
        }

        return result;
    }

    static void Main(string[] args)
    {
        long baseNum = 2;
        long exponent = 5;

        long result = Power(baseNum, exponent);
        Console.WriteLine(result);  // Wyświetli 32
    }
}
