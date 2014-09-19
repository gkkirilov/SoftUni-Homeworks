using System;

  class WorkHours
    {
        static void Main()
        {
           
            int h = int.Parse(Console.ReadLine());
            
            int d = int.Parse(Console.ReadLine());
            
            double p = double.Parse(Console.ReadLine());
            p = p / 100;
            
            double hours = 0.9 * d * 12*p;
            hours = Math.Floor(hours);
            if (h <= hours) Console.WriteLine("Yes\n{0}",hours-h);
            else Console.WriteLine("No\n{0}",hours-h);



        }
    }

