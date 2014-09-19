using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_14.Longest_Word_in_a_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();
            string[] words = Regex.Split(text, @"\W");
            int max=0;
            string maximum="a";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max) 
                {
                    max=words[i].Length;
                    maximum = words[i];
                }// Console.WriteLine(words[i]);
            }
            Console.WriteLine(maximum);
        }
    }
}
