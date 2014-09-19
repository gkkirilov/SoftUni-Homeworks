using System;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {                                                                   
            int number = int.Parse(Console.ReadLine());
            string temp;
            int sumNumbers = 0,sumSymbols=0,sumLetters=0;
            string all="",chars="";
          
            for (int i = 0; i < number; i++)
			{
                temp=Console.ReadLine();
               all  = all+temp;
			}
           
            string[] splitted =new string[all.Length];
            string result = Regex.Replace(all, " ", "");
             result = Regex.Replace(result, "\t", "");
             result = Regex.Replace(result, "\r", "");
             result = Regex.Replace(result, "\n", "");
             
             result = result.ToLower();
             
             int digit = 0;
             bool check = true;
             foreach (char item in result)
             {
                 temp = Convert.ToString(item);
                 check = int.TryParse(temp, out digit);
                 if (check == true) { 
                 sumNumbers = sumNumbers + digit*20;
                 }
                 else
                 {
                     chars = chars + temp;
                 }
                 
             }
            
         
            
            foreach (char item in chars)
	{

        foreach (var tool in chars)
        {
            for (int i = 97; i <= 122; i++)
            {
                if (tool == (char)i) sumLetters = sumLetters + (i - 96) * 10;
            }
        }
         chars = Regex.Replace(chars, @"[a-z]", "");
	}

           
            foreach (var item in chars)
            {
                sumSymbols = 200 + sumSymbols;
            }
             Console.WriteLine(sumLetters);
             Console.WriteLine(sumNumbers);
             Console.WriteLine(sumSymbols);
        }
    }

