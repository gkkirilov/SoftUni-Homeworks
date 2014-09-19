using System;

class Program
{
    static void Main()
    {
        Console.Write("1---> int \n2---> double\n3---> string\nplease choose a type:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Please enter an int:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(1 + a);
                break;
            case 2: Console.Write("Please enter a double:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(1+b);
                break;
            case 3: Console.Write("Please enter a string:");
                string c = Console.ReadLine();
                Console.WriteLine("{0}*", c);
                break;
            default: Console.WriteLine("the digit is not in range"); break;


        }



    }
}

