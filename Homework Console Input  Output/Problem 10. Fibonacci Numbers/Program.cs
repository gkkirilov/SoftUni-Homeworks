using System;

class Fibonacci
{
    static void Main()
    {
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;
        
        Console.Write("Input a number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        for (int i = 1; i < n; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(sum);

        }

    }
}