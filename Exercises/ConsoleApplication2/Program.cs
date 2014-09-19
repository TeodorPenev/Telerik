using System;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int result = (A % B);
            Console.WriteLine(result);
            int result2 = result / 4;
            Console.WriteLine(result2);
        }
    }
}
