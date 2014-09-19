using System;
class ModIntToHoldValueOfBit
    {
        static void Main()
        {
            Console.Write("Enter a number n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a possition p=");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter v=");
            int v = int.Parse(Console.ReadLine());
            n = n & (~(1 << p));
            Console.WriteLine(Convert.ToString((~(1 << p)), 2).PadLeft(8, '0'));
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0'));
            n = n | (v << (p));
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(8, '0'));
            Console.WriteLine("{0}", n);

            
        }
    }

