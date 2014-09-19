using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Input a nubmer n:");
        string[] Arr = Console.ReadLine().Split();

        int sumOdd = 1, sumEven = 1;

        for (int i = 0; i < Arr.Length; i++)
        {

            if (i % 2 == 0) sumEven *= Convert.ToInt32(Arr[i]);
            else sumOdd *= Convert.ToInt32(Arr[i]);
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("yes product {0}", sumOdd);

        }
        else
        {
            Console.WriteLine("no\nodd_product={0}\neven_product={1}",sumOdd,sumEven);

        }

    }
}

