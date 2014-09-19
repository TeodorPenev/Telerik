//Write a program to read your age from the console and print how old you will be in 10 years.

using System;

class AgeInTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your age:");
        byte age;
        if (byte.TryParse(Console.ReadLine(), out age))
            Console.WriteLine("After 10 years you will be: " + (age + 10));
        else
        {
            Console.WriteLine("Please enter your age. \nClick any key to try again.");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
        Console.ReadKey();
    }
}

