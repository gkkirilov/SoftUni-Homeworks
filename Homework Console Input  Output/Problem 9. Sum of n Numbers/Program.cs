using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Input number {0}:",i);
                int a = int.Parse(Console.ReadLine());
                sum = sum + a;
                
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }

