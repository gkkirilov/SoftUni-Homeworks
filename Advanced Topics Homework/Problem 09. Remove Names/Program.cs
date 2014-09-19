﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_09.Remove_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            List<string> names = new List<string>();

            string[] secondLine = Console.ReadLine().Split(' ');

            for (int i = 0; i < firstLine.Length; i++)
            {
                names.Add(firstLine[i]); 

                for (int j = 0; j < secondLine.Length; j++)
                {
                    if (firstLine[i] == secondLine[j])
                    {
                        names.Remove(firstLine[i]); 
                    }
                }
            }

            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
