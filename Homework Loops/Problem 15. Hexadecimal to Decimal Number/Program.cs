using System;
using System.Linq;
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            long number = 0;
            long power = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int num;
                switch (hex[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                    default: num = (int)hex[i] - 48; break;
                }
                number += num * power;
                power *= 16;
            }
            Console.WriteLine(number);

        }
    }

