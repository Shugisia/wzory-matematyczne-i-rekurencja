using System;

class Program
{
    static void Main(string[] args)
    {
        int dolnaGranica = 1;
        int gornaGranica = 20;
        bool odgadnieta = false;

        while (!odgadnieta)
        {
            int srodek = (dolnaGranica + gornaGranica) / 2;
            Console.WriteLine($"Czy liczba, którą masz na myśli, to {srodek}? Podaj odpowiedź (-1 dla mniejszej, 1 dla większej, 0 jeśli odgadłem):");
            int odpowiedz = Convert.ToInt32(Console.ReadLine());

            if (odpowiedz < 0)
            {
                gornaGranica = srodek - 1;
            }
            else if (odpowiedz > 0)
            {
                dolnaGranica = srodek + 1;
            }
            else
            {
                odgadnieta = true;
            }
        }

        Console.WriteLine("Odgadłem liczbę!");
    }
}