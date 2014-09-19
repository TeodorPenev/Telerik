using System;
namespace Problem_1___Coffee_Vending_Machine
{
    class Program
    {
        static void Main()
        {
            double n1 = 0.05 *double.Parse(Console.ReadLine());
            double n2 = 0.10 * double.Parse(Console.ReadLine());
            double n3 = 0.20 * double.Parse(Console.ReadLine());
            double n4 = 0.50 * double.Parse(Console.ReadLine());
            double n5 = 1 * double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double sum = n1+n2+n3+n4+n5;
            if (sum==0)
            {
                Console.WriteLine("Yes 0.00");
            }
            else if (P<=A && sum>=A)
            {
                Console.WriteLine("Yes {0:F2}",sum-(A-P));   
            }
            else if (P>A)
            {
                Console.WriteLine("More {0:F2}",P-A);
            }
            else if (A>P && sum<(A-P))
            {
                Console.WriteLine("No {0:F2}",(A-P)-sum);
            }
        }
    }
}
