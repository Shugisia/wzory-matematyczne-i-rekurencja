using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę naturalną posiadającą co najmniej 3 cyfry: ");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 100)
        {
            Console.WriteLine("Podana liczba musi mieć przynajmniej 3 cyfry.");
        }
        else
        {
            Console.WriteLine("Poszczególne cyfry liczby:");

            string liczbaTekst = liczba.ToString();
            foreach (char cyfra in liczbaTekst)
            {
                Console.WriteLine(cyfra);
            }
        }
    }
}






