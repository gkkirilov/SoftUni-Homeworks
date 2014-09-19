using System;

class Program
{
    static void Main()
    {
        Console.Write("Input number one:");
        double numberOne = double.Parse(Console.ReadLine());
        Console.Write("Input number two:");
        double numberTwo = double.Parse(Console.ReadLine());
        Console.Write("Input number three:");
        double numberThree = double.Parse(Console.ReadLine());
        int a, b, c;
        a = Math.Sign(numberOne);
        b = Math.Sign(numberTwo);
        c = Math.Sign(numberThree);
        if (a == 0 || b == 0 || c == 0) Console.WriteLine("result: 0");
        else if (a == 1 && b == 1 && c == 1) Console.WriteLine("result: +");
        else if (a == 1 && b == 1 && c == -1) Console.WriteLine("result: -");
        else if (a == 1 && b == -1 && c == -1) Console.WriteLine("result: +");
        else if (a == -1 && b == -1 && c == -1) Console.WriteLine("result: -");
        else if (a == -1 && b == -1 && c == 1) Console.WriteLine("result: +");
        else if (a == -1 && b == 1 && c == -1) Console.WriteLine("result: +");
        else if (a == -1 && b == 1 && c == 1) Console.WriteLine("result: -");
        else if (a == 1 && b == -1 && c == 1) Console.WriteLine("result: -");





    }
}

