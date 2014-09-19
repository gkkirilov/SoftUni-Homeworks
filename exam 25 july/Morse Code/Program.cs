using System;


    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
           int aa = number % 10;
           int bb = number / 10 % 10;
           int cc = number / 100 % 10;
           int dd = number / 1000 % 10;
           int sum = aa + bb + cc + dd;
           int product;
           int NO = 0;
           
           for (int a = 0; a < 6; a++)
           {
               for (int b = 0; b < 6; b++)
               {
                   for (int c = 0; c < 6; c++)
                   {
                       for (int d = 0; d < 6; d++)
                       {
                           for (int e = 0; e < 6; e++)
                           {
                               for (int f = 0; f < 6; f++)
                               {
                                   product = a*b*c*d*e*f;

                                   if (product == sum)
                                   {
                                       
                                       number = 100000 * a + 10000 * b + 1000 * c + 100 * d + 10 * e + f;
                                       string All = "";
                                       for (int q = 0; q < 6; q++)
                                       {
                                          int count = (int)Math.Pow(10, q);
                                                        count = number / count;
                                                      int  num = count % 10;
                                                      if (num == 0) All = All + "-----|";
                                                      if (num == 1) All = All + ".----|";
                                                      if (num == 2) All = All + "..---|";
                                                      if (num == 3) All = All + "...--|";
                                                      if (num == 4) All = All + "....-|";
                                                      if (num == 5) All = All + ".....|";
                                                      NO++;
                                       }
                                       Console.WriteLine(All);







                                   }
                               }
                           }  
                       }
                   }
               }
           }



           if (NO == 0) Console.WriteLine("No");


        }
    }

