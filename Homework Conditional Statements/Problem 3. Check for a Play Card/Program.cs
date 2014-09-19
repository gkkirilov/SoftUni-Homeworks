using System;

class Program
{
    static void Main()
    {
        string card;
        Console.Write("Input character:");
        int sum = 0;
        card = Console.ReadLine();
        string[] karti = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        for (int i = 0; i <= 12; i++)
        {
            if (card == karti[i])
            {
                sum = sum + 1;
            }

        }

        if (sum == 1) Console.WriteLine("Valid card sign? yes");
        else Console.WriteLine("Valid card sign? no");



    }
}

