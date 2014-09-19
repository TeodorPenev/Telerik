using System;

    class CheckBit3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int bitAndMask = n & mask;
            int bit = bitAndMask >> p;
            Console.WriteLine("The third bit is: {0}",bit);
            Convert.ToString(bitAndMask, 2);
            
        }
    }

