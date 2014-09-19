using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (char c = (char)033; c <= (char)255; c++)
        {
            Console.WriteLine(c);
        }




    }
}

