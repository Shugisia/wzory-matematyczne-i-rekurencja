using System;

public class Program
{
    public static void Main(string[] args)
    {
        int podstawa, wykladnik;

        Console.WriteLine("Podaj podstawę mnożenia:");
        podstawa = (int)inputValue();
        Console.WriteLine("Podaj wykładnik potęgowania");
        wykladnik = (int)inputValue();

        int wynik = 1;

        for (int i = 1; i <= wykladnik; i++)
        {
            wynik *= podstawa;
        }

        Console.WriteLine("Wynik potęgowania: " + wynik);
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
