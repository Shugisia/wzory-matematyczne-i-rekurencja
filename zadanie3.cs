using System;

class Program
{
    static void Main(string[] args)
    {
        int n, k;

        do
        {
            Console.Write("Podaj liczbę n (większą lub równą 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k (większą lub równą 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        
        int nSilnia = Silnia(n); //n!       
        int kSilnia = Silnia(k);  //k!
       
        int m = (nSilnia - kSilnia) / kSilnia; //m = (n! - k!) / k!

        Console.WriteLine($"Wartość m=(n!-k!)/k! wynosi: {m}");
        Console.ReadLine();
    }

    static int Silnia(int numer)
    {
        int psilnia = 1;
        for (int i = 2; i <= numer; i++)
        {
            psilnia *= i;
        }
        return psilnia;
    }
}