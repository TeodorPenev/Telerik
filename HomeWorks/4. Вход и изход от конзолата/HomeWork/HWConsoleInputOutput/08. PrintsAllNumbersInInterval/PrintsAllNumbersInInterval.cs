using System;
/*Write a program that reads an integer number n 
from the console and prints all the numbers 
in the interval [1..n], each on a single line.*/
    class PrintsAllNumbersInInterval
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 2; i < n; i++)
            {
                Console.Write(i);
            }
            
        }
    }

