using System;

class Program
{
    static void Main()
    {

        Console.Write("Input a number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 35 == 0) Console.WriteLine("Divided by 7 and 5? true");
        else Console.WriteLine("Divided by 7 and 5? false");



    }
}

