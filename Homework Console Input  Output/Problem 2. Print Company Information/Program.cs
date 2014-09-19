using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input Company Name:");
        string companyName =Console.ReadLine();
        Console.Write("Input Company adress:");
        object companyAdress = Console.ReadLine();
        Console.Write("Input Phone Number:");
        int phoneNumber = int.Parse(Console.ReadLine());
        Console.Write("Input Fax Number:");
        int faxNumber = int.Parse(Console.ReadLine());
        Console.Write("Input Web site:");
        object webSite = Console.ReadLine();
        Console.Write("Input Manager First Name:");
        string managerFirst = Console.ReadLine();
        Console.Write("Input Manager Last Name:");
        string managerLast = Console.ReadLine();
        Console.Write("Input Manager Name:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Input Manager Phone Number:");
        int managerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(@"{0}
Adress:{1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager {5} {6}(age:{7},
tel. {8}",companyName,companyAdress,phoneNumber,faxNumber,webSite,managerFirst,managerLast,managerAge,managerNumber);






    }
}

