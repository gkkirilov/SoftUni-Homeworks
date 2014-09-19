using System;


class Program
{
    static void Main(string[] args)
    {
        
        string leap=Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double weekends = 48;
        double playTime = 0;
        
        weekends = weekends - h;
        weekends =  weekends*0.75;
        p =  p*0.66;
        playTime = h + p + weekends;
        if (leap == "leap") playTime = playTime*1.15;
        playTime = Math.Floor(playTime);
       
        Console.WriteLine((int)playTime);


    }
}

