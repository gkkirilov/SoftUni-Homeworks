using System;

class Program
{
    static void Main()
    {

        Console.Write("Input a digit:");
        double digit = double.Parse(Console.ReadLine());
        int sum=-1;
        for (int i = 0; i < 9; i++)
        {
            if (digit == i)
            {
                sum=0;
                sum=i;
                break;
            }
        }
        if (sum==1) Console.WriteLine("one");
        else if (sum == 2) Console.WriteLine("two");
        else if (sum==3) Console.WriteLine("three");
        else if (sum == 4) Console.WriteLine("four");
        else if (sum == 5) Console.WriteLine("five");
        else if (sum == 6) Console.WriteLine("six");
        else if (sum == 7) Console.WriteLine("seven");
        else if (sum == 8) Console.WriteLine("eight");
        else if (sum == 9) Console.WriteLine("nine");
        else if (sum == 0) Console.WriteLine("zero");
        else Console.WriteLine("not a digit");





    }
}

