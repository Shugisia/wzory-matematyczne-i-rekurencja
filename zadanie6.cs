using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = 0;
        int factorial = 1;

        while (factorial <= x)
        {
            n++;
            factorial *= n;
        }

        if (factorial == x)
        {
            Console.WriteLine("Liczba {0} jest silnią liczby {1}.", x, n);
        }
        else
        {
            Console.WriteLine("Liczba {0} nie jest silnią żadnej liczby.", x);
        }
    }
}