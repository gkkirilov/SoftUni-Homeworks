using System;
using System.Diagnostics;
using System.Threading;




class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        
        int weekendsInYear = 52;
        double total=0;
        string leapYear;
        string root = "t";
        Console.Write("write \"t\" for leap and \"f\" for not leap year:");
        leapYear = Console.ReadLine();
        Console.Write("Input numbers of holidays:");
        int p;   //number of holidays in the year (which are not Saturday or Sunday).
        
        p = int.Parse(Console.ReadLine());
        Console.Write("Input number of weekends:");
        int h; //number of weekends that Joro spends in his hometown
        h = int.Parse(Console.ReadLine());
        stopwatch.Start();
        
        Console.WriteLine(weekendsInYear);
        total = total + h;
        weekendsInYear = weekendsInYear - h;
        total =total+ (weekendsInYear * 2 / 3.0);
        total = total +(p / 2.0);
        bool result;
        result = leapYear.Equals(root);
        if (result == true) total =total + 3-0.51;
        else { total = total - 0.51; }
        total = Math.Round(total);
        Console.WriteLine(total);
        stopwatch.Stop();
        Console.WriteLine("Time elapsed: {0}",
         stopwatch.Elapsed);
        

            





    }
}

