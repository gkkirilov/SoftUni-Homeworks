using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[9, 9];
            // pravi sudokuto no to e vinagi ednakvo
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                   // Console.WriteLine(grid[i,j]);
                }
            }
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Random rand2 = new Random(Guid.NewGuid().GetHashCode());
            int shuffleLevel = 10;
            for (int g = 0; g < shuffleLevel;g++ )
            {
                int xParm1, yParm1, xParm2, yParm2, findValue1 = rand.Next(1, 9), findValue2 = rand.Next(1, 9);
                xParm1 = yParm1 = xParm2 = yParm2 = 0;
                for (int i = 0; i < 9; i += 3)
                {
                    for (int k = 0; k < 9; k += 3)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            for (int z = 0; z < 3; z++)
                            {
                                if (grid[i + j, k + z] == findValue1)
                                {
                                    xParm1 = i + j;
                                    yParm1 = k + z;
                                }

                                if (grid[i + j, k + z] == findValue2)
                                {
                                    xParm2 = i + j;
                                    yParm2 = k + z;
                                }
                            }
                        }
                        grid[xParm1, yParm1] = findValue2;
                        grid[xParm2, yParm2] = findValue1;
                    }
                }

            }




            // chertae sudokuto
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    Console.Write(grid[x,y]+ " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
           


        }
    }
}
