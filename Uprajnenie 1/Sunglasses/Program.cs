using System;

class Program
{
    static void Main()
    {
        Console.Write("Input n (odd number):");
        
        int n = int.Parse(Console.ReadLine());
        int height=n, lenght=2*n;
        string frame = new string('*', 2 * height);
        string lenses = new string('/',lenght-2);
        string most = new string('|', n);
        string blank = new string(' ', n);

        

        for (int i = 0; i < n; i++)
        {

            if (i == 0 || i == n-1)
            {
                Console.WriteLine("{0}{1}{0}", frame, blank);

            }
            else
            {
                if (i == (n / 2) ) Console.WriteLine("*{0}*{1}*{0}*", lenses, most);

                else Console.WriteLine("*{0}*{1}*{0}*", lenses, blank);



            }
           
            

           

        }
        



    }
}

