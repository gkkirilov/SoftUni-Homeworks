using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_09.Bit_from_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(1<<5,2));
            Console.Write("Number:");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.Write("Number:");
            int placeNumber = int.Parse(Console.ReadLine());
            

            int moveRight = inputNumber >> placeNumber;
            
            int bit = moveRight & 1;

            Console.WriteLine("Bit #{0} is {1}", placeNumber, bit);
        }
    }
}
