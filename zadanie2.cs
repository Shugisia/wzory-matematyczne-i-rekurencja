using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Podaj długość ciągu Fibonacciego: ");
        n = (int)inputValue();
        CiagFibonacci(n);
    }

    public static void CiagFibonacci(int n)
    {
        int pierwszy = 0; 
        int drugi = 1; 

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(pierwszy);
            int nastepny = pierwszy + drugi;
            pierwszy = drugi;
            drugi = nastepny;
        }
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}