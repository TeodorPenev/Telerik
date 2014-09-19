using System;
    class BitExchangesUInt
    {
        private static int firstGroup;
        static void Main()
        {
            Console.WriteLine("Enter integer: ");
            uint i = uint.Parse(Console.ReadLine());
            string binV = Convert.ToString(i, 2).PadLeft(32, '0');
            Console.WriteLine("Binary value:\n{0}", binV);
            int mask = 7; 
            uint first = (uint)(mask << 3) & i; 
            uint second = (uint)(mask << 24) & i; 
            first = first << 21; 
            second = second >> 21; 
            i = (uint)(i & (~(mask << 3))); 
            i = (uint)(i & (~(mask << 24)));
            i = (uint)(i | first);
            i = (uint)(i | second);

            Console.WriteLine("The binary exchanged bits :\n" + Convert.ToString(i, 2).PadLeft(32, '0'));
        }
    }

