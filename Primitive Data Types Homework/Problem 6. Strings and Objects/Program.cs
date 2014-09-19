using System;

class Program
{
    static void Main()
    {
        string strOne = "Hello";
        string strTwo = "World";
        object both = strOne + " " + strTwo;
        Console.WriteLine(both);
        string strThree =(string) both;
        Console.WriteLine(strThree);
    }
}
