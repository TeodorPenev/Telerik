using System;
class ChecksOddOrEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if  (n % 2 == 0)
                Console.WriteLine("The number is even!");
            else
                Console.WriteLine("The number is odd!");
            
        }
    }

