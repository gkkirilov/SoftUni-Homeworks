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

        Console.WriteLine(Math.Max(Math.Max(numberOne , numberTwo), numberThree ));





    }
}

