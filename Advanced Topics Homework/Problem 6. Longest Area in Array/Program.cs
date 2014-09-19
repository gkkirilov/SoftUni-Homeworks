using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Longest_Area_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            string[] arrStr = new string[n];
            int a=0,max=0;
            
            for (int i = 0; i < n; i++)
            {
                arrStr[i] = Console.ReadLine();
            }
            string biggest = arrStr[0];
            for (int i = 1; i < n; i++)
            {
                if (arrStr[i].Length == arrStr[i-1].Length)
                {
                    if (arrStr[i] == arrStr[i-1])
                    {
                        a++;
                        if (a > max)
                        {
                            max = a;
                            biggest = arrStr[i];
                        }
                    }
                    else a=0;
                }
                else a = 0;
            }
            for (int i = 0; i < max+1; i++)
            {
                Console.WriteLine(biggest);
            }
            

        }
    }
}
