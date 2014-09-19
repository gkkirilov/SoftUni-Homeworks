using System;
using System.Text;

class CopyRightTriangle
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Please enter the row count:");
        int rows = int.Parse(Console.ReadLine());

        char symbol = (char)169;

        int cells = (rows * 2) - 1;
        int symbolIncrement = 1;
        int blankcount;
        int symbolcount;

        Console.WriteLine("Triangle made of {0}", symbol);
        for (int r = 0; r < rows; r++)
        {
            blankcount = cells - symbolIncrement;
            symbolcount = cells - blankcount;

            string blankCells = new String(' ', blankcount / 2);
            string fullCells = new String(symbol, symbolcount);

            Console.Write("{0}{1}", blankCells, fullCells);
            symbolIncrement = symbolIncrement + 2;
            Console.WriteLine();
        }
        
    }
}