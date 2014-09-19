using System;
using System.Diagnostics;
using System.Threading;


class Program
{
    static void Main()
    {
        


        int n;
        int parvaSuma=0,vtoraSuma=0;
        int razlika=0;
        Console.Write("Input n:");
        n = int.Parse(Console.ReadLine());
        int p = 2 * n;
        int[] myArray=new int[2*n] ;
        for (int i = 0; i < p; i++)
        {
            Console.Write("Element[{0}]:",i+1);
            myArray[i] = int.Parse(Console.ReadLine());
            if (i < n) parvaSuma = parvaSuma + myArray[i];
            else vtoraSuma = vtoraSuma + myArray[i];
        }

        if (parvaSuma == vtoraSuma) Console.WriteLine("yes,sum={0}", parvaSuma);
        else
        {
            if (parvaSuma > vtoraSuma) razlika = parvaSuma - vtoraSuma;
            else razlika = vtoraSuma - parvaSuma;
            Console.WriteLine(razlika);
        }
    }
            

    }


