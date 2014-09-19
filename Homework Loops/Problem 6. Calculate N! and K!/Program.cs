using System;

class Program
{
    static void Main()
    {


        Console.Write("Input a nubmer n:");
        ulong n = ulong.Parse(Console.ReadLine());
        Console.Write("Input a nubmer k:");
        ulong k = ulong.Parse(Console.ReadLine());
       

        if (1 < k && k < n && n < 100)
        {
            ulong result = 1;
            for (ulong index = k + 1; index <= n; index++)
            {
                result *= (ulong)index;
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }

    }
}

