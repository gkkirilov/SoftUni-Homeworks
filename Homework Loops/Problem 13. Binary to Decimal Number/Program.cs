using System;

class Program
{
    static void Main()
    {

        Console.Write("Input a nubmer n:");
       string n = Console.ReadLine();
       long p = long.Parse(n);
        double number = 0;



        long k = 0;
        for (int i = 0; i<=n.Length ; i++)
        {
            k = p % 2;
            p = p / 10;
            
           number += k*Math.Pow(2, i);
        }


     Console.WriteLine(number);
      


    }
}

