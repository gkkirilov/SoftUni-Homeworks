using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input number:");
        int number = int.Parse(Console.ReadLine());
        int a=0, b, c, d;
        d = number % 10;
        c = number / 10 % 10;
        b = number / 100 % 10;
        a = number / 1000 % 10;
        Console.WriteLine("Sum:{0}",a+b+c+d);
        Console.WriteLine("Reversed {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("last digit in front {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("second and third digits exchanged {0}{1}{2}{3}", a, c, b, d);





    }
}

