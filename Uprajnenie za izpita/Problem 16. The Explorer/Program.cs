using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //string lens = new string('*',n);
            string diamond = new string('*', n);
            string middle = new string('-', n);
            string frameOne = new string('-', n / 2);
            //string frameTwo = new string('*', n / 2);
            int count = 1,count2=1;

            for (int i = 0; i < n; i++)
            {
                if(i==0 || i==n-1) Console.WriteLine(frameOne+"*"+frameOne);
                else
                {
                    if (i < n /2+1)
                    {
                        
                        string frameTwo = new string('*', 1);
                        string sideFrame = new string('-', n / 2 - i);
                        string middleFrame = new string('-',  count);
                        Console.WriteLine(sideFrame + frameTwo + middleFrame + frameTwo + sideFrame);
                        count = count + 2;
                        if (i==n/2) count = count-4;
                      
                    
                    }
                    else
                    {
                        
                        string frameTwo = new string('*', 1);
                        string sideFrame = new string('-', count2);
                        count2++;
                        string middleFrame = new string('-', count);
                         count = count - 2;
                        Console.WriteLine(sideFrame + frameTwo + middleFrame + frameTwo + sideFrame);
                        
                    }
                }

            }

           




        }
    }

