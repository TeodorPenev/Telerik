using System;
class BoolExpOfBit
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter posision of the bit:");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int vAndMask = v & mask;
            int bit = vAndMask >> p;
            bool check = bit == 1;
            Console.Write("The bit is 1:");
            Console.WriteLine(check);
        }
    }

