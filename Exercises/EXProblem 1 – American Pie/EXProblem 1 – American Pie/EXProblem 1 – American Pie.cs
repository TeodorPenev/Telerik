using System;
using System.Globalization;
    class Program
    {
        static void Main()
        {
            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());
            decimal D = decimal.Parse(Console.ReadLine());
            decimal sumFraction = (A/B + C/D);
            if (sumFraction<1)
            {
                Console.WriteLine(String.Format(CultureInfo.InvariantCulture, 
                   "{0:0.00000000000000000000}", sumFraction));
                Console.WriteLine("{0}/{1}", A * D + B * C, B * D);
            }
            else if (sumFraction>1)
            {
                Console.WriteLine("{0:0}",sumFraction);
                Console.WriteLine("{0}/{1}",A*D+B*C,B*D);
            }
        }
    }

