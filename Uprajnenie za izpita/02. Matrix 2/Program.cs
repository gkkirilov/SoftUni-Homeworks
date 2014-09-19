using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Matrix_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input a number:");
            int n = int.Parse(Console.ReadLine());
            int count = 1,index=0;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        
                        matrix[j, i] = count;
                        count++;
                        index = n-1;
                    }
                    else
                    {
                        
                        matrix[index,i] = count;
                        count++;
                        index--;
                       
                    }
                }


            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
