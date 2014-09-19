using System;

    class Program
    {
        static void Main()
        {
            int startOfWeek = int.Parse(Console.ReadLine());
            int eatingDays = int.Parse(Console.ReadLine());
            
            int sumMellong = 0, sumWater = 0;
            for (int i = startOfWeek; i < eatingDays+startOfWeek; i++)
            {
                if (i % 7 == 1) sumWater = sumWater + 1;
                if (i % 7 == 2) sumMellong = sumMellong + 2;
                if (i % 7 == 3)
                {
                    sumWater = sumWater + 1;
                    sumMellong = sumMellong + 1;
            }
                if (i % 7 == 4) sumWater = sumWater + 2;
                if (i%7==5)
                {
                    sumWater = sumWater + 2;
                    sumMellong = sumMellong + 2;
                }
                if(i%7==6)
                {
                    sumWater=sumWater+1;
                    sumMellong=sumMellong+2;
                }
            }

            if (sumMellong > sumWater) Console.WriteLine("{0} more melons",sumMellong-sumWater);
            if (sumMellong < sumWater) Console.WriteLine("{0} more watermelons",sumWater-sumMellong);
            

            if (sumMellong==sumWater)
            {
                Console.WriteLine("Equal amount: {0}",sumWater);
            }


        }
    }

