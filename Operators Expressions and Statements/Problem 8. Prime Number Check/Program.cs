using System;



class Program
{
    static void Main()
    {
        Console.Write("Input number:");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        if (n == 1) sum = 1;
            for (int i = 1; i <= n; i++)
			{
			 if(n%i==0) sum++;
			}
       if (sum==2) Console.WriteLine("Its prime");
       else    Console.WriteLine("Its not prime");




    }
}

