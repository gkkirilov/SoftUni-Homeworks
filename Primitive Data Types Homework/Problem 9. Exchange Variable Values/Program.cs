using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 5, c = 0;
        Console.WriteLine("a:{0}  b:{1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("a:{0}  b:{1}", a, b);
    }
}
