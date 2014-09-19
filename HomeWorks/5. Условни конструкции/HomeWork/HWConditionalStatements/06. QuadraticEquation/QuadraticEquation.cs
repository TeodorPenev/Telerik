using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("a*x2 + b*x + c = 0     where 'a' != 0 ");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        // D = b^2 - 4ac  - първо намираме Дискриминантата по тази формула  
        double discriminant = Math.Pow(b, 2) - (4 * a * c);

        if (discriminant < 0)
        {
            Console.WriteLine("0 real roots !");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("1 real root\nx = {0}", x);
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("2 real roots !");
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("X1 = {0:F2} \nX2 = {1:F2}", x1, x2);
        }
    }
}
//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

