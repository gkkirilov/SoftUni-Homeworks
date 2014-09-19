using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input First Number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Input Secound Number:");
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("{0} is greater.",greaterNumber);





    }
}

