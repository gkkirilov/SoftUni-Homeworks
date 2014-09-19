﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18.Trailing_Zeroes_in_N
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int zeroCount = 0;
            int d;
            for (int i = 5; i <= number; i += 5)
            {
                d = i;
                while (d % 5 == 0)
                {
                    d /= 5;
                    zeroCount++;
                }
            }
            Console.WriteLine(zeroCount);




        }
    }
}
