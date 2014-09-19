using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Problem_2.Prime_Checker
{
    class Program
    {

        static bool IsPrime(ulong number)
        {
            
            if (number == 1) return false;
            if (number == 2) return true;

            for (ulong i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;



        }
        static void Main(string[] args)
        {
            bool iha;
            
            ulong n = ulong.Parse(Console.ReadLine());

            iha = IsPrime(n);
            Console.WriteLine(iha);






        }
    }
}
