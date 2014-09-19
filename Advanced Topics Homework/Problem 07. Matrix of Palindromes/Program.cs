using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                
                for (int j = 0; j < b; j++)
                {
                   // Console.Write(12);
                    Console.Write("{0}{1}{2} ", (char)(97 + i), (char)(97 + j+i), (char)(97 + i));
                }

                Console.WriteLine();
            }








        }
    }
}
