using System;
    class TrapezoidsArea 
    {
        static void Main()
        {
            Console.WriteLine("Enter length of side a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of side b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height h:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The Trapezoid Area is : {0}",(a+b)/2*h);
        }
    }
