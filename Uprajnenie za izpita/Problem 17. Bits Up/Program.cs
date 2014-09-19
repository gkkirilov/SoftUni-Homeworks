using System;

class BitsUp
{
    static void Main()
    {
        Console.WriteLine(0%2);
        int number = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        
        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if ((index % step == 1) || (step == 1 && index > 0))
                {
                    num = num | (1 << bit);
                }
                index++;
            }
            Console.WriteLine(num);
        }
    }
}
