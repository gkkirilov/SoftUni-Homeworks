using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0) Console.WriteLine("odd? false");
        else Console.WriteLine("odd? true");




    }
}

