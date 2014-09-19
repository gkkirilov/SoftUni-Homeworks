using System;
using System.Collections.Generic;

namespace WorkHours
{
    class Program
    {
        static void Main()
        {

            int diff = int.Parse(Console.ReadLine());
            int sum = 0;

            int number = 0, num = 0, count;

            for (int a = 1; a < 6; a++)
            {
                for (int b = 1; b < 6; b++)
                {
                    for (int c = 1; c < 6; c++)
                    {
                        for (int d = 1; d < 6; d++)
                        {
                            for (int e = 1; e < 6; e++)
                            {
                                for (int f = 1; f < 6; f++)
                                {
                                    for (int g = 1; g < 6; g++)
                                    {
                                        for (int h = 1; h < 6; h++)
                                        {
                                            if (a != 2 && b != 2 && c != 2 && d != 2 && e != 2 && f != 2 && g != 2 && h != 2)
                                            {
                                                if (a + b + c + d - diff == f + g + h + e || a + b + c + d == e + f + g + h - diff)
                                                {
                                                    number = 10000000 * a + 1000000 * b + 100000 * c + 10000 * d + 1000 * e + 100 * f + 10 * g + h;
                                                    string all="";
                                                    for (int q = 8; q != -1; q--)
                                                    {
                                                        count = (int)Math.Pow(10, q);
                                                        count = number / count;
                                                        num = count % 10;

                                                        if (num == 1) all=all+'k';
                                                        if (num == 3) all = all + 's';
                                                        if (num == 4) all = all + 'n';
                                                        if (num == 5) all = all + 'p';
                                                        

                                                    }


                                                    sum++;
                                                    Console.WriteLine(all);
                                                }




                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (sum == 0) Console.WriteLine("No");



        }
    }

}