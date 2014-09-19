using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[,] matrix = new int[8 * num, 4];
        int[] Path = new int[8 * num];
        string firstName = "";
        int[] arr2 = new int[8 * num];
        for (int i = 0; i < num; i++)
        {
            int[] Arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), Int32.Parse);
            for (int j = 0; j < 8; j++)
            {
                arr2[j + 8 * i] = Arr[j];
            }
        }

      
        for (int i = 0; i < 8*num; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int startingPosition = arr2[0 + 8 * i];

            }
        }

    }







}


