using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Bit_at_Positin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number:");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.Write("Number:");
            int placeNumber = int.Parse(Console.ReadLine());
            bool boolOne = true;

            int moveRight = inputNumber >> placeNumber;

            int bit = moveRight & 1;
            
            if (bit == 1) Console.WriteLine(boolOne);
            else Console.WriteLine(!boolOne);
            


        }
    }
}
