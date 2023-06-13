using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int numerPrzyb, i;
        double wartoscPrzyb;

        for (i = 0; i <= numerPrzyb; i++)
        {
            wartoscPrzyb = wartoscPrzyb + sqrt(wartoscPrzyb) / silnia;
        }
        Console.WriteLine(wartoscPrzyb);

        static int silnia(int numer)
        {
            int psilnia = 1;
            for (int i = 2; i <= numer; i++)
            {
                psilnia *= i;
            }
            return psilnia;
        }
    }
}
