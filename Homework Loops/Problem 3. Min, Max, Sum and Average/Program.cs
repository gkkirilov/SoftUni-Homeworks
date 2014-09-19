using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input a nubmer:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        double avg,sum=0.0;
        int min=999999999 , max=-99999999  ;
        for (int i = 0; i < n; i++)
        {

            Console.Write("Input a nubmer:");
            arr[i] = int.Parse(Console.ReadLine());
            
            

            if (arr[i] < min) min = arr[i];
            if (arr[i] > min) max = arr[i];
        
            sum = sum + arr[i];



            

        }
        avg = sum / n;
        avg=Math.Round(avg, 2);
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3}", min, max, sum, avg);
    



    }
}

