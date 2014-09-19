using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineDigit
{
class Program
{
    static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int  diff= int.Parse(Console.ReadLine());
            int a=0, b=0, c=0, d=0, e=0, f=0, h=0,g=0,i=0,count=0;
            
                for ( a = 1; a < 8; a++)
                {
                    for ( b = 1; b < 8; b++)
                    {
                        for (c = 1; c < 8; c++)
                        {
                             for ( d = 1; d < 8; d++)
			                {
			                     for ( e = 1; e < 8; e++)
			                    {
			                         for ( f = 1; f < 8; f++)
			                        {
			                             for ( h = 1; h < 8; h++)
			                            {
			                                for ( g = 1; g < 8; g++)
			                                {
			                                     for ( i = 1; i < 8; i++)
			                                    {
			                                            
                                                     if(sum==a+b+c+d+e+f+h+g+i)
                                                     {

                                                         if ((a * 100 + b * 10 + c) <= (d * 100 + e * 10 + f) && (d * 100 + e * 10 + f) - (a * 100 + b * 10 + c) == diff && (h * 100 + g * 10 + i) - (d * 100 + e * 10 + f) == diff)
                                                         {
                                                             Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", a, b, c, d, e, f, h, g, i);
                                                             count++;
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
                }
                if (count == 0) Console.WriteLine("No");



            }
            
           

        }
}

