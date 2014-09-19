using System;

    class Program
    {
        static void Main()
        {


            for (int i = 2; i < 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (i)
                    {
                        case 11:
                            Console.WriteLine("J♣ J♦ J♥ J♠");
                            break;
                        case 12:
                            Console.WriteLine("Q♣ Q♦ Q♥ Q♠");
                            break;
                        case 13:
                            Console.WriteLine("K♣ K♦ K♥ K♠");
                            break;
                        case 14:
                            Console.WriteLine("A♣ A♦ A♥ A♠");
                            break;
                        default:
                            Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                            break;
                    }
                    
                }
            }


        }
    }

