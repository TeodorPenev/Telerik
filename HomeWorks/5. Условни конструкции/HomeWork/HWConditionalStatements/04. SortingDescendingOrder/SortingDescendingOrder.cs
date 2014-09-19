using System;

class SortingDescendingOrder
{
    static void Main()
    {
        int first = 12;
        int second = 10;
        int third = 8;

        if (first > second && second > third)
            Console.WriteLine("{0}, {1}, {2}", first, second, third);
        else if (first > third && third > second)
            Console.WriteLine("{0}, {1}, {2}", first, third, second);
        else if (second > first && first > third)
            Console.WriteLine("{0}, {1}, {2}", second, first, third);
        else if (second > third && third > first)
            Console.WriteLine("{0}, {1}, {2}", second, third, first);
        else if (third > second && second > first)
            Console.WriteLine("{0}, {1}, {2}", third, second, first);
        else if (third > first && first > second)
            Console.WriteLine("{0}, {1}, {2}", third, first, second);
    }
}

// Sort 3 real values in descending order using nested if statements.