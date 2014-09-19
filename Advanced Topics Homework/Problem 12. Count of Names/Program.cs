using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Count_of_Names
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the names");
            string[] names = Console.ReadLine().Split(' ');
            SortedDictionary<string, int> namesCount = new SortedDictionary<string, int>();
            foreach (string name in names)
            {
                if (!namesCount.ContainsKey(name))
                {
                    namesCount[name] = 1;
                }
                else
                {
                    namesCount[name]++;
                }
            }

            foreach (var name in namesCount)
            {
                Console.WriteLine("{0} -> {1}", name.Key, name.Value);
            }





        }
    }
}
