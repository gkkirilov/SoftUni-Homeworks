using System;

class Program
{
    static void Main()
    {

        Console.Write("Input a nubmer n:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Input a nubmer min:");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Input a nubmer max:");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min,max+1));
        }

    }
}

