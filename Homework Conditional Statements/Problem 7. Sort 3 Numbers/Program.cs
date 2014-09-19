using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Input number one:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input number two:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input number three:");
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c) Console.WriteLine("{0} {1} {2}",a,b,c);
                else if (c > a) Console.WriteLine("{0} {1} {2}", c,a,b);
                else Console.WriteLine("{0} {1} {2}", a, c, b);
                
                
            }
            else
            {
                if (a > c) Console.WriteLine("{0} {1} {2}", b,a,c);
                else if (c > a) Console.WriteLine("{0} {1} {2}", c, b, a);
                else Console.WriteLine("{0} {1} {2}", b, c, a);

            }
            









        }
    }

