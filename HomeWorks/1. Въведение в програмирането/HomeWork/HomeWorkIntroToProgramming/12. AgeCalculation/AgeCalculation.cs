using System;
 class AgeCalculation
    {
        static void Main()
        {
            Console.Write("Your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age after 10 years: {0} ", age + 10);
        }
    }

