using System;

namespace _12.PrintAgeAfterTenYears
{
    /*  
     ** Write a program to read your age from the console and print how old you will be after 10 years.
     */
    class PrintAge
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Age : ");
            string inputAge = Console.ReadLine();
            int ageAfter10Years = int.Parse(inputAge) + 10;
            Console.WriteLine("After 10 years you will be {0} years old.",ageAfter10Years);
        }
    }
}
