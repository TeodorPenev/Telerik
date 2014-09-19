using System;
using System.Text;
 class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter company name: ");
            string nameCompany = Console.ReadLine();
            Console.WriteLine("Enter company adress: ");
            string addressCompany = Console.ReadLine();
            Console.WriteLine("Enter company phone number: ");
            string phoneNumberCompany = Console.ReadLine(); 
            Console.WriteLine("Enter company fax: ");
            string faxNumberCompany = Console.ReadLine();
            Console.WriteLine("Enter company website: ");
            string webSiteCompany = Console.ReadLine();
            Console.WriteLine("Enter first name of the manager: ");
            string firstNameManager = Console.ReadLine();
            Console.WriteLine("Enter last name of the manager: ");
            string lastNameManager = Console.ReadLine();
            Console.WriteLine("Enter the age of the manager: ");
            string ageManager = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the manager: ");
            string phoneNumberManager = Console.ReadLine();
            
            Console.WriteLine("Information about the Company:");
            Console.WriteLine("Company name: {0}", nameCompany);
            Console.WriteLine("Company address: {0}", addressCompany);
            Console.WriteLine("Company phone: {0}", phoneNumberCompany);
            Console.WriteLine("Company fax: {0}", faxNumberCompany);
            Console.WriteLine("Company website: {0}", webSiteCompany);
            Console.WriteLine("Manager's name: {0} {1}", firstNameManager,lastNameManager);
            Console.WriteLine("Age of the manager: {0}", ageManager);
            Console.WriteLine("Manager's phone: {0}", phoneNumberManager);
        }
 
   }
    


