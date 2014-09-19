using System;
using System.Numerics;
    class Program
    {
        static void Main()
        {
            Console.Write("Input a nubmer n:");
            int n = int.Parse(Console.ReadLine());
            
            BigInteger fOne = 1,fTwo=1;


            if (1 < n && n < 100)
            {

                for (int i = n,y=2; i < 2*n; i++,y++)
                {
                    fOne = fOne * i;
                    fTwo = fTwo * y;
                }
                Console.WriteLine(fOne/fTwo*2);
            }
            else
            {
                Console.WriteLine("Out of range");
            }




        }
    }

