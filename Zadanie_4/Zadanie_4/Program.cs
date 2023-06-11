using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj kwotę początkową na koncie: ");
        decimal kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie konta w skali roku (%): ");
        decimal oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal kwotaKoncowa = kwotaPoczatkowa;
        decimal odsetki = 0;

        for (int i = 0; i < liczbaMiesiecy; i++)
        {
            odsetki = kwotaKoncowa * (oprocentowanie / 12 / 100);
            kwotaKoncowa += odsetki;
        }

        decimal podatekBelki = kwotaKoncowa * 0.19m;
        kwotaKoncowa -= podatekBelki;

        kwotaKoncowa = Math.Round(kwotaKoncowa, 2);
        odsetki = Math.Round(odsetki, 2);

        Console.WriteLine("Kwota zarobiona (po uwzględnieniu podatku Belki) wynosi: {0}", kwotaKoncowa);
        Console.WriteLine("Twoje odsetki (po uwzględnieniu podatku Belki) wynoszą: {0}", odsetki);
    }
}
