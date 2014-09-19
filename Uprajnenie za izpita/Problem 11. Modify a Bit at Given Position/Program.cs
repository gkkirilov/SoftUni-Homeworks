using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Modify_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("N = ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Bit value = "); //1 or 0
            sbyte bitValue = sbyte.Parse(Console.ReadLine());

            Console.Write("Position = ");
            sbyte position = sbyte.Parse(Console.ReadLine());
            
            int result;

            if (bitValue == 0)
            {
                int mask = ~(1 << position);
                result = number & mask;
            }
            else
            {
                int mask = 1 << position;         
                result = number | mask;      
            }

            string binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');
            string binaryResult = Convert.ToString(result, 2).PadLeft(16, '0');

            Console.WriteLine("Result = {0}\nBinary representation of N: {1}" +
                "\nBinary final result:        {2}", result, binaryNumber, binaryResult);





        }
    }
}
