using System;
//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
    class GreaterNumberWithoutIf
    {
        static void Main()
        {
            Console.Write("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is:{0}",Math.Max(num1,num2));
        }
    }

