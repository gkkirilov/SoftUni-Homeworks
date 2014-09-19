using System;

class Program
{
    static void Main()
    {
        Console.Write("Input number one:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input number two:");
        double b = double.Parse(Console.ReadLine());

        if (b > a)
        {
            Console.WriteLine("{0} {1}",a,b);
        }
        else
        {
            Console.WriteLine("{0} {1}",b,a);

        }





    }
}

