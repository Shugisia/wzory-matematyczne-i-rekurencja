using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź kwotę początkową:");
        decimal kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadź oprocentowanie w skali roku:");
        decimal oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadź liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal kwotaZarobiona = ObliczKwoteZarobiona(kwotaPoczatkowa, oprocentowanie, liczbaMiesiecy);

        Console.WriteLine("Kwota zarobiona (uwzględniając podatek Belki): {0}", kwotaZarobiona);
    }

    static decimal ObliczKwoteZarobiona(decimal kwotaPoczatkowa, decimal oprocentowanie, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaZarobiona = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);

        decimal podatekBelki = 0.19m * (kwotaZarobiona - kwotaPoczatkowa);

        kwotaZarobiona -= podatekBelki;

        return kwotaZarobiona;
    }
}