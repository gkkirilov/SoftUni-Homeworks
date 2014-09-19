using System;

 class Program
{
    static void Main()
    {
        Console.Write("Input a:");
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 499) Console.WriteLine("Invalid number");
        Console.Write("Input b:");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Invalid number");
        Console.Write("Input c:");
        double c;
        while (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Invalid number");

        string hack = String.Empty;
        Console.Write("|{0:X}{1, -10}|{2}|{1, -10}{3:F2}|", a, hack, Convert.ToString(a, 2).PadLeft(10, '0'), b);

        bool check = Convert.ToString(c).IndexOf(".") > 0;
        Console.WriteLine(check ? "{0:0.000}" : "{0}", c);

        Console.WriteLine();
    }
}