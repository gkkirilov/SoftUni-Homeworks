using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a nubmer n:");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Input a nubmer x:");
        double x = double.Parse(Console.ReadLine());
        double number = 1;

        double factoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            factoriel = factoriel * i;

            number = number + factoriel / Math.Pow(x, i);
        }


        Console.WriteLine(Math.Round(number, 5));


    }
}

