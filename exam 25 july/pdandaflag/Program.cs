
using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int count=0,count2=1,count3=65;
            char temp='a';
            for (int i = 0; i < number; i++)
            {
                if ((number / 2) > i)
                {
                    
                    if(count3>90)
                    {
                        count3 = count3 - 26;
                    }
                    string Leftletters = new string((char)count3, 1);
                    count3 = count3 + 1;
                    if (count3 > 90)
                    {
                        count3 = count3 - 26;
                    }
                    string rightLetters = new string((char)count3, 1);
                    string middle = new string('#', number - 2 - count);
                    string side = new string('~', i);
                    count =count+2;
                    count3 = count3 + 1;
                    
                    Console.WriteLine(side + Leftletters + middle + rightLetters + side);
                }
                else if (number / 2 == i)
                {
                    
                    Console.WriteLine("{0}{1}{0}", new string('-', number / 2), (char)(count3));
                }
                else
                {
                    count3 = count3 + 1;
                    if (count3 > 90)
                    {
                        count3 = count3 - 26;
                    }
                    string Leftletters = new string((char)count3, 1);
                    count3 = count3 + 1;
                    if (count3 > 90)
                    {
                        count3 = count3 - 26;
                    }
                    string rightLetters = new string((char)count3, 1);
                    string middle = new string('#',   + count2);
                    string side = new string('~', number-i-1);
                    count2 = count2 + 2;
                    count = count + 2;
                    Console.WriteLine(side + Leftletters + middle + rightLetters + side);
                }
               
            }








        }
    }

