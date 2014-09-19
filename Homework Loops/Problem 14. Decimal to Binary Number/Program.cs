using System;


    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string binary = "";
            while (number != 0)
            {
                int remain = (int)number % 2;
                number /= 2;
                binary = remain + binary;
            }
               
               Console.WriteLine(binary);
           
          
        }

    }

