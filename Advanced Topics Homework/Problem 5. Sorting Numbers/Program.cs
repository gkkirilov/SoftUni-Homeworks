using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Sorting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(Arr);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }







        }
    }
}
