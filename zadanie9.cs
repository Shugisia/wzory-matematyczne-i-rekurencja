using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Podaj liczbę do odwrócenia: ");
        int liczba = int.Parse(Console.ReadLine());
        int odwliczba = OdwLiczba(liczba);

        Console.WriteLine(odwliczba);
    }

    public static int OdwLiczba(int liczba)
    {
        int odwliczba = 0;

        while (liczba > 0)
        {
            int remainder = liczba % 10;
            odwliczba = (odwliczba * 10) + remainder;
            liczba /= 10;
        }

        return odwliczba;
    }
}