using System;
/*Write a program that gets a number n and after that 
gets more n numbers and calculates and prints their sum.*/
    class GetsMoreNNumbers
    {
        static void Main()
        {
            Console.Write("Enter number n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Some sum of number n:");
            Console.WriteLine(n = n + n + n + n);
        }
    }

