using System;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {


         

            double[] number=new double[5];
            for (int i = 0; i < number.Length; i++)
			{
                Console.Write("Input number:");
            number[i] = double.Parse(Console.ReadLine());
			 
			}
            double biggestNumber = number.Max();
            Console.WriteLine(biggestNumber);








        }
    }

