using System;

class Program
{
    static void Main()
    {

        Console.Write("Input X:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input Y:");
        double y = double.Parse(Console.ReadLine());
        if ((x * x) + (y * y) <= (2 * 2)) Console.WriteLine("true");
        else Console.WriteLine("false");







    }
}

