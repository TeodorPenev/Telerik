using System;
class IntExchangeValues
    {
        static void Main()
        {
            int n1 = 5;
            int n2 = 10;
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }

