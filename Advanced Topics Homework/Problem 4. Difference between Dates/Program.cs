using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Difference_between_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime d1=DateTime.Parse(Console.ReadLine());
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine((-(d1 - d2)).TotalDays); ;
        }
    }
}
