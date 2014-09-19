using System;

class Program
{
    static void Main()
    {

        Console.Write("Input number:");
        int number= int.Parse(Console.ReadLine());
        int n=number/100%10;
        if(n==7)
            Console.WriteLine("true");
        else Console.WriteLine("false");





    }
}

