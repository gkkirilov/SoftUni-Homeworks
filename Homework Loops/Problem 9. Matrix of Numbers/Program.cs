using System;

    class Program
    {
        static void Main()
        {

            Console.Write("Input a nubmer n:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix= new int[n,n];
            int broqch = 1;


            for (int i = 0; i < n; i++)
            {
                broqch = i;
                for (int j= 0; j < n; j++)
                {
                    
                    
                    matrix[i, j] = broqch+1;
                    Console.Write(matrix[i,j]+"  ");
                    broqch++;
                }
                Console.WriteLine();
            }




        }
    }

