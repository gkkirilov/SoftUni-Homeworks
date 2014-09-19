using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input A:");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Input B:");
        double B = double.Parse(Console.ReadLine());
        Console.Write("Input C:");
        double C = double.Parse(Console.ReadLine());
        double D = (B * B) - (4 * A * C);

        if (D < 0)
        {
            Console.WriteLine("D < 0 - > No roots");
        }
        else if (D > 0)
        {
            Console.WriteLine("x1={0}", (-B - Math.Sqrt(D)) / (2 * A));
            Console.WriteLine("x2={0}", (-B + Math.Sqrt(D)) / (2 * A));
        }
        else
        {
            Console.WriteLine("D = 0 x1=x2={0}", (-B / (2 * A)));
        }


    }



}


