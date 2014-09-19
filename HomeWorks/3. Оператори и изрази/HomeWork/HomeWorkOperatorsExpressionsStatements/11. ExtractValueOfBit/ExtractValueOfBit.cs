using System;
class ExtractValueOfBit
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter posision of the bit:");
            int b = int.Parse(Console.ReadLine());
            int mask = 1 << b;
            int vAndMask = i & mask;
            int bit = vAndMask >> b;
            Console.WriteLine("Value of bit:{0}",bit);
        }
    }

