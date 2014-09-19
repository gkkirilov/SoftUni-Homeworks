using System;



    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0, test, sum2 = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                test = int.Parse(Console.ReadLine());
                if (i < n) sum += test;
                else sum2 = sum2 + test;

            }

            if (sum == sum2) Console.WriteLine("Yes, sum={0}", sum);
            else
            {
                if(sum>sum2)
                Console.WriteLine("No, diff={0}", sum-sum2);
                else Console.WriteLine("No, diff={0}", sum2 - sum);
            }




        }
    }

