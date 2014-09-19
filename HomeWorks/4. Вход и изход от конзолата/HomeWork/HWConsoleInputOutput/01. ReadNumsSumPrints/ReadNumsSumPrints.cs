using System;
class ReadNumsSumPrints
    {
        static void Main()
    {
            Console.Write("Enter first integer number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer number:");    
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer number:"); 
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum:{0}",a+b+c);
        }
    }
