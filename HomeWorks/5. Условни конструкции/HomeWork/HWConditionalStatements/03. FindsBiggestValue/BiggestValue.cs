using System;

class BiggestValue
{
    static void Main()
    {
        int first = 1;
        int second = 7;
        int third = 3;

        if (first > second && first > third)
        {
            Console.WriteLine("Biggest value is: {0}", first);
        }
        else if (second > first && second > third)
        {
            Console.WriteLine("Biggest value is: {0}", second);
        }
        else if (third > second && third > first)
        {
            Console.WriteLine("Biggest value is: {0}", third);
        }

    }
}

// Write a program that finds the biggest of three integers using nested if statements.