
using System;

class Program
{
    static void Main()
    {



        int n;
        Console.Write("Input score:");
        n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 4) Console.WriteLine(n*10);
            else if(n>3 && n<7)Console.WriteLine(n*100);
                else if(n>6 && n< 10)Console.WriteLine(n*1000);
        else if (n > 9 || n < 1) Console.WriteLine("Invalid score");

    }




        
}

