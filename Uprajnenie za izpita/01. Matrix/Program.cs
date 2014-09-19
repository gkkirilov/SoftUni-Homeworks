using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < 4*n; j+=4)
                {

                    if ((j + i)%9<1) Console.Write(" ");
                    Console.Write(j+i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
