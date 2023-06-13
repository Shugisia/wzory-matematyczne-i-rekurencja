using System;

class Program
{
    static void Main()
    {
        Console.Write("Wprowadź liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pary liczb o sumie równiej {0}:", n);
        ParyLiczb(n);
    }

    static void ParyLiczb(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int skladowa = n - i;
            Console.WriteLine("{0} + {1} = {2}", i, skladowa, n);
        }
    }
}