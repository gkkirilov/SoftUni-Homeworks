using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Fibonaci_Numbers
{
    class Program
    {
       static int Fibunachi( int number)
        {
            
            int numberOne = 0, numberTwo = 1;
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                
                sum = numberOne + numberTwo;
                numberOne = numberTwo;
                numberTwo = sum;
            }
            return sum;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = Fibunachi(n);
            Console.WriteLine(sum);
        }
    }
}
