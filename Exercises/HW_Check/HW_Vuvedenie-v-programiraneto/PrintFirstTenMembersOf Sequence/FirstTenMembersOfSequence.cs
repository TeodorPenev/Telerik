//Write a program that prints the first ten members of the sequence: 2, -3, 4, -5, 6, -7...

using System;

class FirstTenMembersOfSequence
{
    static void Main()
    {
        Console.WriteLine("The first ten members of a sequence are: ");
        int n = 1;
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(i * n);
            n *= -1;
        }
    }
}

