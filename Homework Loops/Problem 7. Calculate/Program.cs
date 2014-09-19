using System;
using System.Numerics;
    class Program
    {
        static void Main()
        {

            Console.Write("Input a nubmer n:");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("Input a nubmer k:");
            ulong k = ulong.Parse(Console.ReadLine());
            BigInteger fOne = 1;


            if (1 < k && k < n && n < 100)
            {
                BigInteger result = 1;
                for (ulong index = k+1 , count=1; index <= n; index++  , count++)
                {
                    result =result*index;
                    fOne=fOne*count;

                }
                Console.WriteLine(result*1/fOne);
               
            }
            else
            {
                Console.WriteLine("out of range");
            }




        }
    }

