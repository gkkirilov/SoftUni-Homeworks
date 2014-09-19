using System;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        string lens = new string('*', 2 * n-2);
        string glass = new string('/', 2 * n - 2);
        string blank = new string(' ', n-1);
        string bridge = new string('-', n-1);
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.WriteLine(" "+lens+" " + blank+" " + lens+" ");
            } 
            else
            {
                if (i == n / 2) Console.WriteLine("*{0}*{1}*{0}*", glass, bridge);
                else Console.WriteLine("*{0}*{1}*{0}*", glass, blank, glass);
            }
        }
    }
}
